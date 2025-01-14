using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Areas.Admin.Controllers
{
	[Area("Admin")]
	[ValidateAntiForgeryToken]
	[Authorize(Roles = "Admin, Moderator")]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
