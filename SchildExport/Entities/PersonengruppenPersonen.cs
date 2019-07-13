using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class PersonengruppenPersonen
    {
        public int Id { get; set; }
        public int SchulnrEigner { get; set; }
        public int GruppeId { get; set; }
        public int? PersonId { get; set; }
        public int? PersonNr { get; set; }
        public string PersonArt { get; set; }
        public string PersonName { get; set; }
        public string PersonVorname { get; set; }
        public string PersonPlz { get; set; }
        public string PersonOrt { get; set; }
        public string PersonStrasse { get; set; }
        public string PersonTelefon { get; set; }
        public string PersonMobil { get; set; }
        public string PersonEmail { get; set; }
        public string Bemerkung { get; set; }
        public string ZusatzInfo { get; set; }
        public int? Sortierung { get; set; }
        public string PersonAnrede { get; set; }
        public string PersonAkadGrad { get; set; }
    }
}
