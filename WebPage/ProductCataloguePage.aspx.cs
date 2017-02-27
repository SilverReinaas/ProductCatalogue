using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logic;

namespace WebPage
{
    public partial class ProductCataloguePage : System.Web.UI.Page
    {
        private ProductCatalogue productCatalogue;
        protected void Page_Load(object sender, EventArgs e)
        {
            productCatalogue = (ProductCatalogue)Session["ProductCatalogue"];
            if(productCatalogue == null) return;

            ProductCatalogueNameLabel.Text = productCatalogue.Name;
        }
    }
}