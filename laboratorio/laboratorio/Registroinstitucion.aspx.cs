using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio
{
    public partial class Registroinstitucion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // persistenciainstitucion per = new persistenciainstitucionoledb();
            //per.registrarinstitucion(txtnombre.Text, txtmail.Text, txttelefono.Text);

            fachadaregistrar.registrarinstitucion(txtnombre.Text, txtmail.Text, txttelefono.Text, txtdireccion.Text);
        }
    }
}