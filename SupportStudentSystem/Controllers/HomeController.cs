using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SupportStudentSystem.Models;

namespace SupportStudentSystem.Controllers
{
    public class HomeController : Controller
    {
        QUANLYSINHVIENEntities qlsv = new QUANLYSINHVIENEntities();
        // GET: Home

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FormApp()
        {
            return View();
        }
    }
}