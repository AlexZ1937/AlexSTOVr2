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

        public void AddItem(Service game, int quantity)
        {
        //    CartLine cartLine = lineCollection.Where(p => p.Game.GameId == game.GameId).FirstOrDefault();
        //    if (cartLine == null)
        //    {
        //        lineCollection.Add(new CartLine() { Game = game, Quantity = quantity });
        //    }
        //    else
        //    {
        //        cartLine.Quantity += quantity;
        //    }
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