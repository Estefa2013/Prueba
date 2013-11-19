using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio
{
    public partial class materiales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // persistenciamateriales per = new persistenciamaterialesoledb();
          //  per.registrarmateriales(TextBox1.Text, Convert.ToInt32 (TextBox2.Text));

            fachadaregistrar.registrarmateriales(TextBox1.Text,Convert.ToInt32( TextBox2.Text));
        }
    }
}