using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexSTOv2.Models
{
    public class User
    {

       public int ID { get; set; }
       public string LoginName { get; set; }
       public virtual Role MyRole { get; set; }
       public virtual Password MyPassword { get; set; } 
       public virtual Client MyHClient { get; set; }
    }
}