using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logic;

namespace WebPage
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var productCatalogues = new List<ProductCatalogue>()
            {
                new ProductCatalogue() {Name = "Cars"},
                new ProductCatalogue() {Name = "Books" },
                new ProductCatalogue() {Name = "Computers"}
            };
            DropDownItemsListView.DataSource = productCatalogues.OrderBy(x => x.Name);
            DropDownItemsListView.DataBind();
        }
    }
}