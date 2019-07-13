using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class EigeneSchuleFaecher
    {
        public EigeneSchuleFaecher()
        {
            SchuelerAbiFaecher = new HashSet<SchuelerAbiFaecher>();
            SchuelerBkfaecher = new HashSet<SchuelerBkfaecher>();
            SchuelerFhrfaecher = new HashSet<SchuelerFhrfaecher>();
            SchuelerLeistungsdaten = new HashSet<SchuelerLeistungsdaten>();
            SchuelerSprachenfolge = new HashSet<SchuelerSprachenfolge>();
            StundentafelFaecher = new HashSet<StundentafelFaecher>();
        }

        public int Id { get; set; }
        public string FachKrz { get; set; }
        public string Bezeichnung { get; set; }
        public string ZeugnisBez { get; set; }
        public string UeZeugnisBez { get; set; }
        public string StatistikKrz { get; set; }
        public string BasisFach { get; set; }
        public string IstSprache { get; set; }
        public short? Sortierung { get; set; }
        public short? SortierungS2 { get; set; }
        public string NachprErlaubt { get; set; }
        public string Sichtbar { get; set; }
        public string Aenderbar { get; set; }
        public short? Gewichtung { get; set; }
        public int? FachgruppeId { get; set; }
        public string Unterichtssprache { get; set; }
        public string IstSchriftlich { get; set; }
        public string IstSchriftlichBa { get; set; }
        public string AufZeugnis { get; set; }
        public string Lernfelder { get; set; }
        public int? SchulnrEigner { get; set; }
        public string LkMoegl { get; set; }
        public string AbiMoegl { get; set; }
        public string E1 { get; set; }
        public string E2 { get; set; }
        public string Q1 { get; set; }
        public string Q2 { get; set; }
        public string Q3 { get; set; }
        public string Q4 { get; set; }
        public string AlsNeueFsinSii { get; set; }
        public int? LeitfachId { get; set; }
        public int? Leitfach2Id { get; set; }
        public string Aufgabenfeld { get; set; }
        public string AbgeschlFaecherHolen { get; set; }
        public int? GewichtungFhr { get; set; }
        public int? E1Wze { get; set; }
        public int? E2Wze { get; set; }
        public int? QWze { get; set; }
        public string E1S { get; set; }
        public string E2S { get; set; }
        public string NurMuendlich { get; set; }
        public int? MaxBemZeichen { get; set; }

        public virtual ICollection<SchuelerAbiFaecher> SchuelerAbiFaecher { get; set; }
        public virtual ICollection<SchuelerBkfaecher> SchuelerBkfaecher { get; set; }
        public virtual ICollection<SchuelerFhrfaecher> SchuelerFhrfaecher { get; set; }
        public virtual ICollection<SchuelerLeistungsdaten> SchuelerLeistungsdaten { get; set; }
        public virtual ICollection<SchuelerSprachenfolge> SchuelerSprachenfolge { get; set; }
        public virtual ICollection<StundentafelFaecher> StundentafelFaecher { get; set; }
    }
}
