using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Parser.SyntaxTree;
using Mvc_ile_cv.Models.Entity;
using static System.Collections.Specialized.BitVector32;
namespace Mvc_ile_cv.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.TBL_Hakkimda.ToList();
            return View(degerler);
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyalMedya = db.Tbl_SosyalMedya.Where(x =>x.Durum == true).ToList();
            return PartialView(sosyalMedya);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimlerim = db.TBL_Deneyimlerim.ToList();
            return PartialView(deneyimlerim);
        }
        public PartialViewResult Egitim()
        {
            var egitimlerim = db.TBL_Egitimlerim.ToList();
            return PartialView(egitimlerim);
        }
        public PartialViewResult Yeteneklerim()
        {
            var yeteneklerim = db.TBL_Yeteneklerim.ToList();
            return PartialView(yeteneklerim);
        }
        public PartialViewResult Hobilerim()
        {
            var hobilerim = db.TBL_Hobilerim.ToList();
            return PartialView(hobilerim);
        }
        public PartialViewResult Sertifikalarim()
        {
            var sertifikalarim = db.TBL_Sertifikalarim.ToList();
            return PartialView(sertifikalarim);
        }
        [HttpGet]
        public PartialViewResult Iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Iletisim(TBL_Iletisim iletisim)
        {
            iletisim.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TBL_Iletisim.Add(iletisim);
            db.SaveChanges();
            return PartialView();
        }
    }
}