using SchulIT.SchildExport.Entity;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Tool.Unterricht
{
    public class UnterrichtResolver
    {
        public List<Unterricht> Resolve(IEnumerable<KindLeistungsdaten> leistungsdaten, IEnumerable<Kurs> kurse, long schuljahresabschnittId)
        {
            var kinder = leistungsdaten
                .GroupBy(x => x.Lernabschnitt.KindId)
                .ToDictionary(x => x.Key, x => x.First().Lernabschnitt.Kind);

            // Klassenunterrichte
            var klassenunterrichte = leistungsdaten
                .Where(x => x.KursId == null)
                .GroupBy(x => new { x.FachId, x.LehrkraftId, x.ZusaetzlicheLehrkraftId, x.Lernabschnitt.KlasseId, x.Kursart })
                .Select(x =>
                {
                    var first = x.First();
                    var unterricht = new Unterricht
                    {
                        Kurs = null,
                        Fach = first.Fach
                    };

                    if (first.Lehrkraft != null)
                    {
                        unterricht.Lehrkraefte.Add(first.Lehrkraft);
                    }

                    if(first.ZusaetzlicheLehrkraft != null)
                    {
                        unterricht.Lehrkraefte.Add(first.ZusaetzlicheLehrkraft);
                    }

                    foreach (var ld in x)
                    {
                        var klasse = ld.Lernabschnitt.Klasse;

                        if (!unterricht.Klassen.Any(x => x.Id == klasse.Id))
                        {
                            unterricht.Klassen.Add(klasse);
                        }

                        unterricht.Kinder.Add(new Mitgliedschaft
                        {
                            Art = ld.Kursart,
                            Kind = ld.Lernabschnitt.Kind
                        });
                    }

                    return unterricht;
                }).ToList();

            // Kursunterrichte
            var kursunterrichte = new List<Unterricht>();

            foreach(var kurs in kurse)
            {
                var unterricht = new Unterricht
                {
                    Kurs = kurs,
                    Fach = kurs.Fach,
                    Lehrkraefte = kurs.Lehrkraefte.Select(x => x.Lehrkraft).ToList()
                };

                if(kurs.Lehrkraft != null)
                {
                    unterricht.Lehrkraefte.Add(kurs.Lehrkraft);
                }
                
                foreach(var kind in leistungsdaten.Where(x => x.KursId == kurs.Id))
                {
                    var klasse = kind.Lernabschnitt.Klasse;

                    if(!unterricht.Klassen.Any(x => x.Id == klasse.Id))
                    {
                        unterricht.Klassen.Add(klasse);
                    }

                    unterricht.Kinder.Add(new Mitgliedschaft
                    {
                        Kind = kind.Lernabschnitt.Kind,
                        Art = kind.Kursart
                    });
                }

                kursunterrichte.Add(unterricht);
            }

            return klassenunterrichte.Union(kursunterrichte).ToList();
        }
    }
}
