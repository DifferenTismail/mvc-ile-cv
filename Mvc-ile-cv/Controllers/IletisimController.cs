using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_ile_cv.Models.Entity;
using Mvc_ile_cv.Repositories;
namespace Mvc_ile_cv.Controllers
{
    public class IletisimController : Controller
    {
        GenericRepository<TBL_Iletisim> repo = new GenericRepository<TBL_Iletisim> ();
        public ActionResult Index()
        {
            var iletisim = repo.List();
            return View(iletisim);
        }
    }
}