using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexSTOv2.Models.Repository
{
    public class Repository
    {
        private EFDBContext context = new EFDBContext();
        public IEnumerable<Client> Clients { get { return context.Clients; } }

        public IEnumerable<Good> Goods { get { return context.Goods; } }

        public IEnumerable<Master> Masters { get { return context.Masters; } }

        public IEnumerable<Service> Services { get { return context.Services; } }

        public IEnumerable<Car> Cars { get { return context.Cars; } }

        public IEnumerable<Category> Categories { get { return context.Categories; } }

        public IEnumerable<Cart> Carts { get { return context.Carts; } }

        public IEnumerable<Order> Orders { get { return context.Orders; } }



    }
}