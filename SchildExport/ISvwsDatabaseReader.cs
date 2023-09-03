using SchulIT.SchildExport.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulIT.SchildExport
{
    public interface ISvwsDatabaseReader : IDatabaseConfigurator
    {
        Task<EigeneSchule> GetEigeneSchuleAsync();

        Task<List<Schuljahresabschnitt>> GetSchuljahresabschnitteAsync();

        Task<List<Lehrkraft>> GetLehrkraefteAsync();

        Task<List<Lehrkraft>> GetLehrkraefteAsync(long schuljahresabschnittId);

        Task<List<Klasse>> GetKlassenAsync(long schuljahresabschnittId);

        Task<List<Fach>> GetFaecherAsync();

        Task<List<Kind>> GetKinderAsync(long schuljahresabschnittId);

        Task<List<Kurs>> GetKurseAsync(long schuljahresabschnittId);

        Task<List<DatenschutzKategorie>> GetDatenschutzKategorienAsync();

        Task<List<Lernplattform>> GetLernplattformenAsync();

        Task<List<KindLeistungsdaten>> GetLeistungsdatenAsync(long schuljahresabschnittId);


        /// <summary>
        /// Liefert ein Dictionary mit bereits für die angegeben Lernplattform vergebene Benutzernamen.
        /// Der Schlüssel ist der verwendete Benutzername und der eigentliche Wert ist die ID des zugehörigen
        /// Kindes.
        /// </summary>
        /// <param name="lernplattformId"></param>
        /// <returns></returns>
        Task<Dictionary<string, long>> GetUsernamesInUseAsync(long lernplattformId);
    }
}