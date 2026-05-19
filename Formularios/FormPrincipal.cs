using ProyectoNomina.Formularios;
using ProyectoNomina.Modelos;
using ProyectoNomina.Servicios;

namespace ProyectoNomina
{
    public partial class FormPrincipal : Form
    {

        private EmpleadoServicio servicio = new EmpleadoServicio();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("colNombre", "Nombre");
            dataGridView1.Columns.Add("colApellido", "Apellido");
            dataGridView1.Columns.Add("colNSS", "NSS");
            dataGridView1.Columns.Add("colTipo", "Tipo");
            dataGridView1.Columns.Add("colPago", "Pago Semanal");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
        }

        // Metodo para refrescar la tabla
        private void CargarEmpleados()
        {
            dataGridView1.Rows.Clear();

            foreach (Empleado emp in servicio.ObtenerTodos())
            {
                // buscar el tipo de empleado para mostrarlo en la tabla
                string tipo = emp switch
                {
                    EmpleadoAsalariadoPorComision => "Asal. Comision",
                    EmpleadoAsalariado => "Asalariado",
                    EmpleadoPorHoras => "Por Horas",
                    EmpleadoPorComision => "Por Comision",
                    _ => "Desconocido"
                };

                dataGridView1.Rows.Add(
                    emp.PrimerNombre,
                    emp.ApellidoPaterno,
                    emp.NumeroSeguroSocial,
                    tipo,
                    emp.calcularPago().ToString("C")
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormEmpleado formulario = new FormEmpleado(servicio);
            formulario.ShowDialog();


            CargarEmpleados();
        }
        //ELIMINAR EMPLEADO VENTANA PRINCIPAL
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un empleado para eliminar.");
                return;
            }

            // Preguntar
            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro que deseas eliminar este empleado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo
            );
            // Si la respuesta es si
            if (respuesta == DialogResult.Yes)
            {
                // busco el índice de la fila 
                int indice = dataGridView1.SelectedRows[0].Index;

                // elimino el empleado de la lista usando ese índice
                Empleado emp = servicio.ObtenerTodos()[indice];
                servicio.eliminar(emp);

                // refrescar la tabla
                CargarEmpleados();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void BotonReporte_Click(object sender, EventArgs e)
        {
            FormReporte formulario = new FormReporte(servicio);
            formulario.ShowDialog();
        }
        // cuando el usuario escribe en el buscador filtro la tabla
        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string buscar = textBox1.Text.ToLower();

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                string nombre = fila.Cells["colNombre"].Value?.ToString().ToLower() ?? "";
                string nss = fila.Cells["colNSS"].Value?.ToString().ToLower() ?? "";

                fila.Visible = nombre.Contains(buscar) || nss.Contains(buscar);
            }
        }

        // cuando cambia el filtro muestro solo ese tipo de empleado
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = comboBox1.SelectedItem?.ToString() ?? "";

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                string tipo = fila.Cells["colTipo"].Value?.ToString() ?? "";

                if (filtro == "Todos los tipos")
                    fila.Visible = true;
                else
                    fila.Visible = tipo == filtro;
            }
        }

        // menu empleados abre ventana de nuevo empleado
        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleado formulario = new FormEmpleado(servicio);
            formulario.ShowDialog();
            CargarEmpleados();
        }

        // menu reportes abre ventana de reporte
        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporte formulario = new FormReporte(servicio);
            formulario.ShowDialog();
        }

        // menu salir cierra la aplicacion
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // 1000 empleados de prueba 
        private void BtnPrueba1000_Click(object sender, EventArgs e)
        {
            DateTime inicio = DateTime.Now;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 4 == 0)
                {
                    EmpleadoAsalariado emp = new EmpleadoAsalariado(
                        "Nombre" + i, "Apellido" + i, "NSS" + i, 1000 + i
                    );
                    servicio.Agregar(emp);
                }
                else if (i % 4 == 1)
                {
                    EmpleadoPorHoras emp = new EmpleadoPorHoras(
                        "Nombre" + i, "Apellido" + i, "NSS" + i, 50 + i, 40
                    );
                    servicio.Agregar(emp);
                }
                else if (i % 4 == 2)
                {
                    EmpleadoPorComision emp = new EmpleadoPorComision(
                        "Nombre" + i, "Apellido" + i, "NSS" + i, 10000 + i, 0.10m
                    );
                    servicio.Agregar(emp);
                }
                else
                {
                    EmpleadoAsalariadoPorComision emp = new EmpleadoAsalariadoPorComision(
                        "Nombre" + i, "Apellido" + i, "NSS" + i, 10000 + i, 0.10m, 5000 + i
                    );
                    servicio.Agregar(emp);
                }
            }

            CargarEmpleados();

            DateTime fin = DateTime.Now;
            TimeSpan tiempo = fin - inicio;

            MessageBox.Show("1000 empleados generados en " + tiempo.TotalSeconds.ToString("F2") + " segundos.");
        }
    }
}