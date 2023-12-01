using ModelVistaPresentadorWebForms.Modelo;
using ModelVistaPresentadorWebForms.Presentador;
using ModelVistaPresentadorWebForms.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace ModelVistaPresentadorWebForms
{
    public partial class _Default : Page, IEmpleadoVista
    {

        PresentadorEmpleado _presentador;
        protected void Page_Load(object sender, EventArgs e)
        {
            _presentador = new PresentadorEmpleado( this );
            _presentador.CuandoLaPaginaEsCargada();
        }

        public void EstablecerEmpleados(List<Empleado> empleados)
        {
            empleadosDropDownList.DataSource = empleados;
            empleadosDropDownList.DataBind();
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            _presentador.AgregarNuevoEmpleado(empleado);
        }

        public void btnAgregarEmpleado(object sender, EventArgs e)
        {
            AgregarEmpleado(new Empleado() 
            {
                Nombre = txtNombre.Text,
                Puesto = txtPuesto.Text
            });

            txtNombre.Text = null;
            txtPuesto.Text = null;

            Response.Redirect("Default");
        }

    }
}