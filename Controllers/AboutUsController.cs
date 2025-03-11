using Microsoft.AspNetCore.Mvc;
using RSTechnologiesWeb.Data;
using RSTechnologiesWeb.Models;
using System.Linq;

namespace RSTechnologiesWeb.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AboutUsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var aboutUsData = _context.AboutUs.ToList();
            return View(aboutUsData);
        }
    }
}
