using System.Collections.Generic;

namespace ModelVistaPresentadorWebForms.Modelo
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }

        public List<Empleado> ListaEmpleados { get { return EmpleadoRespositorio.empleados; } }

    }
}