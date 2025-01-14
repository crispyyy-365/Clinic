using Clinic.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Clinic.Areas.Admin.Controllers
{
	public class DepartmentController : Controller
	{
		private readonly AppDbContext _context;
		public DepartmentController(AppDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
