using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entities
{
    enum Geschlecht
    {
        [MapValue('3')]
        [MapValue(3)]
        Maennlich,

        [MapValue('4')]
        [MapValue(4)]
        Weiblich,

        [MapValue(' ')]
        [MapValue('\u0004')]
        [MapValue('\u0003')]
        [MapValue(0)]
        Unbekannt
    }
}
