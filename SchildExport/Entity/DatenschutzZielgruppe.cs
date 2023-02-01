using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entity
{
    public enum DatenschutzZielgruppe
    {
        [MapValue(Value = 'L')]
        Lehrkraefte,

        [MapValue(Value = 'S')]
        Kinder
    }
}
