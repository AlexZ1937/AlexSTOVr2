using AlexSTOv2.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlexSTOv2.Controls
{
    public partial class SomeList : System.Web.UI.UserControl
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ////////////////////////
        /// </summary>
        /// <returns></returns>

        /// <returns></returns>
        public IEnumerable<string> GetCategories()
        {
            return new Repository().Categories.Select(p => p.Name).Distinct().OrderBy(x => x);
        }
        protected string CreateHomeLinkHtml()
        {
            string path = RouteTable.Routes.GetVirtualPath(null , null).VirtualPath;
            return string.Format("<a href='{0}'>Главная страница</a>", path);
        }

        protected string CreateLinkHtml(string category)
        {
            string selectedCategory = (string)Page.RouteData.Values["category"] ?? Request.QueryString["category"];
            string path = RouteTable.Routes.GetVirtualPath(null, null, new RouteValueDictionary() { { "category", category }, { "page", "1" } }).VirtualPath;
            return string.Format("<a href='{0}' {1}> {2} </a>", path, category == selectedCategory ? "class='selected'" : "", category);
        }
    }
}