using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNomina.Modelos
{
    internal class EmpleadoPorHoras : Empleado
    {
        public decimal SueldoPorHora { get; set; }
        public decimal HorasTrabajadas { get; set; }

        public EmpleadoPorHoras(string primernombre, string apellidopaterno, string numerosegurosocial, decimal sueldoporhora, decimal horastrabajadas)
    :base(primernombre, apellidopaterno, numerosegurosocial)
        {
            SueldoPorHora = sueldoporhora;
            HorasTrabajadas = horastrabajadas;
        }
        public override decimal calcularPago()
        {
            if (HorasTrabajadas <= 40)
            {
                return SueldoPorHora * HorasTrabajadas;
            }
            else
            {
                return (SueldoPorHora * 40) + (SueldoPorHora * 1.5m * (HorasTrabajadas - 40));
            }
        }
     }
}
