using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PruebaConocimiento.clases;

namespace PruebaConocimiento
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            lbeconsulta.Text = "";
            lbnombre.Text = "";
            lbapellido.Text = "";
            lbtelefono.Text = "";
            lbfecha.Text = "";
            classFunciones classFunciones = new classFunciones();
            UsuarioModel usuarioModel = classFunciones.Buscarusuario(Convert.ToInt32(txtid.Text));
            if (usuarioModel == null)
            {
                lbeconsulta.Text = "No existe el usuario";
                return;
            }
            else
            {
                lbnombre.Text = "Nombre: " + usuarioModel.Nombre;
                lbapellido.Text = "Apellido: " + usuarioModel.Apellido;
                lbtelefono.Text = "Telefono: " + usuarioModel.Telefono.ToString();
                lbfecha.Text = "Fecha: " + usuarioModel.Fecha.ToString();
            }
        }
    }
}