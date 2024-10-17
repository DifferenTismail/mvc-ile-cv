using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_ile_cv.Models.Entity;
using Mvc_ile_cv.Repositories;
namespace Mvc_ile_cv.Controllers
{
    public class HakkimdaController : Controller
    {
        GenericRepository<TBL_Hakkimda> repo = new GenericRepository<TBL_Hakkimda>();
        [HttpGet]
        public ActionResult Index()
        {
            var hakkimda = repo.List();
            return View(hakkimda);
        }
        [HttpPost]
        public ActionResult Index(TBL_Hakkimda t)
        {
            var p = repo.Find(x => x.ID == 1);
            p.Ad = t.Ad;
            p.Soyad = t.Soyad;
            p.Adres = t.Adres;
            p.Telefon = t.Telefon;
            p.Mail = t.Mail;
            p.Aciklama = t.Aciklama;
            p.Resim = t.Resim;
            repo.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}