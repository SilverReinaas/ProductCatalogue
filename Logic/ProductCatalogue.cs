using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ProductCatalogue : INamed, ITimeLimited
    {
        private List<CatalogueEntry> catalogueEntries;
        private List<CatalogueCategory> catalogueCategories;
        public string Id { get; set; }
        public string Name { get; set; }
        public Period Valid { get; set; }
        public List<CatalogueEntry> CatalogueEntries
        {
            get { return catalogueEntries ?? new List<CatalogueEntry>(); }
            set { catalogueEntries = value; }
        }

        public List<CatalogueCategory> CatalogueCategories
        {
            get { return catalogueCategories ?? new List<CatalogueCategory>(); }
            set { catalogueCategories = value; }
        }

        public static List<ProductCatalogue> GetCatalogues()
        {
            var productCatalogues = new List<ProductCatalogue>()
            {
                new ProductCatalogue() {Name = "Books", Id = "123klasd",
                    CatalogueEntries = new List<CatalogueEntry>()
                {
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},
                    new CatalogueEntry() {Name = "HTML For Dummies", Price = 9.99, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51IuNDzDhwL._SX258_BO1,204,203,200_.jpg"},

                } },
                new ProductCatalogue() {Name = "Vehicles", Id = "12n1fn"},
                new ProductCatalogue() {Name = "Clothing", Id = "lkjads12"}
            };
            return productCatalogues;
        }
    }
}
