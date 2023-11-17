using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    partial class Form_BackUp
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BackUp));
            buttonRegistrar = new Button();
            buttonEliminar = new Button();
            dateTimePickerMes = new DateTimePicker();
            buttonBuscar = new Button();
            label1 = new Label();
            label2 = new Label();
            numericUpDownBackUp = new NumericUpDown();
            label3 = new Label();
            dgvBack = new DataGridView();
            dateTimePickerFechaRegistro = new DateTimePicker();
            label4 = new Label();
            textBoxDvDs = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBoxParteBackUp = new ComboBox();
            comboBoxMedida = new ComboBox();
            label7 = new Label();
            textBoxConfeccionado = new TextBox();
            label8 = new Label();
            numericUpDownPeso = new NumericUpDown();
            label9 = new Label();
            textBoxObservacion = new TextBox();
            label10 = new Label();
            label11 = new Label();
            comboBoxParteDVD = new ComboBox();
            buttonLimpiar = new Button();
            textBoxCaratula = new TextBox();
            label12 = new Label();
            buttonActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBackUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPeso).BeginInit();
            SuspendLayout();
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.Lime;
            buttonRegistrar.Location = new Point(16, 603);
            buttonRegistrar.Margin = new Padding(4);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(139, 38);
            buttonRegistrar.TabIndex = 0;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.Tomato;
            buttonEliminar.Location = new Point(162, 605);
            buttonEliminar.Margin = new Padding(4);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(139, 38);
            buttonEliminar.TabIndex = 2;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Visible = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // dateTimePickerMes
            // 
            dateTimePickerMes.CustomFormat = "MMMM/yyyy";
            dateTimePickerMes.Format = DateTimePickerFormat.Custom;
            dateTimePickerMes.Location = new Point(14, 130);
            dateTimePickerMes.Margin = new Padding(4);
            dateTimePickerMes.Name = "dateTimePickerMes";
            dateTimePickerMes.Size = new Size(162, 27);
            dateTimePickerMes.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = SystemColors.ActiveCaption;
            buttonBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscar.Location = new Point(120, 56);
            buttonBuscar.Margin = new Padding(4);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 39);
            buttonBuscar.TabIndex = 5;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 106);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 6;
            label1.Text = "Mes y Año ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 7;
            label2.Text = "Nro BackUp";
            // 
            // numericUpDownBackUp
            // 
            numericUpDownBackUp.Location = new Point(12, 66);
            numericUpDownBackUp.Margin = new Padding(4);
            numericUpDownBackUp.Name = "numericUpDownBackUp";
            numericUpDownBackUp.Size = new Size(69, 27);
            numericUpDownBackUp.TabIndex = 1;
            numericUpDownBackUp.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 216);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 9;
            label3.Text = "Parte DVD";
            // 
            // dgvBack
            // 
            dgvBack.AllowUserToAddRows = false;
            dgvBack.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvBack.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBack.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBack.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.DarkGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBack.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBack.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBack.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBack.Location = new Point(321, 44);
            dgvBack.Margin = new Padding(4);
            dgvBack.Name = "dgvBack";
            dgvBack.ReadOnly = true;
            dgvBack.RowHeadersVisible = false;
            dgvBack.RowHeadersWidth = 51;
            dgvBack.RowTemplate.Height = 40;
            dgvBack.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBack.Size = new Size(1214, 673);
            dgvBack.TabIndex = 10;
            dgvBack.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // dateTimePickerFechaRegistro
            // 
            dateTimePickerFechaRegistro.CustomFormat = "";
            dateTimePickerFechaRegistro.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaRegistro.Location = new Point(14, 352);
            dateTimePickerFechaRegistro.Margin = new Padding(4);
            dateTimePickerFechaRegistro.Name = "dateTimePickerFechaRegistro";
            dateTimePickerFechaRegistro.Size = new Size(162, 27);
            dateTimePickerFechaRegistro.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 329);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(188, 20);
            label4.TabIndex = 12;
            label4.Text = "Fecha del Hecho / Registro";
            // 
            // textBoxDvDs
            // 
            textBoxDvDs.CharacterCasing = CharacterCasing.Upper;
            textBoxDvDs.Location = new Point(16, 184);
            textBoxDvDs.Margin = new Padding(4);
            textBoxDvDs.Name = "textBoxDvDs";
            textBoxDvDs.Size = new Size(297, 27);
            textBoxDvDs.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 161);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 14;
            label5.Text = "DVS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 106);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 15;
            label6.Text = "Parte Backup";
            // 
            // comboBoxParteBackUp
            // 
            comboBoxParteBackUp.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxParteBackUp.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxParteBackUp.FormattingEnabled = true;
            comboBoxParteBackUp.Items.AddRange(new object[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IIX", "IX", "X", "XI", "XII", "XIII", "XIV", "XVI", "XVII", "XVIII", "XIIX", "XIX", "XX" });
            comboBoxParteBackUp.Location = new Point(202, 130);
            comboBoxParteBackUp.Margin = new Padding(4);
            comboBoxParteBackUp.Name = "comboBoxParteBackUp";
            comboBoxParteBackUp.Size = new Size(89, 28);
            comboBoxParteBackUp.TabIndex = 3;
            // 
            // comboBoxMedida
            // 
            comboBoxMedida.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxMedida.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMedida.FormattingEnabled = true;
            comboBoxMedida.Items.AddRange(new object[] { "KB", "MB", "GB", "TB" });
            comboBoxMedida.Location = new Point(139, 411);
            comboBoxMedida.Margin = new Padding(4);
            comboBoxMedida.Name = "comboBoxMedida";
            comboBoxMedida.Size = new Size(80, 28);
            comboBoxMedida.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(139, 387);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 19;
            label7.Text = "Medida";
            // 
            // textBoxConfeccionado
            // 
            textBoxConfeccionado.CharacterCasing = CharacterCasing.Upper;
            textBoxConfeccionado.Location = new Point(12, 472);
            textBoxConfeccionado.Margin = new Padding(4);
            textBoxConfeccionado.Name = "textBoxConfeccionado";
            textBoxConfeccionado.Size = new Size(300, 27);
            textBoxConfeccionado.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 448);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(141, 20);
            label8.TabIndex = 21;
            label8.Text = "Confeccionador por";
            // 
            // numericUpDownPeso
            // 
            numericUpDownPeso.DecimalPlaces = 2;
            numericUpDownPeso.Location = new Point(12, 411);
            numericUpDownPeso.Margin = new Padding(4);
            numericUpDownPeso.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericUpDownPeso.Name = "numericUpDownPeso";
            numericUpDownPeso.Size = new Size(96, 27);
            numericUpDownPeso.TabIndex = 8;
            numericUpDownPeso.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 388);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 23;
            label9.Text = "Peso";
            // 
            // textBoxObservacion
            // 
            textBoxObservacion.CharacterCasing = CharacterCasing.Upper;
            textBoxObservacion.Location = new Point(12, 531);
            textBoxObservacion.Margin = new Padding(4);
            textBoxObservacion.Multiline = true;
            textBoxObservacion.Name = "textBoxObservacion";
            textBoxObservacion.Size = new Size(300, 64);
            textBoxObservacion.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 508);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(91, 20);
            label10.TabIndex = 25;
            label10.Text = "Observacion";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(968, 11);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(74, 23);
            label11.TabIndex = 26;
            label11.Text = "BackUps";
            // 
            // comboBoxParteDVD
            // 
            comboBoxParteDVD.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxParteDVD.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxParteDVD.FormattingEnabled = true;
            comboBoxParteDVD.Items.AddRange(new object[] { "N/C", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IIX", "IX", "X", "XI", "XII", "XIII", "XIV", "XVI", "XVII", "XVIII", "XIIX", "XIX", "XX" });
            comboBoxParteDVD.Location = new Point(16, 239);
            comboBoxParteDVD.Margin = new Padding(4);
            comboBoxParteDVD.Name = "comboBoxParteDVD";
            comboBoxParteDVD.Size = new Size(72, 28);
            comboBoxParteDVD.TabIndex = 5;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = SystemColors.ActiveCaption;
            buttonLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimpiar.Location = new Point(220, 58);
            buttonLimpiar.Margin = new Padding(4);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(84, 39);
            buttonLimpiar.TabIndex = 28;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // textBoxCaratula
            // 
            textBoxCaratula.CharacterCasing = CharacterCasing.Upper;
            textBoxCaratula.Location = new Point(15, 292);
            textBoxCaratula.Margin = new Padding(4);
            textBoxCaratula.Name = "textBoxCaratula";
            textBoxCaratula.Size = new Size(298, 27);
            textBoxCaratula.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 271);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(64, 20);
            label12.TabIndex = 31;
            label12.Text = "Caratula";
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = Color.Yellow;
            buttonActualizar.Location = new Point(15, 603);
            buttonActualizar.Margin = new Padding(4);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(139, 38);
            buttonActualizar.TabIndex = 32;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = false;
            buttonActualizar.Visible = false;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // Form_BackUp
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1540, 732);
            Controls.Add(buttonActualizar);
            Controls.Add(label12);
            Controls.Add(textBoxCaratula);
            Controls.Add(buttonLimpiar);
            Controls.Add(comboBoxParteDVD);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBoxObservacion);
            Controls.Add(label9);
            Controls.Add(numericUpDownPeso);
            Controls.Add(label8);
            Controls.Add(textBoxConfeccionado);
            Controls.Add(label7);
            Controls.Add(comboBoxMedida);
            Controls.Add(comboBoxParteBackUp);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxDvDs);
            Controls.Add(label4);
            Controls.Add(dateTimePickerFechaRegistro);
            Controls.Add(dgvBack);
            Controls.Add(label3);
            Controls.Add(numericUpDownBackUp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonBuscar);
            Controls.Add(dateTimePickerMes);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonRegistrar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form_BackUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro BackUp";
            Load += Form_BackUp_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownBackUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPeso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegistrar;
        private Button buttonEliminar;
        private DateTimePicker dateTimePickerMes;
        private Button buttonBuscar;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownBackUp;
        private Label label3;
        private DataGridView dgvBack;
        private DateTimePicker dateTimePickerFechaRegistro;
        private Label label4;
        private TextBox textBoxDvDs;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxParteBackUp;
        private ComboBox comboBoxMedida;
        private Label label7;
        private TextBox textBoxConfeccionado;
        private Label label8;
        private NumericUpDown numericUpDownPeso;
        private Label label9;
        private TextBox textBoxObservacion;
        private Label label10;
        private Label label11;
        private ComboBox comboBoxParteDVD;
        private Button buttonLimpiar;
        private TextBox textBoxCaratula;
        private Label label12;
        private Button buttonActualizar;
    }
}