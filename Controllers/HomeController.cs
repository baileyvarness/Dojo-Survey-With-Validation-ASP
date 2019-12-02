using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithValidation.Models;

namespace DojoSurveyWithValidation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
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

        [HttpPost]
        [Route("Survey")]
        public IActionResult Survey(Result resultFromForm)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Result", resultFromForm);
            }
            else 
            {
                return View("Index");
            }
            
        }

        [HttpGet]
        [Route("/result")]
        public ViewResult Result(Result resultFromForm)
        {
            return View("Result", resultFromForm);
        }
    }
}
