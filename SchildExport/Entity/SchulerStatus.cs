using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entity
{
    public enum KindStatus
    {
        [MapValue(0)]
        Neuaufnahme = 0,

        [MapValue(1)]
        Warteliste = 1,

        [MapValue(2)]
        Aktive = 2,

        [MapValue(3)]
        Beurlaubt = 3,

        [MapValue(6)]
        Externe = 6,

        [MapValue(8)]
        Abitur = 8,

        [MapValue(9)]
        Abgaenger = 9
    }
}
