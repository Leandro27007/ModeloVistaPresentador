using ModelVistaPresentadorWebForms.Modelo;
using ModelVistaPresentadorWebForms.Presentador;
using ModelVistaPresentadorWebForms.Vista;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsForm.UI
{
    public partial class Form1 : Form, IEmpleadoVista
    {
        public Form1()
        {
            InitializeComponent();
        }

        PresentadorEmpleado _presentador;
        private void Form1_Load(object sender, EventArgs e)
        {
            _presentador = new PresentadorEmpleado(this);
            _presentador.CuandoLaPaginaEsCargada();
        }
        public void AgregarEmpleado(Empleado empleado)
        {
            _presentador.AgregarNuevoEmpleado(empleado);
        }

        public void EstablecerEmpleados(List<Empleado> empleados)
        {
            dataGridView1.DataSource = empleados;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEmpleado(new Empleado()
            {
                Nombre = txtNombre.Text,
                Puesto = txtPuesto.Text
            });

            ReloadForm();
     
        }

        private void ReloadForm()
        {
            this.Refresh();
            Refresh();
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

    }
}
