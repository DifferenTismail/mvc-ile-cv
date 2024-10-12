using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_ile_cv.Models.Entity;
namespace Mvc_ile_cv.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        public ActionResult Index()
        {
            return View();
        }
    }
}