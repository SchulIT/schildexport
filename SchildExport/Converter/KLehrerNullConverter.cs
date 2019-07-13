using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;

namespace SchulIT.SchildExport.Converter
{
    public class KLehrerNullConverter : IConverter<KLehrer, Teacher>
    {
        public virtual Teacher Convert(KLehrer source)
        {
            return null;
        }
    }
}
