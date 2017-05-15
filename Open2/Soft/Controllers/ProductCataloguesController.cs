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
using Open.Data.CatalogueData;
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
                UniqueId = Guid.NewGuid().ToString(),
                Name = p.Name,
                CatalogueId = productCatalogue.UniqueId,
                Valid = new Period() { From = p.ValidFrom, To = p.ValidTo}
                
            };
            var ebl = new EntryBusinessLayer();
            ebl.SaveEntry(entry);
            CatalogueEntries.Instance.Add(entry);
            //ebl.UploadEntries(CatalogueEntries.Instance.ToList());
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveEntry([Bind(Include = "UniqueId,Name,ValidFrom, ValidTo")] EntryEditModel p)
        {
            if (!ModelState.IsValid) return View("CreateEntry", p);
            var adr = CatalogueEntries.Instance.Find(x => x.IsThisUniqueId(p.UniqueId));
            if (adr == null) return HttpNotFound();
            adr.Name = p.Name;
            adr.Valid.From = p.ValidFrom;
            adr.Valid.To = p.ValidTo;
            var ebl = new EntryBusinessLayer();
            ebl.UploadEntries(CatalogueEntries.Instance.ToList());
            return RedirectToAction("Index");
        }
        public ActionResult CreateEntry()
        {
            var e = new EntryEditModel() {ValidFrom = DateTime.Now, ValidTo = DateTime.Now.AddYears(1)};
            return View("CreateEntry", e);
        }

        public ActionResult EntryEdit(string id)
        {
            var adr = new EntryEditModel(CatalogueEntries.Instance.Find(x => x.IsThisUniqueId(id)));
            return View("EntryEdit", adr);
        }

        public ActionResult EntryDetails(string id)
        {
            var entry = CatalogueEntries.Instance.Find(x => x.IsThisUniqueId(id));
            var entryModel = new EntryEditModel(entry);
            return View("EntryDetails", entryModel);
        }
        public ActionResult TypeDetails(string id)
        {
            var type = ProductTypes.Instance.Find(x => x.IsThisUniqueId(id));
            var typeModel = new ProductTypeModel(type);
            return View("TypeDetails", typeModel);
        }

        public ActionResult EntryDelete(string id)
        {
            var ebl = new EntryBusinessLayer();
            ebl.RemoveEntry(id);
            return RedirectToAction("Index");
        }

        public ActionResult TypeDelete(string id)
        {
            var ebl = new EntryBusinessLayer();
            var removeType = ProductTypes.Instance.Find(x => x.IsThisUniqueId(id));
            ebl.RemoveType(id);
            var entry =
                CatalogueEntries.Instance.Find(x => x.IsThisUniqueId(removeType.CatalogueEntryId));
            ebl.UploadTypes(ProductTypes.Instance.ToList());
            var entryModel = new EntryEditModel(entry);
            return View("EntryDetails", entryModel);
        }

        public ActionResult CreateType(string id)
        {
            var e = new ProductTypeModel()
            {
                CatalogueEntryId = id,
                ValidFrom = DateTime.Now,
                ValidTo = DateTime.Now.AddYears(1)
            };
            return View("CreateType", e);
        }

        public ActionResult TypeEdit(string id)
        {
            var adr = new ProductTypeModel(ProductTypes.Instance.Find(x => x.IsThisUniqueId(id)));
            return View("TypeEditView", adr);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveType([Bind(Include = "UniqueId, Name, Description, ValidFrom, ValidTo")] ProductTypeModel p)
        {
            if (!ModelState.IsValid) return View("CreateType", p);
            var type = ProductTypes.Instance.Find(x => x.IsThisUniqueId(p.UniqueId));
            if (type == null) return HttpNotFound();
            type.Name = p.Name;
            type.Description = p.Description;
            type.Valid.From = p.ValidFrom;
            type.Valid.To = p.ValidTo;
            var ebl = new EntryBusinessLayer();
            ebl.UploadTypes(ProductTypes.Instance.ToList());
            return EntryDetails(type.CatalogueEntryId);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateType(
            [Bind(Include = "UniqueId,Name,Description,ValidFrom,ValidTo,CatalogueEntryId")] ProductTypeModel p)
        {
            if (!ModelState.IsValid) return View("CreateType", p);
            var type = new ProductType()
            {
                UniqueId = Guid.NewGuid().ToString(),
                Name = p.Name,
                Description = p.Description,
                CatalogueEntryId = p.CatalogueEntryId,
                Valid = new Period() {From = p.ValidFrom, To = p.ValidTo}

            };
            var ebl = new EntryBusinessLayer();
            ProductTypes.Instance.Add(type);
            ebl.UploadTypes(ProductTypes.Instance.ToList());
            return EntryDetails(type.CatalogueEntryId);
        }

    }
    }
