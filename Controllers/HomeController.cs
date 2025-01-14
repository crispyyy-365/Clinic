using Clinic.DAL;
using Clinic.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVm homeVm = new HomeVm
            {
                PatientComments = await _context.PatientComments
                .OrderBy(pc => pc.Order)
                .Where(pc => pc.IsDeleted != false)
                .ToListAsync(),

                Employees = await _context.Employees
                .OrderBy(e => e.ExperienceYear)
                .Where(e => e.IsDeleted != false)
                .Take(4)
                //.Include(e => e.EmployeePhoto)
                .Include(e => e.Department)
                .ToListAsync()
            };
            //_context.SaveChanges();
            return View(homeVm);
        }
    }
}
