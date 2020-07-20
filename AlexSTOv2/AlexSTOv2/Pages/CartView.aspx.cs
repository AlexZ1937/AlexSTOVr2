using AlexSTOv2.Models;
using AlexSTOv2.Models.Repository;
using AlexSTOv2.Pages.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlexSTOv2.Pages
{
    public partial class CartView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Repository repository = new Repository();
                int servId;
                if (int.TryParse(Request.Form["remove"], out servId))
                {
                    Service servToRemove = repository.Services.Where(g => g.ServiceId == servId).FirstOrDefault();
                    if (servId != null)
                    {
                        SessionHelper.GetCart(Session).RemoveLine(servToRemove);
                    }
                }
            }
        }

        public IEnumerable<AlexSTOv2.Models.Service> GetServices()
        {
            IEnumerable<Service> serv=null;
            return serv;

            //return SessionHelper.GetCart(Session).MyServices;   Так правильно, но какойто error
        }


        public decimal CartTotal { get { return SessionHelper.GetCart(Session).ComputeTotalPrice(); } }

        public string ReturnUrl { get { return SessionHelper.Get<string>(Session, SessionKey.RETURN_URL); } }
        public string CheckoutUrl { get { return RouteTable.Routes.GetVirtualPath(null, "checkout", null).VirtualPath; } }

    }
}