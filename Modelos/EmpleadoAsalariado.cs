using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNomina.Modelos
{
    internal class EmpleadoAsalariado : Empleado
    {
        public decimal SalarioSemanal {  get; set; }

        public EmpleadoAsalariado (string primernombre, string apellidopaterno, string numerosegurosocial, decimal salariosemanal)
            :base(primernombre, apellidopaterno, numerosegurosocial)
        {
            SalarioSemanal = salariosemanal;
   
        }
        // Para asalariado solo devuelve su salario fijo
        public override decimal calcularPago()
        {
            return SalarioSemanal;
        }
    }
}
