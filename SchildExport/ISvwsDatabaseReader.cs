using SchulIT.SchildExport.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulIT.SchildExport
{
    public interface ISvwsDatabaseReader : IDatabaseConfigurator
    {
        Task<EigeneSchule> GetEigeneSchuleAsync();

        Task<List<Lehrkraft>> GetLehrkraefteAsync();

        Task<List<Lehrkraft>> GetLehrkraefteAsync(int schuljahresabschnittId);

        Task<List<Klasse>> GetKlassenAsync(int schuljahresabschnittId);

        Task<List<Fach>> GetFaecherAsync();

        Task<List<Kind>> GetKinderAsync(int schuljahresabschnittId);

        Task<List<Kurs>> GetKurseAsync(int schuljahresabschnittId);

        Task<List<DatenschutzKategorie>> GetDatenschutzKategorienAsync();

        Task<List<Lernplattform>> GetLernplattformenAsync();

        public Task<bool> IsUsernameAlreadyTakenAsync(Lernplattform lernplattform, string benutzername);
    }
}