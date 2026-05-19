using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNomina.Modelos
{
    internal class EmpleadoAsalariadoPorComision : EmpleadoPorComision
    {
        public decimal SalarioBase { get; set; }

        public EmpleadoAsalariadoPorComision(string primernombre, string apellidopaterno, string numerosegurosocial, decimal ventasbrutas, decimal tarifacomision, decimal salariobase)
        : base(primernombre, apellidopaterno, numerosegurosocial, ventasbrutas, tarifacomision)
        {
            SalarioBase = SalarioBase;

        }
        public override decimal calcularPago()
        {
            return base.calcularPago();
            {
                return (VentasBrutas * TarifaComision) + SalarioBase + (SalarioBase * 0.10m);
            }
        }
            }
}
