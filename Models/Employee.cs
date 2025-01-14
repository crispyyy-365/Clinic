using Clinic.Models.Base;

namespace Clinic.Models
{
	public class Employee : BaseNameableEntity
	{
		public string Surname { get; set; }
		public int Age { get; set; }
		public int ExperienceYear { get; set; }
		public Department Department { get; set; }
		public EmployeePhoto EmployeePhoto { get; set; }
		public string FaceBookLink { get; set; }
		public string TwitterLink { get; set; }
		public string InstragramLink { get; set; }
	}
}
