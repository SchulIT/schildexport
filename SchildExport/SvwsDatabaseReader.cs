using LinqToDB;
using LinqToDB.Data;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SchulIT.SchildExport
{
    public class SvwsDatabaseReader : ISvwsDatabaseReader
    {
        public void Configure(string host, int port, string database, string username, string password, bool enableTrace)
        {
            if(enableTrace)
            {
                DataConnection.TurnTraceSwitchOn();
                DataConnection.WriteTraceLine = (message, displayName, level) => { Console.WriteLine($"{message} {displayName}"); };
            }

            DataConnection.DefaultSettings = new DatabaseSettings(host, port, database, username, password);
        }

        public async Task<EigeneSchule> GetEigeneSchuleAsync()
        {
            using var connection = new SvwsConnection();
            return await connection.EigeneSchule
                .LoadWith(x => x.AktuellerAbschnitt)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Schuljahresabschnitt>> GetSchuljahresabschnitteAsync()
        {
            using var connection = new SvwsConnection();
            return await connection.Schuljahresabschnitte.OrderByDescending(x => x.Jahr).ThenByDescending(x => x.Abschnitt).ToListAsync();
        }

        public async Task<List<Lehrkraft>> GetLehrkraefteAsync()
        {
            using var connection = new SvwsConnection();
            return await connection.Lehrkraefte
                .LoadWith(x => x.Abschnittsdaten)
                .LoadWith(x => x.Lehrbefaehigungen)
                .ToListAsync();
        }

        public async Task<List<Lehrkraft>> GetLehrkraefteAsync(long schuljahresabschnittId)
        {
            using var connection = new SvwsConnection();
            return await connection.Lehrkraefte
                .LoadWith(x => x.Abschnittsdaten)
                .LoadWith(x => x.Lehrbefaehigungen)
                .Where(x => x.Abschnittsdaten.Where(x => x.SchuljahresabschnittId == schuljahresabschnittId).Any())
                .ToListAsync();
        }

        public async Task<List<Klasse>> GetKlassenAsync(long schuljahresabschnittId)
        {
            using var connection = new SvwsConnection();
            return await connection.Klassen
                .LoadWith(x => x.Klassenleitung).ThenLoad(x => x.Lehrkraft)
                .Where(x => x.SchuljahresabschnittId == schuljahresabschnittId)
                .ToListAsync();
        }

        public async Task<List<Fach>> GetFaecherAsync()
        {
            using var connection = new SvwsConnection();
            return await connection.Faecher
                .ToListAsync();
        }

        public async Task<List<Kind>> GetKinderAsync(long schuljahresabschnittId)
        {
            using var connection = new SvwsConnection();
            return await connection.Kinder
                .LoadWith(x => x.Lernabschnitte).ThenLoad(x => x.Klasse)
                .LoadWith(x => x.DatenschutzZustimmungen).ThenLoad(x => x.Kategorie)
                .LoadWith(x => x.LernplattformZustimmungen).ThenLoad(x => x.Zugangsdaten)
                .LoadWith(x => x.LernplattformZustimmungen).ThenLoad(x => x.Lernplattform)
                .Where(x => x.Lernabschnitte.Where(y => y.SchuljahresabschnittId == schuljahresabschnittId).Any())
                .ToListAsync();
        }

        public async Task<List<Kurs>> GetKurseAsync(long schuljahresabschnittId)
        {
            using var connection = new SvwsConnection();
            return await connection.Kurse
                .LoadWith(x => x.Fach)
                .LoadWith(x => x.Lehrkraft)
                .LoadWith(x => x.Lehrkraefte).ThenLoad(x => x.Lehrkraft)
                .LoadWith(x => x.Kinder).ThenLoad(x => x.Kind)
                .Where(x => x.SchuljahresabschnittId == schuljahresabschnittId)
                .ToListAsync();
        }

        public async Task<List<KindLeistungsdaten>> GetLeistungsdatenAsync(long schuljahresabschnittId)
        {
            using var connection = new SvwsConnection();
            return await connection.Leistungsdaten
                .LoadWith(x => x.Fach)
                .LoadWith(x => x.Lehrkraft)
                .LoadWith(x => x.Kurs).ThenLoad(x => x.Lehrkraft)
                .LoadWith(x => x.Kurs).ThenLoad(x => x.Lehrkraefte)
                .LoadWith(x => x.Kurs).ThenLoad(x => x.Fach)
                .LoadWith(x => x.Lernabschnitt).ThenLoad(x => x.Kind)
                .LoadWith(x => x.Lernabschnitt).ThenLoad(x => x.Klasse)
                .Where(x => x.Lernabschnitt.SchuljahresabschnittId == schuljahresabschnittId)
                .ToListAsync();
        }

        public async Task<List<DatenschutzKategorie>> GetDatenschutzKategorienAsync()
        {
            using var connection = new SvwsConnection();
            return await connection.DatenschutzKategorien
                .ToListAsync();
        }

        public async Task<List<Lernplattform>> GetLernplattformenAsync()
        {
            using var connection = new SvwsConnection();
            return await connection.Lernplattformen
                .ToListAsync();
        }

        public async Task<Dictionary<string, long>> GetUsernamesInUseAsync(long lernplattformId)
        {
            using var connection = new SvwsConnection();
            // Keine Ahnung, wie JOINs mit der Fluent API funktionieren, daher LINQ
            var query = from
                k in connection.Kinder
                        join p in connection.KindLernplattformZustimmungen on k.Id equals p.KindId
                        join z in connection.LernplattformZugangsdaten on p.ZugangsdatenId equals z.Id
                        where p.LernplattformId == lernplattformId
                        select new { k.Id, z.Benutzername };

            return await query.ToDictionaryAsync(x => x.Benutzername, x => x.Id);
        }
    }
}
