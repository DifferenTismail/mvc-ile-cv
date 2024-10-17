using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_ile_cv.Models.Entity;
using Mvc_ile_cv.Repositories;
namespace Mvc_ile_cv.Controllers
{
    public class HobiController : Controller
    {
        GenericRepository<TBL_Hobilerim> repo = new GenericRepository<TBL_Hobilerim> ();
        public ActionResult Index()
        {
            var hobilerim = repo.List();
            return View(hobilerim);
        }
        [HttpPost]
        public ActionResult Index(TBL_Hobilerim p)
        {
            var t = repo.Find(x => x.ID == 1);
            t.Aciklama_1 = p.Aciklama_1;
            t.Aciklama_2 = p.Aciklama_2;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}