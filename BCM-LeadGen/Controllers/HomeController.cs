using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BCM_LeadGen.Models;

namespace BCM_LeadGen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BCMLEADGENContext _context;

        public HomeController(ILogger<HomeController> logger, BCMLEADGENContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind] LeadGeneration leadGen)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    leadGen.TimeStamp = DateTime.Now;
                    await _context.LeadGeneration.AddAsync(leadGen);
                    if (await _context.SaveChangesAsync() > 0) {
                        TempData["msg"] = "Add Information Successfully";
                    }
                    else
                    {
                        TempData["msg"] = "Fail to Add Information";
                    }
                }

            }
            catch (Exception )
            {
                TempData["msg"] = "Fail to Add Information";
            }
         
            return RedirectToAction(nameof(Index));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
