namespace ProyectoNomina.Formularios
{
    partial class FormReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            EmpleadoRep = new DataGridViewTextBoxColumn();
            TipoRep = new DataGridViewTextBoxColumn();
            DetalleRep = new DataGridViewTextBoxColumn();
            PagoSemanalRep = new DataGridViewTextBoxColumn();
            panelAsalariadosRep = new Panel();
            lblTotalAsalariados = new Label();
            lblTituloAsalariados = new Label();
            panelPorHoras = new Panel();
            lblTotalPorHoras = new Label();
            lblTituloPorHoras = new Label();
            panelPorComision = new Panel();
            lblTotalPorComision = new Label();
            lblTituloPorComision = new Label();
            panelTotal = new Panel();
            lblTotalNomina = new Label();
            lblTituloTotal = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelAsalariadosRep.SuspendLayout();
            panelPorHoras.SuspendLayout();
            panelPorComision.SuspendLayout();
            panelTotal.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmpleadoRep, TipoRep, DetalleRep, PagoSemanalRep });
            dataGridView1.Location = new Point(212, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(554, 188);
            dataGridView1.TabIndex = 0;
            // 
            // EmpleadoRep
            // 
            EmpleadoRep.HeaderText = "Empleado";
            EmpleadoRep.MinimumWidth = 6;
            EmpleadoRep.Name = "EmpleadoRep";
            EmpleadoRep.Width = 125;
            // 
            // TipoRep
            // 
            TipoRep.HeaderText = "Tipo";
            TipoRep.MinimumWidth = 6;
            TipoRep.Name = "TipoRep";
            TipoRep.Width = 125;
            // 
            // DetalleRep
            // 
            DetalleRep.HeaderText = "Detalle del cálculo";
            DetalleRep.MinimumWidth = 6;
            DetalleRep.Name = "DetalleRep";
            DetalleRep.Width = 125;
            // 
            // PagoSemanalRep
            // 
            PagoSemanalRep.HeaderText = "Pago Semanal";
            PagoSemanalRep.MinimumWidth = 6;
            PagoSemanalRep.Name = "PagoSemanalRep";
            PagoSemanalRep.Width = 125;
            // 
            // panelAsalariadosRep
            // 
            panelAsalariadosRep.BackColor = SystemColors.AppWorkspace;
            panelAsalariadosRep.Controls.Add(lblTotalAsalariados);
            panelAsalariadosRep.Controls.Add(lblTituloAsalariados);
            panelAsalariadosRep.Location = new Point(32, 61);
            panelAsalariadosRep.Name = "panelAsalariadosRep";
            panelAsalariadosRep.Size = new Size(210, 96);
            panelAsalariadosRep.TabIndex = 1;
            // 
            // lblTotalAsalariados
            // 
            lblTotalAsalariados.AutoSize = true;
            lblTotalAsalariados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAsalariados.ForeColor = SystemColors.MenuHighlight;
            lblTotalAsalariados.Location = new Point(87, 39);
            lblTotalAsalariados.Name = "lblTotalAsalariados";
            lblTotalAsalariados.Size = new Size(49, 20);
            lblTotalAsalariados.TabIndex = 1;
            lblTotalAsalariados.Text = "$0.00";
            // 
            // lblTituloAsalariados
            // 
            lblTituloAsalariados.AutoSize = true;
            lblTituloAsalariados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloAsalariados.Location = new Point(65, 9);
            lblTituloAsalariados.Name = "lblTituloAsalariados";
            lblTituloAsalariados.Size = new Size(90, 20);
            lblTituloAsalariados.TabIndex = 0;
            lblTituloAsalariados.Text = "Asalariados";
            // 
            // panelPorHoras
            // 
            panelPorHoras.BackColor = SystemColors.AppWorkspace;
            panelPorHoras.Controls.Add(lblTotalPorHoras);
            panelPorHoras.Controls.Add(lblTituloPorHoras);
            panelPorHoras.Location = new Point(262, 61);
            panelPorHoras.Name = "panelPorHoras";
            panelPorHoras.Size = new Size(210, 96);
            panelPorHoras.TabIndex = 2;
            // 
            // lblTotalPorHoras
            // 
            lblTotalPorHoras.AutoSize = true;
            lblTotalPorHoras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPorHoras.ForeColor = SystemColors.MenuHighlight;
            lblTotalPorHoras.Location = new Point(83, 39);
            lblTotalPorHoras.Name = "lblTotalPorHoras";
            lblTotalPorHoras.Size = new Size(49, 20);
            lblTotalPorHoras.TabIndex = 1;
            lblTotalPorHoras.Text = "$0.00";
            // 
            // lblTituloPorHoras
            // 
            lblTituloPorHoras.AutoSize = true;
            lblTituloPorHoras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPorHoras.Location = new Point(74, 9);
            lblTituloPorHoras.Name = "lblTituloPorHoras";
            lblTituloPorHoras.Size = new Size(76, 20);
            lblTituloPorHoras.TabIndex = 0;
            lblTituloPorHoras.Text = "Por horas";
            // 
            // panelPorComision
            // 
            panelPorComision.BackColor = SystemColors.AppWorkspace;
            panelPorComision.Controls.Add(lblTotalPorComision);
            panelPorComision.Controls.Add(lblTituloPorComision);
            panelPorComision.Location = new Point(497, 61);
            panelPorComision.Name = "panelPorComision";
            panelPorComision.Size = new Size(210, 96);
            panelPorComision.TabIndex = 3;
            // 
            // lblTotalPorComision
            // 
            lblTotalPorComision.AutoSize = true;
            lblTotalPorComision.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPorComision.ForeColor = SystemColors.MenuHighlight;
            lblTotalPorComision.Location = new Point(74, 39);
            lblTotalPorComision.Name = "lblTotalPorComision";
            lblTotalPorComision.Size = new Size(49, 20);
            lblTotalPorComision.TabIndex = 1;
            lblTotalPorComision.Text = "$0.00";
            // 
            // lblTituloPorComision
            // 
            lblTituloPorComision.AutoSize = true;
            lblTituloPorComision.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPorComision.Location = new Point(55, 9);
            lblTituloPorComision.Name = "lblTituloPorComision";
            lblTituloPorComision.Size = new Size(100, 20);
            lblTituloPorComision.TabIndex = 0;
            lblTituloPorComision.Text = "Por comisión";
            // 
            // panelTotal
            // 
            panelTotal.BackColor = SystemColors.AppWorkspace;
            panelTotal.Controls.Add(lblTotalNomina);
            panelTotal.Controls.Add(lblTituloTotal);
            panelTotal.Location = new Point(732, 61);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(210, 96);
            panelTotal.TabIndex = 4;
            // 
            // lblTotalNomina
            // 
            lblTotalNomina.AutoSize = true;
            lblTotalNomina.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalNomina.ForeColor = SystemColors.MenuHighlight;
            lblTotalNomina.Location = new Point(80, 39);
            lblTotalNomina.Name = "lblTotalNomina";
            lblTotalNomina.Size = new Size(49, 20);
            lblTotalNomina.TabIndex = 1;
            lblTotalNomina.Text = "$0.00";
            // 
            // lblTituloTotal
            // 
            lblTituloTotal.AutoSize = true;
            lblTituloTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloTotal.Location = new Point(55, 9);
            lblTituloTotal.Name = "lblTituloTotal";
            lblTituloTotal.Size = new Size(104, 20);
            lblTituloTotal.TabIndex = 0;
            lblTituloTotal.Text = "Total Nómina";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(336, 9);
            label1.Name = "label1";
            label1.Size = new Size(353, 46);
            label1.TabIndex = 6;
            label1.Text = "Reporte Semanal";
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(983, 450);
            Controls.Add(label1);
            Controls.Add(panelTotal);
            Controls.Add(panelPorComision);
            Controls.Add(panelPorHoras);
            Controls.Add(panelAsalariadosRep);
            Controls.Add(dataGridView1);
            Name = "FormReporte";
            Text = "Reporte Semanal";
            Load += FormReporte_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelAsalariadosRep.ResumeLayout(false);
            panelAsalariadosRep.PerformLayout();
            panelPorHoras.ResumeLayout(false);
            panelPorHoras.PerformLayout();
            panelPorComision.ResumeLayout(false);
            panelPorComision.PerformLayout();
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn EmpleadoRep;
        private DataGridViewTextBoxColumn TipoRep;
        private DataGridViewTextBoxColumn DetalleRep;
        private DataGridViewTextBoxColumn PagoSemanalRep;
        private Panel panelAsalariadosRep;
        private Panel panelPorHoras;
        private Panel panelPorComision;
        private Panel panelTotal;
        private Label lblTotalAsalariados;
        private Label lblTituloAsalariados;
        private Label lblTotalPorHoras;
        private Label lblTituloPorHoras;
        private Label lblTotalPorComision;
        private Label lblTituloPorComision;
        private Label lblTotalNomina;
        private Label lblTituloTotal;
        private Label label1;
    }
}