using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private ShopSiteEntities db = new ShopSiteEntities();
        private int pageSize = 10;
        
        [HttpPost]
        public ActionResult ViewProductsInfo(int shopId)
        {
            ViewBag.Shop = db.Shops.Where(x => x.ShopId == shopId).First();
            return PartialView("~/Views/Home/Partial.cshtml");
        }

        public ActionResult Index(int pageNum = 0)
        {
            ViewData["pageNum"] = pageNum;
            var shops = db.Shops.OrderBy(x => x.ShopName).Skip(pageNum * pageSize).Take(pageSize);
            return View(shops);
        }
        

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}