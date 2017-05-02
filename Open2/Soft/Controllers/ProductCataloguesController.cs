using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Open.Archetypes.ProductClasses.Catalogue;
using System.Net;
using Open.Aids;
using Open.Archetypes.BaseClasses;
using Open.Logic.CatalogueClasses;

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
                productCatalogue = ProductCatalogue.Random();
            }
            isCreated = true;
            var productCatalogueViewModel = new ProductCatalogueViewModel() {CatalogueName = productCatalogue.Name, CatalogueEntries = new List<EntryEditModel>()};
            foreach(var entry in productCatalogue.CatalogueEntries)
            {
                productCatalogueViewModel.CatalogueEntries.Add(
                    new EntryEditModel(entry)
                    );
            }

            return View("Index",productCatalogueViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEntry([Bind(Include ="UniqueId,Name,ValidFrom, ValidTo")] EntryEditModel p)
        {
            if (!ModelState.IsValid) return View("CreateEntry", p);
            var entry = new CatalogueEntry()
            {
                UniqueId = GetRandom.String(),
                Name = p.Name,
                CatalogueId = productCatalogue.UniqueId,
                Valid = new Period() { From = p.ValidFrom, To = p.ValidTo}
                
            };
            CatalogueEntries.Instance.Add(entry);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UniqueId,Name,ValidFrom, ValidTo")] EntryEditModel p)
        {
            if (!ModelState.IsValid) return View("CreateEntry", p);
            var adr = CatalogueEntries.Instance.Find(x => x.IsThisUniqueId(p.UniqueId));
            if (adr == null) return HttpNotFound();
            var entry = new CatalogueEntry()
            {
               UniqueId = adr.UniqueId,
               Name = adr.Name,
               CatalogueId = productCatalogue.UniqueId,
               Valid = adr.Valid,

            };
            CatalogueEntries.Instance.Remove(adr);
            CatalogueEntries.Instance.Add(entry);
            return RedirectToAction("Index");
        }
        public ActionResult CreateEntry()
        {
            var e = new EntryEditModel();
            return View("CreateEntry", e);
        }

        public ActionResult Edit(string id)
        {
            var adr = new EntryEditModel(CatalogueEntries.Instance.Find(x => x.IsThisUniqueId(id)));
            return View("Edit", adr);
        }
        public ActionResult Details(string id)
        {
            var entry = CatalogueEntries.Instance.Find(x => x.IsThisUniqueId(id));
            var entryModel = new EntryEditModel(entry);
            foreach (var type in entry.ProductTypes)
            {
                entryModel.ProductTypes.Add(new ProductTypeModel(type));
            }

            return View("Details", entryModel);
        }

        public ActionResult Delete(string id)
        {
            
            CatalogueEntries.Instance.Remove(
                CatalogueEntries.Instance.FirstOrDefault(x => x.UniqueId == id));
            return RedirectToAction("Index");
        }

    }
    }
