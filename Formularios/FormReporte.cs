using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoNomina.Modelos;
using ProyectoNomina.Servicios;

namespace ProyectoNomina.Formularios
{
    public partial class FormReporte : Form
    {

        private EmpleadoServicio servicio;

        public FormReporte(EmpleadoServicio servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            // variables para totales por tipo
            decimal totalAsalariados = 0;
            decimal totalPorHoras = 0;
            decimal totalPorComision = 0;
            decimal totalNomina = 0;

            // para limpiar la tabla
            dataGridView1.Rows.Clear();

            foreach (Empleado emp in servicio.ObtenerTodos())
            {
                string tipo = "";
                string detalle = "";
                decimal pago = emp.calcularPago();

                if (emp is EmpleadoAsalariadoPorComision)
                {
                    EmpleadoAsalariadoPorComision e4 = (EmpleadoAsalariadoPorComision)emp;
                    tipo = "Asal. Comision";
                    detalle = "Base + comision + 10%";
                    totalPorComision += pago;
                }
                else if (emp is EmpleadoAsalariado)
                {
                    tipo = "Asalariado";
                    detalle = "Salario fijo semanal";
                    totalAsalariados += pago;
                }
                else if (emp is EmpleadoPorHoras)
                {
                    EmpleadoPorHoras e2 = (EmpleadoPorHoras)emp;
                    tipo = "Por Horas";
                    detalle = e2.HorasTrabajadas + "h x $" + e2.SueldoPorHora;
                    totalPorHoras += pago;
                }
                else if (emp is EmpleadoPorComision)
                {
                    EmpleadoPorComision e3 = (EmpleadoPorComision)emp;
                    tipo = "Por Comision";
                    detalle = "$" + e3.VentasBrutas + " x " + e3.TarifaComision;
                    totalPorComision += pago;
                }

                // agrego la fila al datagrid
                dataGridView1.Rows.Add(
                    emp.PrimerNombre + " " + emp.ApellidoPaterno,
                    tipo,
                    detalle,
                    pago.ToString("C")
                );

                // acumulo el total general
                totalNomina += pago;
            }

            // muestro los totales en los paneles
            lblTotalAsalariados.Text = totalAsalariados.ToString("C");
            lblTotalPorHoras.Text = totalPorHoras.ToString("C");
            lblTotalPorComision.Text = totalPorComision.ToString("C");
            lblTotalNomina.Text = totalNomina.ToString("C");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}