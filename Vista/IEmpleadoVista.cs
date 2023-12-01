using ModelVistaPresentadorWebForms.Modelo;
using System.Collections.Generic;

namespace ModelVistaPresentadorWebForms.Vista
{
    public interface IEmpleadoVista
    {
        void EstablecerEmpleados(List<Empleado> empleados);
        void AgregarEmpleado(Empleado empleado);
    }
}
