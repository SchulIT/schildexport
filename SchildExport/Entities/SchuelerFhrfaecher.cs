using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerFhrfaecher
    {
        public int Id { get; set; }
        public int SchuelerId { get; set; }
        public int FachId { get; set; }
        public string KursartAllg { get; set; }
        public string FachKrz { get; set; }
        public string Psii21 { get; set; }
        public int? Hsii21 { get; set; }
        public string Rsii21 { get; set; }
        public string Psii22 { get; set; }
        public int? Hsii22 { get; set; }
        public string Rsii22 { get; set; }
        public string Psii21W { get; set; }
        public int? Hsii21W { get; set; }
        public string Rsii21W { get; set; }
        public string Psii22W { get; set; }
        public int? Hsii22W { get; set; }
        public string Rsii22W { get; set; }
        public string Psii31 { get; set; }
        public int? Hsii31 { get; set; }
        public string Rsii31 { get; set; }
        public string Psii32 { get; set; }
        public int? Hsii32 { get; set; }
        public string Rsii32 { get; set; }
        public string Psii31W { get; set; }
        public int? Hsii31W { get; set; }
        public string Rsii31W { get; set; }
        public string Psii32W { get; set; }
        public int? Hsii32W { get; set; }
        public string Rsii32W { get; set; }
        public string Ksii21 { get; set; }
        public string Ksii22 { get; set; }
        public string Ksii21W { get; set; }
        public string Ksii22W { get; set; }
        public string Ksii31 { get; set; }
        public string Ksii32 { get; set; }
        public string Ksii31W { get; set; }
        public string Ksii32W { get; set; }
        public int? Fsortierung { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual EigeneSchuleFaecher Fach { get; set; }
        public virtual Schueler Schueler { get; set; }
    }
}
