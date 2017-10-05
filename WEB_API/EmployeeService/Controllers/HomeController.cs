using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public  ActionResult Registrar()
        {
            ViewBag.Title = "Registro com Token";

            return View();
        }

        public ActionResult GetDados()
        {
            ViewBag.Title = "Registro com Token";

            return View();
        }

    }
}
