using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Open.Archetypes;
using Open.Data.CatalogueData;
using Open.Archetypes.ProductClasses.Catalogue;

namespace Soft.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var entryBusinessLayer = new EntryBusinessLayer();
            CatalogueEntries.Instance.AddRange(entryBusinessLayer.GetEntries());
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}