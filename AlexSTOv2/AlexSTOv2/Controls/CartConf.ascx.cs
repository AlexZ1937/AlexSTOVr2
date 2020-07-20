using AlexSTOv2.Models;
using AlexSTOv2.Pages.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlexSTOv2.Controls
{
    public partial class CartConf : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cart cart = SessionHelper.GetCart(Session);
            csQuantity.InnerText = "1";//ПОТОМ ИСПРАВИТЬ
            csTotal.InnerText = cart.ComputeTotalPrice().ToString("c");
            csLink.HRef = RouteTable.Routes.GetVirtualPath(null, "cart", null).VirtualPath;
        }
    }
}