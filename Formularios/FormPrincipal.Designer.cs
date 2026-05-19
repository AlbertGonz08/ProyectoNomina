namespace ProyectoNomina
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nss1 = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Pagosemanal = new DataGridViewTextBoxColumn();
            Acciones = new DataGridViewTextBoxColumn();
            button1 = new Button();
            BotonReporte = new Button();
            comboBox1 = new ComboBox();
            menuStrip1 = new MenuStrip();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_Eliminar = new Button();
            BtnPrueba1000 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, nss1, Tipo, Pagosemanal, Acciones });
            dataGridView1.Location = new Point(28, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(676, 211);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "Nombre";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // nss1
            // 
            nss1.HeaderText = "NSS";
            nss1.MinimumWidth = 6;
            nss1.Name = "nss1";
            nss1.Width = 125;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.Width = 125;
            // 
            // Pagosemanal
            // 
            Pagosemanal.HeaderText = "Pago semanal";
            Pagosemanal.MinimumWidth = 6;
            Pagosemanal.Name = "Pagosemanal";
            Pagosemanal.Width = 125;
            // 
            // Acciones
            // 
            Acciones.HeaderText = "Acciones";
            Acciones.MinimumWidth = 6;
            Acciones.Name = "Acciones";
            Acciones.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(410, 99);
            button1.Name = "button1";
            button1.Size = new Size(194, 29);
            button1.TabIndex = 1;
            button1.Text = "Nuevo Empleado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BotonReporte
            // 
            BotonReporte.Location = new Point(610, 99);
            BotonReporte.Name = "BotonReporte";
            BotonReporte.Size = new Size(94, 29);
            BotonReporte.TabIndex = 2;
            BotonReporte.Text = "Reporte";
            BotonReporte.UseVisualStyleBackColor = true;
            BotonReporte.Click += BotonReporte_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Todos los tipos", "Asalariado", "Por horas", "Por comisión", "Asalariado por comisión" });
            comboBox1.Location = new Point(410, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { empleadosToolStripMenuItem, reportesToolStripMenuItem, archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(737, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(97, 24);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(52, 24);
            archivoToolStripMenuItem.Text = "Salir";
            archivoToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBoxBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(410, 42);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 6;
            label1.Text = "Filtrar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(28, 65);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 7;
            label2.Text = "Buscar Empleado:";
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(310, 99);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(94, 29);
            btn_Eliminar.TabIndex = 8;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // BtnPrueba1000
            // 
            BtnPrueba1000.Location = new Point(274, 61);
            BtnPrueba1000.Name = "BtnPrueba1000";
            BtnPrueba1000.Size = new Size(130, 29);
            BtnPrueba1000.TabIndex = 9;
            BtnPrueba1000.Text = "Prueba 1000";
            BtnPrueba1000.UseVisualStyleBackColor = true;
            BtnPrueba1000.Click += BtnPrueba1000_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(737, 450);
            Controls.Add(BtnPrueba1000);
            Controls.Add(btn_Eliminar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(BotonReporte);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "Sistema de nómina";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button BotonReporte;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nss1;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Pagosemanal;
        private DataGridViewTextBoxColumn Acciones;
        private ComboBox comboBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button btn_Eliminar;
        private Button BtnPrueba1000;
    }
}
