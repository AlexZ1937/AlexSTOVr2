﻿using AlexSTOv2.Models;
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
    public partial class Listing : System.Web.UI.Page
    {
       
            private Repository repository = new Repository();
            private int pageSize = 4;

            protected int MaxPage
            {
                get
                {
                    int prodCount = FilterServices().Count();
                    return (int)Math.Ceiling((decimal)prodCount / pageSize);
                }
            }

            private int GetPageFromRequest()
            {
                int page;
                string reqValue = (string)RouteData.Values["page"] ?? Request.QueryString["page"];
                return reqValue != null && int.TryParse(reqValue, out page) ? page : 1;
            }

            protected int CurrentPage
            {
                get
                {
                    int page;
                    page = GetPageFromRequest();
                    return page > MaxPage ? MaxPage : page;
                }
            }


            public IEnumerable<Service> GetServices()
            {
                return FilterServices().
                    OrderBy(g => g.ServiceId).
                    Skip((CurrentPage - 1) * pageSize).
                    Take(pageSize);
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







        protected void Page_Load(object sender, EventArgs e)
            {
                if (IsPostBack)
                {
                    int selectedServiceId;
                    if (int.TryParse(Request.Form["add"], out selectedServiceId))
                    {
                        Service selectedGame = repository.Services.Where(g => g.ServiceId == selectedServiceId).FirstOrDefault();
                        if (selectedGame != null)
                        {
                        //SessionHelper.GetCart(Session).AddItem(selectedGame, 1);
                        //SessionHelper.Set(Session, SessionKey.RETURN_URL, Request.RawUrl);
                            repository.AddServiceToCart(selectedGame, repository.Clients.Where(p => p.ClientID == 3).FirstOrDefault().MyCart);
                     
                            
                            Response.Redirect(RouteTable.Routes.GetVirtualPath(null, "cart", null).VirtualPath);
                        }
                    }
                }
            }
        
    }
}