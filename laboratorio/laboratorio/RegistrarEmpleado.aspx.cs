﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio
{
    public partial class RegistrarEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            fachadaregistrar.registrarempleado(txtcedula.Text, txtnombre.Text, txtdir.Text, txttel.Text, DropDownList1.SelectedValue);
        }
    }
}