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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BackUp));
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dateTimePickerMes = new System.Windows.Forms.DateTimePicker();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownBackUp = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBack = new System.Windows.Forms.DataGridView();
            this.dateTimePickerFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDvDs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxParteBackUp = new System.Windows.Forms.ComboBox();
            this.comboBoxMedida = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxConfeccionado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownPeso = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxObservacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxParteDVD = new System.Windows.Forms.ComboBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.textBoxCaratula = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.Color.Lime;
            this.buttonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.Location = new System.Drawing.Point(19, 603);
            this.buttonRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(139, 38);
            this.buttonRegistrar.TabIndex = 0;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Tomato;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(165, 603);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(139, 38);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Visible = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // dateTimePickerMes
            // 
            this.dateTimePickerMes.CustomFormat = "MMMM/yyyy";
            this.dateTimePickerMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMes.Location = new System.Drawing.Point(14, 130);
            this.dateTimePickerMes.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerMes.Name = "dateTimePickerMes";
            this.dateTimePickerMes.Size = new System.Drawing.Size(162, 22);
            this.dateTimePickerMes.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(101, 55);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(111, 39);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mes y Año ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nro BackUp";
            // 
            // numericUpDownBackUp
            // 
            this.numericUpDownBackUp.Location = new System.Drawing.Point(12, 66);
            this.numericUpDownBackUp.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownBackUp.Name = "numericUpDownBackUp";
            this.numericUpDownBackUp.Size = new System.Drawing.Size(69, 22);
            this.numericUpDownBackUp.TabIndex = 1;
            this.numericUpDownBackUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Parte DVD";
            // 
            // dgvBack
            // 
            this.dgvBack.AllowUserToAddRows = false;
            this.dgvBack.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBack.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBack.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBack.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBack.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBack.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBack.Location = new System.Drawing.Point(321, 44);
            this.dgvBack.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBack.Name = "dgvBack";
            this.dgvBack.ReadOnly = true;
            this.dgvBack.RowHeadersVisible = false;
            this.dgvBack.RowHeadersWidth = 51;
            this.dgvBack.RowTemplate.Height = 40;
            this.dgvBack.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBack.Size = new System.Drawing.Size(1214, 673);
            this.dgvBack.TabIndex = 10;
            this.dgvBack.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dateTimePickerFechaRegistro
            // 
            this.dateTimePickerFechaRegistro.CustomFormat = "";
            this.dateTimePickerFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaRegistro.Location = new System.Drawing.Point(14, 352);
            this.dateTimePickerFechaRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaRegistro.Name = "dateTimePickerFechaRegistro";
            this.dateTimePickerFechaRegistro.Size = new System.Drawing.Size(162, 22);
            this.dateTimePickerFechaRegistro.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha del Hecho / Registro";
            // 
            // textBoxDvDs
            // 
            this.textBoxDvDs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxDvDs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxDvDs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDvDs.Location = new System.Drawing.Point(15, 181);
            this.textBoxDvDs.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDvDs.Name = "textBoxDvDs";
            this.textBoxDvDs.Size = new System.Drawing.Size(297, 22);
            this.textBoxDvDs.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "DVD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Parte Backup";
            // 
            // comboBoxParteBackUp
            // 
            this.comboBoxParteBackUp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxParteBackUp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxParteBackUp.FormattingEnabled = true;
            this.comboBoxParteBackUp.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII",
            "IIX",
            "IX",
            "X",
            "XI",
            "XII",
            "XIII",
            "XIV",
            "XV",
            "XVI",
            "XVII",
            "XVIII",
            "XIIX",
            "XIX",
            "XX"});
            this.comboBoxParteBackUp.Location = new System.Drawing.Point(202, 130);
            this.comboBoxParteBackUp.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxParteBackUp.Name = "comboBoxParteBackUp";
            this.comboBoxParteBackUp.Size = new System.Drawing.Size(89, 24);
            this.comboBoxParteBackUp.TabIndex = 3;
            // 
            // comboBoxMedida
            // 
            this.comboBoxMedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMedida.FormattingEnabled = true;
            this.comboBoxMedida.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB",
            "TB"});
            this.comboBoxMedida.Location = new System.Drawing.Point(139, 411);
            this.comboBoxMedida.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMedida.Name = "comboBoxMedida";
            this.comboBoxMedida.Size = new System.Drawing.Size(80, 24);
            this.comboBoxMedida.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 387);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Medida";
            // 
            // textBoxConfeccionado
            // 
            this.textBoxConfeccionado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxConfeccionado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxConfeccionado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxConfeccionado.Location = new System.Drawing.Point(12, 472);
            this.textBoxConfeccionado.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfeccionado.Name = "textBoxConfeccionado";
            this.textBoxConfeccionado.Size = new System.Drawing.Size(300, 22);
            this.textBoxConfeccionado.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 448);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Confeccionado por";
            // 
            // numericUpDownPeso
            // 
            this.numericUpDownPeso.DecimalPlaces = 2;
            this.numericUpDownPeso.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownPeso.Location = new System.Drawing.Point(12, 411);
            this.numericUpDownPeso.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownPeso.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownPeso.Name = "numericUpDownPeso";
            this.numericUpDownPeso.Size = new System.Drawing.Size(96, 22);
            this.numericUpDownPeso.TabIndex = 8;
            this.numericUpDownPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 388);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Peso";
            // 
            // textBoxObservacion
            // 
            this.textBoxObservacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxObservacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBoxObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxObservacion.Location = new System.Drawing.Point(12, 531);
            this.textBoxObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxObservacion.Multiline = true;
            this.textBoxObservacion.Name = "textBoxObservacion";
            this.textBoxObservacion.Size = new System.Drawing.Size(300, 64);
            this.textBoxObservacion.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 508);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Observacion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.Location = new System.Drawing.Point(968, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 23);
            this.label11.TabIndex = 26;
            this.label11.Text = "BackUps";
            // 
            // comboBoxParteDVD
            // 
            this.comboBoxParteDVD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxParteDVD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxParteDVD.FormattingEnabled = true;
            this.comboBoxParteDVD.Items.AddRange(new object[] {
            "N/C",
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII",
            "IIX",
            "IX",
            "X",
            "XI",
            "XII",
            "XIII",
            "XIV",
            "XV",
            "XVI",
            "XVII",
            "XVIII",
            "XIIX",
            "XIX",
            "XX"});
            this.comboBoxParteDVD.Location = new System.Drawing.Point(16, 239);
            this.comboBoxParteDVD.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxParteDVD.Name = "comboBoxParteDVD";
            this.comboBoxParteDVD.Size = new System.Drawing.Size(72, 24);
            this.comboBoxParteDVD.TabIndex = 5;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(219, 55);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(93, 39);
            this.buttonLimpiar.TabIndex = 28;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // textBoxCaratula
            // 
            this.textBoxCaratula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCaratula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCaratula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCaratula.Location = new System.Drawing.Point(14, 291);
            this.textBoxCaratula.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCaratula.Name = "textBoxCaratula";
            this.textBoxCaratula.Size = new System.Drawing.Size(298, 22);
            this.textBoxCaratula.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 271);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Causa-Caratula";
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.Yellow;
            this.buttonActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.Location = new System.Drawing.Point(19, 603);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(139, 38);
            this.buttonActualizar.TabIndex = 32;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Visible = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // Form_BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1540, 732);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxCaratula);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.comboBoxParteDVD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxObservacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDownPeso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxConfeccionado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxMedida);
            this.Controls.Add(this.comboBoxParteBackUp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDvDs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerFechaRegistro);
            this.Controls.Add(this.dgvBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownBackUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.dateTimePickerMes);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonRegistrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form_BackUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro BackUp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_BackUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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