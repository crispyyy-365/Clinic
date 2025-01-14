using Clinic.Models;

namespace Clinic.ViewModels
{
    public class HomeVm
    {
        public List<PatientComment> PatientComments { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Department> Departments { get; set; }
    }
}
