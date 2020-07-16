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






        public void SaveService(Service serv)
        {
            if (serv.ServiceId == 0)
            {
                serv = context.Services.Add(serv);


            }
            else
            {
                Service dbserv = context.Services.Find(serv.ServiceId);
                if (dbserv != null)
                {
                    //dbserv.MyCar. = game.Name;
                    //dbserv.Price = game.Price;
                    //dbserv.Category = game.Category;
                    //dbserv.Description = game.Description;
                }
            }
            context.SaveChanges();
        }
        public void DeleteGame(Service serv)
        {
            //IEnumerable<Order> orders = context.Orders.
            //    Include(
            //        o => o.OrderLines.Select(
            //            ol => ol.Game))
            //        .Where(
            //            o => o.OrderLines.Count(
            //                ol => ol.Game.GameId == game.GameId) > 0
            //               ).ToArray();
            //foreach (Order order in orders)
            //{
            //    context.Orders.Remove(order);
            //}
            //context.Services.Remove(serv);
            //context.SaveChanges();
        }


    }
}