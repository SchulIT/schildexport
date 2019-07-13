using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerFhr
    {
        public int Id { get; set; }
        public int SchuelerId { get; set; }
        public string Fhrerreicht { get; set; }
        public string Note { get; set; }
        public short? GesamtPunktzahl { get; set; }
        public short? SummeGk { get; set; }
        public short? SummeLk { get; set; }
        public short? SummenOk { get; set; }
        public short? AnzRelLk { get; set; }
        public short? AnzRelGk { get; set; }
        public short? AnzRelOk { get; set; }
        public short? AnzDefLk { get; set; }
        public short? AnzDefGk { get; set; }
        public short? AnzDefOk { get; set; }
        public short? Jsii21 { get; set; }
        public short? Jsii21W { get; set; }
        public short? Jsii22 { get; set; }
        public short? Jsii22W { get; set; }
        public short? Jsii31 { get; set; }
        public short? Jsii31W { get; set; }
        public short? Jsii32 { get; set; }
        public short? Jsii32W { get; set; }
        public short? Asii21 { get; set; }
        public short? Asii22 { get; set; }
        public short? Asii21W { get; set; }
        public short? Asii22W { get; set; }
        public short? Asii31 { get; set; }
        public short? Asii32 { get; set; }
        public short? Asii31W { get; set; }
        public short? Asii32W { get; set; }
        public string Wsii21 { get; set; }
        public string Wsii22 { get; set; }
        public string Wsii21W { get; set; }
        public string Wsii22W { get; set; }
        public string Wsii31 { get; set; }
        public string Wsii32 { get; set; }
        public string Wsii31W { get; set; }
        public string Wsii32W { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual Schueler Schueler { get; set; }
    }
}
