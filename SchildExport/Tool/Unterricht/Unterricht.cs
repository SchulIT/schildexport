using SchulIT.SchildExport.Entity;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Tool.Unterricht
{
    public class Unterricht
    {
        public Fach Fach { get; set; }

        public List<Lehrkraft> Lehrkraefte { get; set; } = new List<Lehrkraft>();

        public List<Klasse> Klassen { get; set; } = new List<Klasse>();

        public Kurs Kurs { get; set; }

        public List<Mitgliedschaft> Kinder { get; set; } = new List<Mitgliedschaft>();
    }
}
