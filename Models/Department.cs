using Clinic.Models.Base;

namespace Clinic.Models
{
	public class Department : BaseNameableEntity
	{
		public List<Employee> Employees { get; set; }
	}
}
