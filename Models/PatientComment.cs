using Clinic.Models.Base;

namespace Clinic.Models
{
    public class PatientComment : BaseEntity
    {
        public int Order { get; set; }
        public string Photo { get; set; }
        public string Comment { get; set; }
        public string PatientName { get; set; }
        public string Profession { get; set; }
    }
}
