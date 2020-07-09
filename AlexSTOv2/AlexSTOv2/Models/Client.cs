using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexSTOv2.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string FIO { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public bool Status { get; set; }
        public Cart MyCart { get; set; }

        public Client()
        {
           
        }

        public Client(int ClientID_, string FIO_, string Phone_, string Adress_, bool Status_, Cart CartID_)
        {
            this.ClientID = ClientID_;
            this.FIO = FIO_;
            this.Phone = Phone_;
            this.Adress = Adress_;
            this.Status = Status_;
            this.MyCart = CartID_;
        }
    }
}