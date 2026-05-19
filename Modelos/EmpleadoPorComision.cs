using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNomina.Modelos
{
    // Empleado que gana un porcentaje de lo que vendio en la semana
    internal class EmpleadoPorComision : Empleado
    {
        public decimal VentasBrutas {  get; set; }
        public decimal TarifaComision { get; set; }

        public EmpleadoPorComision(string primernombre, string apellidopaterno, string numerosegurosocial, decimal ventasbrutas,decimal tarifacomision)
            : base (primernombre, apellidopaterno, numerosegurosocial)
        {
            VentasBrutas = ventasbrutas;
            TarifaComision = tarifacomision;
        }

        // Su pago es  multiplicar lo que vendio por su porcentaje
        public override decimal calcularPago()
        {
            return VentasBrutas * TarifaComision;
        }
    }
}
