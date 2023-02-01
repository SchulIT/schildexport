using SchulIT.SchildExport;
using SchulIT.SchildExport.Entity;
using SchulIT.SchildExport.Tool.Unterricht;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchildExport.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /**
             * Datenbankparameter abfragen
             */
            var host = AnsiConsole.Ask<string>("Host", "localhost");
            var port = AnsiConsole.Ask<int>("Port", 3306);
            var database = AnsiConsole.Ask<string>("Name der Datenbank", "svws");
            var username = AnsiConsole.Ask<string>("Benutzername", "svwsadmin");
            var password = AnsiConsole.Prompt(new TextPrompt<string>("Passwort").Secret());

            /**
             * Datenbank-Reader und -Writer konfigurieren
             */
            AnsiConsole.WriteLine("Datenbankzugriff konfigurieren...");
            var databaseReader = new SvwsDatabaseReader();
            databaseReader.Configure(host, port, database, username, password, false);

            var databaseWriter = new SvwsDatabaseWriter();
            databaseWriter.Configure(host, port, database, username, password, false);

            /**
             * Schritt 1: Informationen über die eigene Schule abfragen. Das ist wichtig, 
             * um z.B. den aktuellen Schuljahresabschnitt herauszufinden
             */
            var schule = await databaseReader.GetEigeneSchuleAsync();

            PrintEigeneSchuleTable(schule);

            /**
             * Lehrkräfte abrufen (in Abhängigkeit vom ausgewählten Schuljahresabschnitt - hier: der aktuelle Schuljahresabschnitt)
             */
            PrintLehrkraefte(await databaseReader.GetLehrkraefteAsync(schule.SchuljahresabschnittId));

            /**
             * Klassen abrufen (in Abhängigkeit vom ausgewählten Schuljahresabschnitt - hier: der aktuelle Schuljahresabschnitt)
             */
            PrintKlassen(await databaseReader.GetKlassenAsync(schule.SchuljahresabschnittId));

            /**
             * Fächer abrufen (diese haben keine Abhängigkeit zu einem Schuljahresabschnitt)
             */
            PrintFaecher(await databaseReader.GetFaecherAsync());

            /**
             * Lernende abrufen (in Abhängigkeit vom ausgewählten Schuljahresabschnitt - hier: der aktuelle Schuljahresabschnitt)
             */
            var students = await databaseReader.GetKinderAsync(schule.SchuljahresabschnittId);
            PrintKinder(students, schule.SchuljahresabschnittId);

            /**
             * Kurse abrufen (in Abhängigkeit vom ausgewählten Schuljahresabschnitt - hier: der aktuelle Schuljahresabschnitt)
             */
            var kurse = await databaseReader.GetKurseAsync(schule.SchuljahresabschnittId);
            PrintKurse(kurse);

            /**
             * Leistungsdaten abrufen (in Abhängigkeit vom ausgewählten Schuljahresabschnitt - hier: der aktuelle Schuljahresabschnitt)
             */
            var leistungsdaten = await databaseReader.GetLeistungsdatenAsync(schule.SchuljahresabschnittId);

            /**
             * Mit den Leistungsdaten und Kursen können nun Unterrichte rekonstruiert werden (in Abhängigkeit vom ausgewählten 
             * Schuljahresabschnitt - hier: der aktuelle Schuljahresabschnitt).
             * 
             * Hier sind jetzt auch die Kursart (PUT, PUK, GKS, GKM, usw.) verfügbar
             */
            var unterrichte = (new UnterrichtResolver()).Resolve(leistungsdaten, kurse, schule.SchuljahresabschnittId);
            PrintUnterrichte(unterrichte);

            /**
             * Kurse abrufen (diese haben keine Abhängigkeit zu einem Schuljahresabschnitt)
             */
            PrintDatenschutzKategorien(await databaseReader.GetDatenschutzKategorienAsync());

            /**
             * Der folgende Schnipsel zeigt folgendes:
             * - prüfen, ob eine Lernplattform vorhanden ist
             * - Erstellen einer Lernplattform
             * - prüfen, ob Zustimmungen und/oder initiale Zugangsdaten vorhanden sind
             * - Erstellen von Zustimmungen und/oder initialen Zugangsdaten
             */

            // Alle Lernplattformen abrufen
            var lernplattformen = await databaseReader.GetLernplattformenAsync();
            var lernplattformName = "Testplattform";

            PrintLernplattformen(lernplattformen);

            // Lernplattform suchen - hier anhand des Namens, bei realen Anwendungen sollte eher die Id der Lerngruppe zwecks Abgleich verwendet werden:
            var testplattform = lernplattformen.FirstOrDefault(x => x.Bezeichnung == lernplattformName);
            // Besser: var testplattform = lernplattformen.FirstOrDefault(x => x.Id == dieBekannteId);

            if (testplattform == null)
            {
                // Lernplattform nicht vorhanden -> erstellen
                AnsiConsole.MarkupLine(":cross_mark: Lernplattform nicht vorhanden");
                testplattform = new Lernplattform
                {
                    // Wichtig: KEINE Id händisch setzen (wird von der Datenbank erzeugt)

                    Bezeichnung = lernplattformName,
                    BenutzernameSuffixErzieher = "@e.schulit.de",
                    BenutzernameSuffixLehrkraefte = "@l.schulit.de",
                    BenutzernameSuffixKinder = "@s.schulit.de"
                };
                await AnsiConsole.Status()
                    .StartAsync("Lege Lernplattform an...", _ => databaseWriter.InsertOrUpdateLernplattformAsync(testplattform));
                AnsiConsole.MarkupLine(":check_mark: Lernplattform erstellt");

                // Hinweis: Die Id der soeben erstellten Lerngruppe ist nun verfügbar!
            }
            else
            {
                // Lernplattform vorhanden -> nichts tun
                AnsiConsole.MarkupLine(":check_mark: Lernplattform vorhanden");
            }

            /**
             * Jetzt geht es an die Zustimmungen
             */

            var zustimmungen = new List<KindLernplattform>();

            foreach (var student in students)
            {
                /**
                 * ACHTUNG: Der Benutzername muss PRO LERNPLATTFORM eindeutig sein (ist ein Datenbank-Konstraint)
                 * Auf Existenz prüfen: await databaseReader.IsUsernameAlreadyTakenAsync(lernplattform, benutzername);
                 **/
                var benutzername = $"{student.Vorname.ToLower()}.{student.Nachname.ToLower()}-{Guid.NewGuid()}@s.schulit.de";

                /**
                 * Erstelle ein Zugangsdaten für die Lernplattform. Dieses Objekt wird später genutzt, falls es keine Zugangsdaten
                 * gibt. Falls es bereits Zugangsdaten gibt, wird das Objekt verworfen.
                 */
                var zugangsdaten = new LernplattformZugangsdaten
                {
                    LernplattformId = testplattform.Id,
                    Benutzername = benutzername,
                    InitialKennwort = $"PW#{Faker.RandomNumber.Next(100000, 9999999)}"
                };

                // Prüfe, ob eine Zustimmung bereits vorliegt
                var zustimmung = student.LernplattformZustimmungen.FirstOrDefault(x => x.LernplattformId == testplattform.Id);
                if (zustimmung == null) 
                {
                    // Zustimmung nicht vorhanden -> anlegen
                    AnsiConsole.MarkupLine($"> Erstelle Zustimmung für {student.Nachname}, {student.Vorname}");

                    zustimmung = new KindLernplattform
                    {
                        KindId = student.Id,
                        LernplattformId = testplattform.Id,
                        // Die ZugangsdatenId NICHT setzen, da sie noch nicht existiert
                        Zugangsdaten = zugangsdaten, // hier verwenden wir die oben erstellten Zugangsdaten
                        IstAudiokonferenzEingewilligt = false,
                        IstVideokonferenzEingewilligt = false,
                        IstNutzungEingewilligt = true,
                        IstEinwilligungAbgefragt = true
                    };

                    /**
                     * Da Zustimmungen nicht einzeln in die Datenbank eingefügt werden (das ginge theoretisch zwar auch, kostet aber mehr Zeit),
                     * merken wir uns die Zustimmungen zunächst vor
                     */
                    zustimmungen.Add(zustimmung);
                }
                else
                {
                    // Zustimmung vorhanden
                    AnsiConsole.MarkupLine($"> Zustimmung für {student.Nachname}, {student.Vorname} vorhanden");

                    // Es kann gut sein, dass eine Zustimmung vorliegt, aber noch keine Zugangsdaten existieren
                    if (zustimmung.Zugangsdaten == null)
                    {
                        // Zugangsdaten fehlen -> erstellen
                        AnsiConsole.MarkupLine(">> Zugangsdaten fehlen, erzeuge sie");

                        // Setze die Zugangsdaten entsprechend (die ZugangsdatenId NICHT setzen, da sie noch nicht existiert)...
                        zustimmung.Zugangsdaten = zugangsdaten;

                        // ... und merke die Zustimmung vor, da sie aktualisiert werden muss
                        zustimmungen.Add(zustimmung);
                    }
                }
            }

            AnsiConsole.MarkupLine("Schreibe Zustimmungen in Datenbank");

            /**
             * Schreibe alle Änderungen in die Datenbank. Hier werden die entsprechenden Zustimmungen und auch (bei Bedarf)
             * die Zugangsdaten erstellt (Objekte vom Typ LerngruppeZugangsdaten müssen daher NICHT separat in die Datenbank
             * eingefügt werden).
             */
            await databaseWriter.InsertOrUpdateLernplattformZustimmungenBulkAsync(zustimmungen);
        }

        private static void PrintEigeneSchuleTable(EigeneSchule schule)
        {
            var table = new Table();
            table.AddColumns("SchulNr", "Bezeichnung1", "Bezeichnung2", "Bezeichnung3", "Aktuelles Schuljahr");
            table.AddRow(schule.SchulNr, schule.Bezeichnung1, schule.Bezeichnung2, schule.Bezeichnung3, schule.AktuellerAbschnitt == null ? "N/A" : $"{schule.AktuellerAbschnitt.Jahr}/{schule.AktuellerAbschnitt.Abschnitt}");
            AnsiConsole.Write(table);
        }

        private static void PrintLehrkraefte(IEnumerable<Lehrkraft> lehrkraefte)
        {
            var table = new Table();
            table.AddColumns("Kürzel", "Nachname", "Vorname", "Titel", "Amtsbez.", "Geschlecht", "EMail", "Fächer");

            foreach (var lehrkraft in lehrkraefte)
            {
                table.AddRow(lehrkraft.Kuerzel ?? "<leer>", lehrkraft.Nachname ?? "<leer>", lehrkraft.Vorname ?? "<leer>", lehrkraft.Titel ?? "<leer>", lehrkraft.Amtsbezeichnung ?? "<leer>", lehrkraft.Geschlecht.ToString(), lehrkraft.EmailDienstlich ?? "<leer>", string.Join(", ", lehrkraft.Lehrbefaehigungen.Select(x => x.FachKuerzel)));
            }

            AnsiConsole.Write(table);
        }

        private static void PrintKlassen(IEnumerable<Klasse> klassen)
        {
            var table = new Table();
            table.AddColumns("Name", "Bezeichnung", "Klassenleitung");

            foreach(var klasse in klassen)
            {
                table.AddRow(klasse.Name ?? "<leer>", klasse.Bezeichnung ?? "<leer>", string.Join(", ", klasse.Klassenleitung.Select(x => x.Lehrkraft.Kuerzel)));
            }

            AnsiConsole.Write(table);
        }

        private static void PrintFaecher(IEnumerable<Fach> faecher)
        {
            var table = new Table();
            table.AddColumns("Kürzel", "Bezeichnung");

            foreach(var fach in faecher)
            {
                table.AddRow(fach.Kuerzel ?? "<leer>", fach.Bezeichnung ?? "<leer>");
            }

            AnsiConsole.Write(table);
        }

        private static void PrintKinder(IEnumerable<Kind> kinder, int schuljahresabschnittsId)
        {
            var table = new Table();
            table.AddColumns("Nachname", "Vorname", "Geschlecht", "Geburtsdatum", "Status", "EMail", "Klasse");

            foreach(var kind in kinder)
            {
                var aktuellerAbschnitt = kind.Lernabschnitte.FirstOrDefault(x => x.SchuljahresabschnittId == schuljahresabschnittsId);

                if (aktuellerAbschnitt != null)
                {
                    table.AddRow(kind.Nachname, kind.Vorname, kind.Geschlecht.ToString(), kind.Geburtsdatum != null ? kind.Geburtsdatum.ToString() : "<leer>", kind.Status.ToString(), kind.SchulEmail ?? "<leer>", aktuellerAbschnitt.Klasse.Name);
                }
            }

            AnsiConsole.Write(table);
        }

        private static void PrintKurse(IEnumerable<Kurs> kurse)
        {
            var table = new Table();
            table.AddColumns("Bezeichnung", "Fach", "Lehrkräfte", "Anzahl SuS");

            foreach(var kurs in kurse)
            {
                var lehrkraefte = new List<Lehrkraft> { kurs.Lehrkraft };
                lehrkraefte.AddRange(kurs.Lehrkraefte.Select(x => x.Lehrkraft));

                table.AddRow(kurs.Bezeichnung, kurs.Fach.Kuerzel, string.Join(", ", lehrkraefte.Select(x => x.Kuerzel)), kurs.Kinder.Count().ToString());
            }

            AnsiConsole.Write(table);
        }

        private static void PrintUnterrichte(IEnumerable<Unterricht> unterrichte)
        {
            var table = new Table();
            table.AddColumns("Fach", "Kurs", "Klasse(n)", "Lehrkraefte", "SuS");

            foreach(var unterricht in unterrichte)
            {
                var sus = new Table();
                sus.AddColumns("Nachname", "Vorname", "Art");

                foreach(var kind in unterricht.Kinder)
                {
                    sus.AddRow(kind.Kind.Nachname, kind.Kind.Vorname, kind.Art);
                }

                table.AddRow(
                    new Markup(unterricht.Fach.Kuerzel),
                    new Markup(unterricht.Kurs != null ? unterricht.Kurs.Bezeichnung : "<leer>"),
                    new Markup(string.Join(", ", unterricht.Klassen.Select(x => x.Name))),
                    new Markup(string.Join(", ", unterricht.Lehrkraefte.Select(x => x.Kuerzel))),
                    sus
                );
            }

            AnsiConsole.Write(table);   
        }

        private static void PrintDatenschutzKategorien(IEnumerable<DatenschutzKategorie> kategorien)
        {
            var table = new Table();
            table.AddColumns("Bezeichnung", "Beschreibung");

            foreach(var kategorie in kategorien)
            {
                table.AddRow(kategorie.Bezeichnung ?? "<leer>", kategorie.Beschreibung ?? "<leer>");
            }

            AnsiConsole.Write(table);
        }

        private static void PrintLernplattformen(IEnumerable<Lernplattform> lernplattformen)
        {
            var table = new Table();
            table.AddColumns("Bezeichnung", "Suffix Lehrkräfte", "Suffix Eltern", "Suffix Lernende");

            foreach(var lernplattform in lernplattformen)
            {
                table.AddRow(lernplattform.Bezeichnung, lernplattform.BenutzernameSuffixLehrkraefte ?? "<leer>", lernplattform.BenutzernameSuffixErzieher ?? "<leer>", lernplattform.BenutzernameSuffixKinder ?? "<leer>");
            }

            AnsiConsole.Write(table);
        }
    }
}
