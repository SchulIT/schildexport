using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entity
{
    public enum DatenschutzZustimmung
    {
        [MapValue(Value = '+')]
        [MapValue(Value = 1)]
        Zugestimmt,

        [MapValue(Value = '-')]
        [MapValue(Value = 0)]
        NichtZugestimmt
    }
}
