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

namespace ProyectoNomina
{
    public partial class FormEmpleado : Form
    {
        private EmpleadoServicio servicio;

        public FormEmpleado(EmpleadoServicio servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            labelSalarioSemanal.Visible = false;
            textBoxSalarioSemanal.Visible = false;
            labelSueldoPorHora.Visible = false;
            textBoxSueldoPorHora.Visible = false;
            labelHorasTrabajadas.Visible = false;
            textBoxHorasTrabajadas.Visible = false;
            labelVentasBrutas.Visible = false;
            textBoxVentasBrutas.Visible = false;
            labelTarifaComision.Visible = false;
            textBoxTarifaComision.Visible = false;
            labelSalarioBase.Visible = false;
            textBoxSalarioBase.Visible = false;

            
        }

        // cuando selecciona Asalariado oculto todo y solo muestro salario semanal
        private void RadioButtonAsalariado_CheckedChanged(object sender, EventArgs e)
        {
            labelSalarioSemanal.Visible = false;
            textBoxSalarioSemanal.Visible = false;
            labelSueldoPorHora.Visible = false;
            textBoxSueldoPorHora.Visible = false;
            labelHorasTrabajadas.Visible = false;
            textBoxHorasTrabajadas.Visible = false;
            labelVentasBrutas.Visible = false;
            textBoxVentasBrutas.Visible = false;
            labelTarifaComision.Visible = false;
            textBoxTarifaComision.Visible = false;
            labelSalarioBase.Visible = false;
            textBoxSalarioBase.Visible = false;

            labelSalarioSemanal.Visible = true;
            textBoxSalarioSemanal.Visible = true;
        }
        // cuando selecciona Por Horas oculto todo y muestro sueldo por hora y horas trabajadas
        private void RadioButtonPorHoras_CheckedChanged(object sender, EventArgs e)
        {
            labelSalarioSemanal.Visible = false;
            textBoxSalarioSemanal.Visible = false;
            labelSueldoPorHora.Visible = false;
            textBoxSueldoPorHora.Visible = false;
            labelHorasTrabajadas.Visible = false;
            textBoxHorasTrabajadas.Visible = false;
            labelVentasBrutas.Visible = false;
            textBoxVentasBrutas.Visible = false;
            labelTarifaComision.Visible = false;
            textBoxTarifaComision.Visible = false;
            labelSalarioBase.Visible = false;
            textBoxSalarioBase.Visible = false;

            labelSueldoPorHora.Visible = true;
            textBoxSueldoPorHora.Visible = true;
            labelHorasTrabajadas.Visible = true;
            textBoxHorasTrabajadas.Visible = true;
        }
        // cuando selecciona Por Comision oculto todo y muestro ventas y tarifa
        private void RadioButtonPorComisión_CheckedChanged(object sender, EventArgs e)
        {
            labelSalarioSemanal.Visible = false;
            textBoxSalarioSemanal.Visible = false;
            labelSueldoPorHora.Visible = false;
            textBoxSueldoPorHora.Visible = false;
            labelHorasTrabajadas.Visible = false;
            textBoxHorasTrabajadas.Visible = false;
            labelVentasBrutas.Visible = false;
            textBoxVentasBrutas.Visible = false;
            labelTarifaComision.Visible = false;
            textBoxTarifaComision.Visible = false;
            labelSalarioBase.Visible = false;
            textBoxSalarioBase.Visible = false;

            labelVentasBrutas.Visible = true;
            textBoxVentasBrutas.Visible = true;
            labelTarifaComision.Visible = true;
            textBoxTarifaComision.Visible = true;
        }
        // cuando selecciona Asalariado por Comision muestro ventas, tarifa y salario base
        private void RadioButtonAsalaComision_CheckedChanged(object sender, EventArgs e)
        {
            labelSalarioSemanal.Visible = false;
            textBoxSalarioSemanal.Visible = false;
            labelSueldoPorHora.Visible = false;
            textBoxSueldoPorHora.Visible = false;
            labelHorasTrabajadas.Visible = false;
            textBoxHorasTrabajadas.Visible = false;
            labelVentasBrutas.Visible = false;
            textBoxVentasBrutas.Visible = false;
            labelTarifaComision.Visible = false;
            textBoxTarifaComision.Visible = false;
            labelSalarioBase.Visible = false;
            textBoxSalarioBase.Visible = false;

            labelVentasBrutas.Visible = true;
            textBoxVentasBrutas.Visible = true;
            labelTarifaComision.Visible = true;
            textBoxTarifaComision.Visible = true;
            labelSalarioBase.Visible = true;
            textBoxSalarioBase.Visible = true;
        }

        private void btn_Guardar_Click_1(object sender, EventArgs e)
        {
            if (RadioButtonAsalariado.Checked)
            {
                EmpleadoAsalariado emp = new EmpleadoAsalariado(
                    NombreTextBox.Text,
                    ApellidoTextBox.Text,
                    NúmeroSeguroTextBox.Text,
                    decimal.Parse(textBoxSalarioSemanal.Text)
                );
                servicio.Agregar(emp);
                this.Close();
            }

            if (RadioButtonPorHoras.Checked)
            {
                EmpleadoPorHoras emp = new EmpleadoPorHoras(
                    NombreTextBox.Text,
                    ApellidoTextBox.Text,
                    NúmeroSeguroTextBox.Text,
                    decimal.Parse(textBoxSueldoPorHora.Text),
                    decimal.Parse(textBoxHorasTrabajadas.Text)
                );
                servicio.Agregar(emp);
                this.Close();
            }

            if (RadioButtonPorComisión.Checked)
            {
                EmpleadoPorComision emp = new EmpleadoPorComision(
                    NombreTextBox.Text,
                    ApellidoTextBox.Text,
                    NúmeroSeguroTextBox.Text,
                    decimal.Parse(textBoxVentasBrutas.Text),
                    decimal.Parse(textBoxTarifaComision.Text)
                );
                servicio.Agregar(emp);
                this.Close();
            }

            if (RadioButtonAsalaComision.Checked)
            {
                EmpleadoAsalariadoPorComision emp = new EmpleadoAsalariadoPorComision(
                    NombreTextBox.Text,
                    ApellidoTextBox.Text,
                    NúmeroSeguroTextBox.Text,
                    decimal.Parse(textBoxVentasBrutas.Text),
                    decimal.Parse(textBoxTarifaComision.Text),
                    decimal.Parse(textBoxSalarioBase.Text)
                );
                servicio.Agregar(emp);
                this.Close();
            }
        }
        private void ActualizarPago()
        {
            if (RadioButtonAsalariado.Checked)
            {
                if (decimal.TryParse(textBoxSalarioSemanal.Text, out decimal salario))
                    lblResultadoPago.Text = salario.ToString("C");
            }
            else if (RadioButtonPorHoras.Checked)
            {
                if (decimal.TryParse(textBoxSueldoPorHora.Text, out decimal sueldo) &&
                    decimal.TryParse(textBoxHorasTrabajadas.Text, out decimal horas))
                {
                    EmpleadoPorHoras emp = new EmpleadoPorHoras("", "", "", sueldo, horas);
                    lblResultadoPago.Text = emp.calcularPago().ToString("C");
                }
            }
            else if (RadioButtonPorComisión.Checked)
            {
                if (decimal.TryParse(textBoxVentasBrutas.Text, out decimal ventas) &&
                    decimal.TryParse(textBoxTarifaComision.Text, out decimal tarifa))
                {
                    EmpleadoPorComision emp = new EmpleadoPorComision("", "", "", ventas, tarifa);
                    lblResultadoPago.Text = emp.calcularPago().ToString("C");
                }
            }
            else if (RadioButtonAsalaComision.Checked)
            {
                if (decimal.TryParse(textBoxVentasBrutas.Text, out decimal ventas) &&
                    decimal.TryParse(textBoxTarifaComision.Text, out decimal tarifa) &&
                    decimal.TryParse(textBoxSalarioBase.Text, out decimal base1))
                {
                    EmpleadoAsalariadoPorComision emp = new EmpleadoAsalariadoPorComision("", "", "", ventas, tarifa, base1);
                    lblResultadoPago.Text = emp.calcularPago().ToString("C");
                }
            }
        }
        private void textBoxSalarioSemanal_TextChanged(object sender, EventArgs e)
        {
            ActualizarPago();
        }

        private void textBoxSueldoPorHora_TextChanged(object sender, EventArgs e)
        {
            ActualizarPago();
        }

        private void textBoxHorasTrabajadas_TextChanged(object sender, EventArgs e)
        {
            ActualizarPago();
        }

        private void textBoxVentasBrutas_TextChanged(object sender, EventArgs e)
        {
            ActualizarPago();
        }

        private void textBoxTarifaComision_TextChanged(object sender, EventArgs e)
        {
            ActualizarPago();
        }

        private void textBoxSalarioBase_TextChanged(object sender, EventArgs e)
        {
            ActualizarPago();
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            btn_Guardar_Click_1(sender, e);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void labelSalarioSemanal_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}