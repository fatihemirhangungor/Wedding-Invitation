using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Invitation.Models;

namespace Wedding_Invitation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Cevap formu controller
        [HttpGet]
        public ViewResult ResponseForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult ResponseForm(Response response)
        {
            //ModelState returns true if all form validations are true
            if (ModelState.IsValid)
            {
                Repository.AddResponse(response);
                return View("Thanks", response);
            }
            //ModelState returns false if at least one of validation is false
            else
            {
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.responseEnum.Where(x => x.WillComeToWedding == true));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
