using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entities
{
    enum Geschlecht
    {
        [MapValue(Value=3)]
        Maennlich,

        [MapValue(Value = 4)]
        Weiblich,

        [MapValue(Value = ' ')]
        [MapValue(Value = '\u0004')]
        [MapValue(Value = '\u0003')]
        [MapValue(Value = 0)]
        Unbekannt
    }
}
