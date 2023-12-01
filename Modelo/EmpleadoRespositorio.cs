using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelVistaPresentadorWebForms.Modelo
{
    public static class EmpleadoRespositorio
    {
        public static List<Empleado> empleados = new List<Empleado>()
        {
            new Empleado() {Id=1020, Nombre = "Lorenzo", Puesto = "Jornalero"},
            new Empleado() {Id=1126, Nombre = "Pedro", Puesto = "Seguridad"},
            new Empleado() {Id=1256, Nombre = "Alberto", Puesto = "CEO"},
            new Empleado() {Id=1155, Nombre = "Luis", Puesto = "Gerente"},
        };
    }
}