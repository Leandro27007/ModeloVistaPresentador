using ModelVistaPresentadorWebForms.Modelo;
using ModelVistaPresentadorWebForms.Vista;

namespace ModelVistaPresentadorWebForms.Presentador
{
    public class PresentadorEmpleado
    {
        private IEmpleadoVista _empleadoVista;
        private Empleado _emmpleadoModel;
        public PresentadorEmpleado(IEmpleadoVista empleadoVista)
        {
            this._empleadoVista = empleadoVista;
            _emmpleadoModel = new Empleado();
        }
        public void CuandoLaPaginaEsCargada()
        {
            var empleados = _emmpleadoModel.ListaEmpleados;
            _empleadoVista.EstablecerEmpleados(empleados);
        }

        public void AgregarNuevoEmpleado(Empleado empleado)
        {
            EmpleadoRespositorio.empleados.Add(empleado);
        }
    }
}