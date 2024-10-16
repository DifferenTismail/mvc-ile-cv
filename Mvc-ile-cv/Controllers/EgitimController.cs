using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_ile_cv.Models.Entity;
using Mvc_ile_cv.Repositories;
namespace Mvc_ile_cv.Controllers
{
    public class EgitimController : Controller
    {
        GenericRepository<TBL_Egitimlerim> repo = new GenericRepository<TBL_Egitimlerim> ();
        public ActionResult Index()
        {
            var egitim = repo.List();
            return View(egitim);
        }
    }
}