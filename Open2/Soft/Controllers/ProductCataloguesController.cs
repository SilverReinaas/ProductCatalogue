﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Open.Archetypes.ProductClasses.Catalogue;
using Soft.Models;
using System.Net;

namespace Soft.Controllers
{
    public class ProductCataloguesController : Controller
    {
        private static bool isCreated;
        private static ProductCatalogue productCatalogue;
        public ActionResult Index()
        {
            if (!isCreated)
            {
                CatalogueEntries.Instance.AddRange(CatalogueEntries.GenerateRandomInstance());
                productCatalogue = ProductCatalogue.Random();
            }
            isCreated = true;
            var productCatalogueViewModel = new ProductCatalogueViewModel() {CatalogueName = productCatalogue.Name, CatalogueEntries = new List<CatalogueEntryViewModel>()};
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
            return View("Index",productCatalogueViewModel);
        }
        public ActionResult CreateEntry()
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