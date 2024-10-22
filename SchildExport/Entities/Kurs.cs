﻿using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entities
{
    [Table(Name = "Kurse")]
    class Kurs
    {
        [Column(Name = "ID"), PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "Jahr")]
        public short Jahr { get; set; }

        [Column(Name = "Abschnitt")]
        public short Abschnitt { get; set; }

        [Column(Name = "KurzBez")]
        public string KurzBez { get; set; }

        [Column(Name = "Jahrgang_ID")]
        public int? JahrgangId { get; set; }

        [Column(Name = "Jahrgaenge")]
        public string Jahrgaenge { get; set; }

        [Column(Name = "Fach_ID")]
        public int FachId { get; set; }

        [Column(Name = "Sichtbar")]
        public char? Sichtbar { get; set; }

        [Column(Name = "LehrerKrz")]
        public string LehrerKuerzel { get; set; }

        [Column(Name = "Zeugnisbez")]
        public string Zeugnisbez { get; set; }
    }
}