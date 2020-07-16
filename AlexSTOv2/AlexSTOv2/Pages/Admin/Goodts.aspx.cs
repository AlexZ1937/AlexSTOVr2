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
    public partial class Goodts : System.Web.UI.Page
    {
        public Repository repository = new Repository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Good> GetGames() => repository.Goods;
    }
}