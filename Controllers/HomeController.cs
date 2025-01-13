﻿using Clinic.DAL;
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
                .ToListAsync(),
            };
            _context.SaveChanges();
            return View(homeVm);
        }
    }
}