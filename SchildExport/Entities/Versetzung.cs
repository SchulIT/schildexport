using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class Versetzung
    {
        public Versetzung()
        {
            EigeneSchuleAbtKl = new HashSet<EigeneSchuleAbtKl>();
            Schueler = new HashSet<Schueler>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public string Asdklasse { get; set; }
        public string Klasse { get; set; }
        public int? JahrgangId { get; set; }
        public string Fklasse { get; set; }
        public string Vklasse { get; set; }
        public string OrgFormKrz { get; set; }
        public string KlassenlehrerKrz { get; set; }
        public string StvKlassenlehrerKrz { get; set; }
        public short? Restabschnitte { get; set; }
        public string AsdschulformNr { get; set; }
        public int? FachklasseId { get; set; }
        public string PruefOrdnung { get; set; }
        public string Sichtbar { get; set; }
        public short? Sortierung { get; set; }
        public string Klassenart { get; set; }
        public string SommerSem { get; set; }
        public string NotenGesperrt { get; set; }
        public int? SchulnrEigner { get; set; }
        public string AdrMerkmal { get; set; }
        public string WebNotenGesperrt { get; set; }
        public string KoopKlasse { get; set; }
        public string Ankreuzzeugnisse { get; set; }

        public virtual KLehrer KlassenlehrerKrzNavigation { get; set; }
        public virtual ICollection<EigeneSchuleAbtKl> EigeneSchuleAbtKl { get; set; }
        public virtual ICollection<Schueler> Schueler { get; set; }
    }
}
