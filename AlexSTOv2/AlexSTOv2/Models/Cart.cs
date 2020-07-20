using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexSTOv2.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public int SKindex { get; set; }
        public decimal Price { get; set; }
        public IEnumerable<Service> MyServices { get; set; }
      

        public Cart()
        {
           
        }

        public decimal ComputeTotalPrice()
        {
            return 0;
            //return lineCollection.Sum(e => e.Game.Price * e.Quantity);
        }

        public void RemoveLine(Service service)
        {
            //lineCollection.RemoveAll(l => l.Game.GameId == game.GameId);
        }

        public void AddItem(Service serv, int quantity)
        {
            
            //MyServices.ToList().Add(serv);   Походу новый клас нужен




            //if (MyServices == null)
            //{
            //    lineCollection.Add(new CartLine() { Game = game, Quantity = quantity });
            //}
            //else
            //{
            //    cartLine.Quantity += quantity;
            //}
        }

        public Cart(int ID_, int SKindex_, decimal Price_, IEnumerable<Service> Service_ServiceId_)
        {
            this.ID = ID_;
            this.SKindex = SKindex_;
            this.Price = Price_;
            this.MyServices = Service_ServiceId_;
        }
    }
}