using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexSTOv2.Models
{
    public class Cart
    {
        public int ID { get; set; }
      
        public decimal Price { get; set; }

    // что если по SK добавлять покупки в общую таблицу(но тогда как проложить связь с клиентом? индекс все время новый, а связь должна быть к Primary Key)
      

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

        public void AddItem(Service serv, int sessionKey)
        {

            //MyServices = null;

            //if (MyServices == null)
            //{
            //    MyServices.ToList().Add(serv); /*Походу новый клас нужен*/
            //}





            //if (MyServices == null)
            //{
            //    lineCollection.Add(new CartLine() { Game = game, Quantity = quantity });
            //}
            //else
            //{
            //    cartLine.Quantity += quantity;
            //}
        }

        public Cart(int ID_, decimal Price_)
        {
            this.ID = ID_;
          
            this.Price = Price_;
         
        }
    }
}