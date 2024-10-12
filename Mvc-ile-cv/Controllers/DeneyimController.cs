using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_ile_cv.Models.Entity;
using Mvc_ile_cv.Repositories;
namespace Mvc_ile_cv.Controllers
{
    public class DeneyimController : Controller
    {
        DeneyimRespository repo = new DeneyimRespository();
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }
    }
}