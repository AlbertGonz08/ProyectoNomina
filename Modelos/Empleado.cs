using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNomina.Modelos
{
    public abstract class Empleado
    {
        // Datos que todos los empleados tienen 
        public string PrimerNombre { get; set; }
        public string ApellidoPaterno { get; set; }

        public string NumeroSeguroSocial    { get; set; }

        public Empleado (string primernombre, string apellidopaterno, string numerosegurosocial)
        {
            PrimerNombre = primernombre;
            ApellidoPaterno = apellidopaterno;
            NumeroSeguroSocial = numerosegurosocial;
        }
        //todas las clases van a usar este metodo cada tipo de empleado calcula de manera diferente
        public abstract decimal calcularPago();

    }
}
