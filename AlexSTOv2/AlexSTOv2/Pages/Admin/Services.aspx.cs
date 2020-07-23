using AlexSTOv2.Models;
using AlexSTOv2.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlexSTOv2.Pages.Admin
{
    public partial class Services : System.Web.UI.Page
    {
        public Repository repository = new Repository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public IEnumerable<Service> GetServices()
        {
            return FilterServices().
                OrderBy(g => g.ServiceId);
        }

        //метод фильтрации по каттегории
        private IEnumerable<Service> FilterServices()
        {
            IEnumerable<Service> Services = repository.Services;
            string currentCategory = (string)RouteData.Values["category"] ??
                Request.QueryString["category"];

            //Services.Where(k => k.MyCategory.Name == currentCategory).FirstOrDefault().MyOrder=new Order(1,new Good(1,"hello",34),34);

            foreach (Service item in Services.ToList())
            {
                if (item.MyOrder == null)
                {
                    item.MyOrder = new Order(0, new Good(0, item.Description, 0), 0);
                }
            }

            return currentCategory == null ? Services : Services.Where(p => p.MyCategory.Name == currentCategory);
        }


    }
}