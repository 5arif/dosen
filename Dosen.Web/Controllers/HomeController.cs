using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dosen.Web.Models;

namespace Dosen.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Profile")]
        public IActionResult Profile()
        {
            return View();
        }

        [Route("Educations")]
        public IActionResult Educations()
        {
            return View();
        }

        [Route("Work")]
        public IActionResult Work()
        {
            return View();
        }

        [Route("Account")]
        public IActionResult Account()
        {
            return View();
        }

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }


        [Route("Research")]
        public IActionResult Research()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
