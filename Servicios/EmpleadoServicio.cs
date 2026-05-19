using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoNomina.Modelos;
namespace ProyectoNomina.Servicios
{
    public class EmpleadoServicio
    {
        private List<Empleado> empleados = new List<Empleado>();

        public void  Agregar (Empleado empleado)
        {
            empleados.Add(empleado);
        }
        public List<Empleado> ObtenerTodos()
        {
            return empleados;
        }
        public void eliminar (Empleado empleado)
        {
            empleados.Remove(empleado);
        }
        public void actualizar(Empleado empleadoantiguo, Empleado empleadonuevo)
        {
            int indice = empleados.IndexOf(empleadoantiguo);
            if(indice >=0)
            {
                empleados[indice] = empleadonuevo;
            }
        }
    }
}
