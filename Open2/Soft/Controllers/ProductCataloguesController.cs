using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Soft.Models;

namespace Soft.Controllers
{
    public class ProductCataloguesController : Controller
    {
        public ActionResult Index()
        {
            var productCatalogue =
                Open.Archetypes.ProductClasses.Catalogue.ProductCatalogue.Random();
            var productCatalogueViewModel = new ProductCatalogueViewModel()
            { CatalogueName = productCatalogue.Name, CatalogueEntries = new List<CatalogueEntryViewModel>()};
            foreach(var entry in productCatalogue.CatalogueEntries)
            {
                productCatalogueViewModel.CatalogueEntries.Add(
                    new CatalogueEntryViewModel()
                    {
                        Name = entry.Name,
                        UniqueId = entry.UniqueId,
                        ValidFrom = entry.Valid.From.ToString(),
                        ValidTo = entry.Valid.To.ToString()
                    }
                    );
            }
            return View("ProductCatalogues",productCatalogueViewModel);
        }
        public ActionResult Create()
        {
            return null;
        }

        public ActionResult Edit()
        {
            return null;
        }

        public ActionResult Details()
        {
            return null;
        }

        public ActionResult Delete()
        {
            return null;
        }
    }
}