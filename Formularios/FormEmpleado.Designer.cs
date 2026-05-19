namespace ProyectoNomina
{
    partial class FormEmpleado
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
            textBoxSalarioBase = new TextBox();
            textBoxHorasTrabajadas = new TextBox();
            textBoxSueldoPorHora = new TextBox();
            textBoxTarifaComision = new TextBox();
            textBoxVentasBrutas = new TextBox();
            textBoxSalarioSemanal = new TextBox();
            NúmeroSeguroTextBox = new TextBox();
            ApellidoTextBox = new TextBox();
            NombreTextBox = new TextBox();
            labelSalarioBase = new Label();
            labelHorasTrabajadas = new Label();
            labelSueldoPorHora = new Label();
            labelTarifaComision = new Label();
            labelVentasBrutas = new Label();
            labelSalarioSemanal = new Label();
            panel1 = new Panel();
            lblResultadoPago = new Label();
            label4 = new Label();
            btn_Guardar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            RadioButtonAsalaComision = new RadioButton();
            RadioButtonPorComisión = new RadioButton();
            RadioButtonPorHoras = new RadioButton();
            RadioButtonAsalariado = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxSalarioBase
            // 
            textBoxSalarioBase.Location = new Point(383, 326);
            textBoxSalarioBase.Name = "textBoxSalarioBase";
            textBoxSalarioBase.Size = new Size(125, 27);
            textBoxSalarioBase.TabIndex = 49;
            textBoxSalarioBase.TextChanged += textBoxSalarioBase_TextChanged;
            // 
            // textBoxHorasTrabajadas
            // 
            textBoxHorasTrabajadas.Location = new Point(532, 261);
            textBoxHorasTrabajadas.Name = "textBoxHorasTrabajadas";
            textBoxHorasTrabajadas.Size = new Size(125, 27);
            textBoxHorasTrabajadas.TabIndex = 47;
            textBoxHorasTrabajadas.TextChanged += textBoxHorasTrabajadas_TextChanged;
            // 
            // textBoxSueldoPorHora
            // 
            textBoxSueldoPorHora.Location = new Point(532, 175);
            textBoxSueldoPorHora.Name = "textBoxSueldoPorHora";
            textBoxSueldoPorHora.Size = new Size(125, 27);
            textBoxSueldoPorHora.TabIndex = 45;
            textBoxSueldoPorHora.TextChanged += textBoxSueldoPorHora_TextChanged;
            // 
            // textBoxTarifaComision
            // 
            textBoxTarifaComision.Location = new Point(383, 261);
            textBoxTarifaComision.Name = "textBoxTarifaComision";
            textBoxTarifaComision.Size = new Size(125, 27);
            textBoxTarifaComision.TabIndex = 43;
            textBoxTarifaComision.TextChanged += textBoxTarifaComision_TextChanged;
            // 
            // textBoxVentasBrutas
            // 
            textBoxVentasBrutas.Location = new Point(383, 175);
            textBoxVentasBrutas.Name = "textBoxVentasBrutas";
            textBoxVentasBrutas.Size = new Size(125, 27);
            textBoxVentasBrutas.TabIndex = 41;
            textBoxVentasBrutas.TextChanged += textBoxVentasBrutas_TextChanged;
            // 
            // textBoxSalarioSemanal
            // 
            textBoxSalarioSemanal.Location = new Point(169, 261);
            textBoxSalarioSemanal.Name = "textBoxSalarioSemanal";
            textBoxSalarioSemanal.Size = new Size(194, 27);
            textBoxSalarioSemanal.TabIndex = 39;
            textBoxSalarioSemanal.TextChanged += textBoxSalarioSemanal_TextChanged;
            // 
            // NúmeroSeguroTextBox
            // 
            NúmeroSeguroTextBox.Location = new Point(33, 261);
            NúmeroSeguroTextBox.Name = "NúmeroSeguroTextBox";
            NúmeroSeguroTextBox.Size = new Size(125, 27);
            NúmeroSeguroTextBox.TabIndex = 34;
            // 
            // ApellidoTextBox
            // 
            ApellidoTextBox.Location = new Point(164, 175);
            ApellidoTextBox.Name = "ApellidoTextBox";
            ApellidoTextBox.Size = new Size(125, 27);
            ApellidoTextBox.TabIndex = 32;
            // 
            // NombreTextBox
            // 
            NombreTextBox.Location = new Point(33, 175);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(125, 27);
            NombreTextBox.TabIndex = 31;
            // 
            // labelSalarioBase
            // 
            labelSalarioBase.AutoSize = true;
            labelSalarioBase.Location = new Point(383, 303);
            labelSalarioBase.Name = "labelSalarioBase";
            labelSalarioBase.Size = new Size(90, 20);
            labelSalarioBase.TabIndex = 48;
            labelSalarioBase.Text = "Salario base";
            // 
            // labelHorasTrabajadas
            // 
            labelHorasTrabajadas.AutoSize = true;
            labelHorasTrabajadas.Location = new Point(532, 238);
            labelHorasTrabajadas.Name = "labelHorasTrabajadas";
            labelHorasTrabajadas.Size = new Size(122, 20);
            labelHorasTrabajadas.TabIndex = 46;
            labelHorasTrabajadas.Text = "Horas trabajadas";
            // 
            // labelSueldoPorHora
            // 
            labelSueldoPorHora.AutoSize = true;
            labelSueldoPorHora.Location = new Point(532, 152);
            labelSueldoPorHora.Name = "labelSueldoPorHora";
            labelSueldoPorHora.Size = new Size(116, 20);
            labelSueldoPorHora.TabIndex = 44;
            labelSueldoPorHora.Text = "Sueldo por hora";
            // 
            // labelTarifaComision
            // 
            labelTarifaComision.AutoSize = true;
            labelTarifaComision.Location = new Point(383, 238);
            labelTarifaComision.Name = "labelTarifaComision";
            labelTarifaComision.Size = new Size(109, 20);
            labelTarifaComision.TabIndex = 42;
            labelTarifaComision.Text = "Tarifa comisión";
            // 
            // labelVentasBrutas
            // 
            labelVentasBrutas.AutoSize = true;
            labelVentasBrutas.Location = new Point(383, 152);
            labelVentasBrutas.Name = "labelVentasBrutas";
            labelVentasBrutas.Size = new Size(97, 20);
            labelVentasBrutas.TabIndex = 40;
            labelVentasBrutas.Text = "Ventas brutas";
            // 
            // labelSalarioSemanal
            // 
            labelSalarioSemanal.AutoSize = true;
            labelSalarioSemanal.Location = new Point(169, 238);
            labelSalarioSemanal.Name = "labelSalarioSemanal";
            labelSalarioSemanal.Size = new Size(199, 20);
            labelSalarioSemanal.TabIndex = 38;
            labelSalarioSemanal.Text = "Salario semanal (Asalariado)";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(lblResultadoPago);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(33, 379);
            panel1.Name = "panel1";
            panel1.Size = new Size(711, 49);
            panel1.TabIndex = 37;
            // 
            // lblResultadoPago
            // 
            lblResultadoPago.AutoSize = true;
            lblResultadoPago.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultadoPago.ForeColor = SystemColors.HotTrack;
            lblResultadoPago.Location = new Point(599, 7);
            lblResultadoPago.Name = "lblResultadoPago";
            lblResultadoPago.Size = new Size(67, 31);
            lblResultadoPago.TabIndex = 1;
            lblResultadoPago.Text = "$0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(10, 12);
            label4.Name = "label4";
            label4.Size = new Size(215, 25);
            label4.TabIndex = 0;
            label4.Text = "Pago semanal estimado:";
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(650, 434);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(94, 29);
            btn_Guardar.TabIndex = 36;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 238);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 33;
            label3.Text = "Número de Seguro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 152);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 30;
            label2.Text = "Apellido paterno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 152);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 29;
            label1.Text = "Primer nombre";
            // 
            // RadioButtonAsalaComision
            // 
            RadioButtonAsalaComision.AutoSize = true;
            RadioButtonAsalaComision.Location = new Point(402, 108);
            RadioButtonAsalaComision.Name = "RadioButtonAsalaComision";
            RadioButtonAsalaComision.Size = new Size(135, 24);
            RadioButtonAsalaComision.TabIndex = 28;
            RadioButtonAsalaComision.TabStop = true;
            RadioButtonAsalaComision.Text = "Asala. Comisión";
            RadioButtonAsalaComision.UseVisualStyleBackColor = true;
            RadioButtonAsalaComision.CheckedChanged += RadioButtonAsalaComision_CheckedChanged;
            // 
            // RadioButtonPorComisión
            // 
            RadioButtonPorComisión.AutoSize = true;
            RadioButtonPorComisión.ForeColor = SystemColors.ControlText;
            RadioButtonPorComisión.Location = new Point(279, 108);
            RadioButtonPorComisión.Name = "RadioButtonPorComisión";
            RadioButtonPorComisión.Size = new Size(117, 24);
            RadioButtonPorComisión.TabIndex = 27;
            RadioButtonPorComisión.TabStop = true;
            RadioButtonPorComisión.Text = "Por Comisión";
            RadioButtonPorComisión.UseVisualStyleBackColor = true;
            RadioButtonPorComisión.CheckedChanged += RadioButtonPorComisión_CheckedChanged;
            // 
            // RadioButtonPorHoras
            // 
            RadioButtonPorHoras.AutoSize = true;
            RadioButtonPorHoras.Location = new Point(156, 108);
            RadioButtonPorHoras.Name = "RadioButtonPorHoras";
            RadioButtonPorHoras.Size = new Size(94, 24);
            RadioButtonPorHoras.TabIndex = 26;
            RadioButtonPorHoras.TabStop = true;
            RadioButtonPorHoras.Text = "Por Horas";
            RadioButtonPorHoras.UseVisualStyleBackColor = true;
            RadioButtonPorHoras.CheckedChanged += RadioButtonPorHoras_CheckedChanged;
            // 
            // RadioButtonAsalariado
            // 
            RadioButtonAsalariado.AutoSize = true;
            RadioButtonAsalariado.Location = new Point(33, 108);
            RadioButtonAsalariado.Name = "RadioButtonAsalariado";
            RadioButtonAsalariado.Size = new Size(101, 24);
            RadioButtonAsalariado.TabIndex = 25;
            RadioButtonAsalariado.TabStop = true;
            RadioButtonAsalariado.Text = "Asalariado";
            RadioButtonAsalariado.UseVisualStyleBackColor = true;
            RadioButtonAsalariado.CheckedChanged += RadioButtonAsalariado_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(123, 19);
            label5.Name = "label5";
            label5.Size = new Size(547, 46);
            label5.TabIndex = 50;
            label5.Text = "Registrar nuevo empleado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.IBeam;
            label6.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(33, 85);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 51;
            label6.Text = "Tipo de empleado:";
            label6.Click += label6_Click;
            // 
            // FormEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 571);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxSalarioBase);
            Controls.Add(textBoxHorasTrabajadas);
            Controls.Add(textBoxSueldoPorHora);
            Controls.Add(textBoxTarifaComision);
            Controls.Add(textBoxVentasBrutas);
            Controls.Add(textBoxSalarioSemanal);
            Controls.Add(NúmeroSeguroTextBox);
            Controls.Add(ApellidoTextBox);
            Controls.Add(NombreTextBox);
            Controls.Add(labelSalarioBase);
            Controls.Add(labelHorasTrabajadas);
            Controls.Add(labelSueldoPorHora);
            Controls.Add(labelTarifaComision);
            Controls.Add(labelVentasBrutas);
            Controls.Add(labelSalarioSemanal);
            Controls.Add(panel1);
            Controls.Add(btn_Guardar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RadioButtonAsalaComision);
            Controls.Add(RadioButtonPorComisión);
            Controls.Add(RadioButtonPorHoras);
            Controls.Add(RadioButtonAsalariado);
            Name = "FormEmpleado";
            Text = "Registro Empleado";
            Load += FormEmpleado_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSalarioBase;
        private TextBox textBoxHorasTrabajadas;
        private TextBox textBoxSueldoPorHora;
        private TextBox textBoxTarifaComision;
        private TextBox textBoxVentasBrutas;
        private TextBox textBoxSalarioSemanal;
        private TextBox NúmeroSeguroTextBox;
        private TextBox ApellidoTextBox;
        private TextBox NombreTextBox;
        private Label labelSalarioBase;
        private Label labelHorasTrabajadas;
        private Label labelSueldoPorHora;
        private Label labelTarifaComision;
        private Label labelVentasBrutas;
        private Label labelSalarioSemanal;
        private Panel panel1;
        private Label label4;
        private Button btn_Guardar;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton RadioButtonAsalaComision;
        private RadioButton RadioButtonPorComisión;
        private RadioButton RadioButtonPorHoras;
        private RadioButton RadioButtonAsalariado;
        private Label label5;
        private Label label6;
        private Label lblResultadoPago;
    }
}