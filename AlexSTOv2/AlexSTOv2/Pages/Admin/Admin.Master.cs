using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlexSTOv2.Pages.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string GenerateUrl(string routeName) => RouteTable.Routes.GetVirtualPath(null, routeName, null).VirtualPath;

        public string GoodtsUrl
        {
            get { return GenerateUrl("admin_goodts"); }
        }
        public string ServicesUrl
        {
            get { return GenerateUrl("admin_services"); }
        }
    }
}