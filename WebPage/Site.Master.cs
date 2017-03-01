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
        private List<ProductCatalogue> productCatalogues;
        protected void Page_Load(object sender, EventArgs e)
        {
            productCatalogues = ProductCatalogue.GetCatalogues().OrderBy(x => x.Name).ToList();
            DropDownItemsListView.DataSource = productCatalogues;
            DropDownItemsListView.DataBind();
        }

        protected void DropDownItemsListView_OnItemCommand(object sender, ListViewCommandEventArgs e)
        {
            var selectedCatalogue = productCatalogues[e.Item.DataItemIndex];
            Response.Redirect($"ProductCataloguePage.aspx?Id={selectedCatalogue.Id}");
        }
    }
}