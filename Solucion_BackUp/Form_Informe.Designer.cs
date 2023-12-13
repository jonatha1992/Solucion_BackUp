using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    partial class Form_Informe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Informe));
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dateTimePickerFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvInformes = new System.Windows.Forms.DataGridView();
            this.dateTimePickerFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNroSolicitud = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTipoSolicitud = new System.Windows.Forms.ComboBox();
            this.textBoxNroInforme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxObservacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxSolicitante = new System.Windows.Forms.ComboBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.textBoxCausa_Prevencion = new System.Windows.Forms.TextBox();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.numericUpDownOrden = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxCaratula = new System.Windows.Forms.TextBox();
            this.comboBoxTipoDelito = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxDependencia = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNroDvd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNroActa_elevacion = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxRetirado = new System.Windows.Forms.TextBox();
            this.comboBoxOrganismo = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxNroAsunto = new System.Windows.Forms.TextBox();
            this.groupBoxEntrega = new System.Windows.Forms.GroupBox();
            this.checkBoxEntrega = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrden)).BeginInit();
            this.groupBoxEntrega.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.Color.Lime;
            this.buttonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.Location = new System.Drawing.Point(35, 642);
            this.buttonRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(108, 38);
            this.buttonRegistrar.TabIndex = 0;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Tomato;
            this.buttonEliminar.Enabled = false;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(299, 642);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(108, 38);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // dateTimePickerFechaIngreso
            // 
            this.dateTimePickerFechaIngreso.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaIngreso.Location = new System.Drawing.Point(288, 34);
            this.dateTimePickerFechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaIngreso.Name = "dateTimePickerFechaIngreso";
            this.dateTimePickerFechaIngreso.Size = new System.Drawing.Size(148, 24);
            this.dateTimePickerFechaIngreso.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(102, 688);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(94, 38);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha Ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nro Asunto ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Solicitante";
            // 
            // dgvInformes
            // 
            this.dgvInformes.AllowUserToAddRows = false;
            this.dgvInformes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInformes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInformes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInformes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvInformes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInformes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInformes.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInformes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInformes.Location = new System.Drawing.Point(450, 35);
            this.dgvInformes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInformes.Name = "dgvInformes";
            this.dgvInformes.ReadOnly = true;
            this.dgvInformes.RowHeadersVisible = false;
            this.dgvInformes.RowHeadersWidth = 51;
            this.dgvInformes.RowTemplate.Height = 40;
            this.dgvInformes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInformes.Size = new System.Drawing.Size(1288, 719);
            this.dgvInformes.TabIndex = 10;
            this.dgvInformes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dateTimePickerFechaRegistro
            // 
            this.dateTimePickerFechaRegistro.CustomFormat = "";
            this.dateTimePickerFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaRegistro.Location = new System.Drawing.Point(6, 354);
            this.dateTimePickerFechaRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaRegistro.Name = "dateTimePickerFechaRegistro";
            this.dateTimePickerFechaRegistro.Size = new System.Drawing.Size(173, 24);
            this.dateTimePickerFechaRegistro.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha del Hecho / Registro";
            // 
            // textBoxNroSolicitud
            // 
            this.textBoxNroSolicitud.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxNroSolicitud.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNroSolicitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNroSolicitud.Location = new System.Drawing.Point(168, 92);
            this.textBoxNroSolicitud.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNroSolicitud.Name = "textBoxNroSolicitud";
            this.textBoxNroSolicitud.Size = new System.Drawing.Size(260, 22);
            this.textBoxNroSolicitud.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nro de Solicitud";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tipo de Solicitud";
            // 
            // comboBoxTipoSolicitud
            // 
            this.comboBoxTipoSolicitud.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxTipoSolicitud.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTipoSolicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoSolicitud.FormattingEnabled = true;
            this.comboBoxTipoSolicitud.Items.AddRange(new object[] {
            "FORMULARIO",
            "MAIL",
            "MEMORANDO",
            "GDE",
            "NOTA",
            "SOLICITUD",
            "OFICIO"});
            this.comboBoxTipoSolicitud.Location = new System.Drawing.Point(5, 90);
            this.comboBoxTipoSolicitud.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTipoSolicitud.Name = "comboBoxTipoSolicitud";
            this.comboBoxTipoSolicitud.Size = new System.Drawing.Size(137, 24);
            this.comboBoxTipoSolicitud.TabIndex = 3;
            // 
            // textBoxNroInforme
            // 
            this.textBoxNroInforme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxNroInforme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNroInforme.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNroInforme.Location = new System.Drawing.Point(197, 306);
            this.textBoxNroInforme.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNroInforme.Name = "textBoxNroInforme";
            this.textBoxNroInforme.Size = new System.Drawing.Size(231, 22);
            this.textBoxNroInforme.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 286);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "N° de Informe";
            // 
            // textBoxObservacion
            // 
            this.textBoxObservacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxObservacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBoxObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxObservacion.Location = new System.Drawing.Point(8, 405);
            this.textBoxObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxObservacion.Multiline = true;
            this.textBoxObservacion.Name = "textBoxObservacion";
            this.textBoxObservacion.Size = new System.Drawing.Size(420, 64);
            this.textBoxObservacion.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 387);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Observación";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.Location = new System.Drawing.Point(982, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 23);
            this.label11.TabIndex = 26;
            this.label11.Text = "Registros";
            // 
            // comboBoxSolicitante
            // 
            this.comboBoxSolicitante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSolicitante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSolicitante.FormattingEnabled = true;
            this.comboBoxSolicitante.Items.AddRange(new object[] {
            "AA2000",
            "BAHIA BLANCA",
            "BARILOCHE",
            "CATAMARCA",
            "COMODORO RIVADAVIA",
            "CORDOBA",
            "CORRIENTES",
            "DGA",
            "DGM",
            "EL CALAFATE",
            "ESQUEL",
            "EZEIZA",
            "GNA",
            "IGUAZU",
            "INTERCARGO",
            "DRICA",
            "JUJUY ",
            "LA PAMPA",
            "LA RIOJA",
            "MALAGUE",
            "MAR DEL PLATA",
            "MENDOZA",
            "METROPOLITANA",
            "NEUQUEN",
            "PALOMAR",
            "PARANA",
            "PASO DE LOS LIBRES",
            "PBA",
            "PFA",
            "PNA",
            "POLICIA DE LA CIUDAD",
            "POSADAS",
            "PUERTO MADRIN",
            "RESISTENCIA",
            "RIO GALLEGOS",
            "RIO GRANDE",
            "ROSARIO",
            "SALTA",
            "SAN FERNANDO",
            "SAN JUAN",
            "SAN LUIS",
            "SAN MARTIN DE LOS ANDES",
            "SAN RAFAEL",
            "SANIDAD",
            "SANTIAGO DEL ESTERO",
            "SAUCE VIEJO",
            "SENASA",
            "TCA",
            "TERMINALES DE RIO HONDO",
            "TREWLEW",
            "TUCUMAN",
            "USHUAIA",
            "VIEDMA ",
            "DROPA",
            "CRAC",
            "DRICA",
            "COMPLEJA CENTRAL",
            "COMPLEJA URSA I DEL ESTE",
            "JUZGADO FEDERAL NRO.01",
            "JUZGADO FEDERAL NRO.02",
            "ADUANA",
            "FISCALIA FEDERAL NRO.02",
            "CEAC-UOA",
            "UNIDAD FISCAL NORTE",
            "UNIDAD FUNCIONAL INT NRO. 04",
            "ODT",
            "JUZGADO EN LO CRIMINAL Y CORRECCIONAL N° 53",
            "FISCALIA FEDERAL NRO.01",
            "FISCALIA EN LO CRIMINAL Y CORRECCIONAL N° 8",
            "FISCALIA EN LO CRIMINAL Y CORRECCIONAL N° 7",
            "UFI NRO.01",
            "MINISTERIO DE SEGURIDAD DE LA NACION",
            "FISCALIA EN LO CRIMINAL Y CORRECCIONAL N° 53",
            "JUZGADO NACIONAL EN LO CRIMINAL Y CORRECIONAL N° 48 ",
            "FISCALIA EN LO CRIMINIAL Y CORRECCIONAL N° 19",
            "UNIDAD FUNCIONAL INT Y JUICIO N° 9 LA MATANZA",
            "FISCALIA EN LO CRIMINIAL Y CORRECCIONAL FEDERAL N°2 SAN ISIDRO",
            "FISCALIA NACIONAL EN LO PENAL ECONOMICO  N° 4",
            "JUZGADO NACIONAL EN LO PENAL ECONOMICO N°2"});
            this.comboBoxSolicitante.Location = new System.Drawing.Point(4, 252);
            this.comboBoxSolicitante.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSolicitante.Name = "comboBoxSolicitante";
            this.comboBoxSolicitante.Size = new System.Drawing.Size(438, 24);
            this.comboBoxSolicitante.TabIndex = 5;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(223, 688);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(94, 38);
            this.buttonLimpiar.TabIndex = 28;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // textBoxCausa_Prevencion
            // 
            this.textBoxCausa_Prevencion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCausa_Prevencion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCausa_Prevencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCausa_Prevencion.Location = new System.Drawing.Point(210, 145);
            this.textBoxCausa_Prevencion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCausa_Prevencion.Name = "textBoxCausa_Prevencion";
            this.textBoxCausa_Prevencion.Size = new System.Drawing.Size(226, 22);
            this.textBoxCausa_Prevencion.TabIndex = 6;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.Yellow;
            this.buttonActualizar.Enabled = false;
            this.buttonActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.Location = new System.Drawing.Point(168, 642);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(108, 38);
            this.buttonActualizar.TabIndex = 32;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // numericUpDownOrden
            // 
            this.numericUpDownOrden.Location = new System.Drawing.Point(197, 35);
            this.numericUpDownOrden.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownOrden.Name = "numericUpDownOrden";
            this.numericUpDownOrden.Size = new System.Drawing.Size(69, 22);
            this.numericUpDownOrden.TabIndex = 33;
            this.numericUpDownOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(197, 13);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "Nro Orden";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(210, 123);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(225, 16);
            this.label14.TabIndex = 35;
            this.label14.Text = "N° de Causa Judicial / Prev. Sumaria";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 178);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 16);
            this.label15.TabIndex = 37;
            this.label15.Text = "Caratula";
            // 
            // textBoxCaratula
            // 
            this.textBoxCaratula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCaratula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCaratula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCaratula.Location = new System.Drawing.Point(4, 197);
            this.textBoxCaratula.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCaratula.Name = "textBoxCaratula";
            this.textBoxCaratula.Size = new System.Drawing.Size(248, 22);
            this.textBoxCaratula.TabIndex = 36;
            // 
            // comboBoxTipoDelito
            // 
            this.comboBoxTipoDelito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxTipoDelito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTipoDelito.FormattingEnabled = true;
            this.comboBoxTipoDelito.Location = new System.Drawing.Point(269, 195);
            this.comboBoxTipoDelito.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTipoDelito.Name = "comboBoxTipoDelito";
            this.comboBoxTipoDelito.Size = new System.Drawing.Size(167, 24);
            this.comboBoxTipoDelito.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(267, 175);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Tipo de Delito";
            // 
            // comboBoxDependencia
            // 
            this.comboBoxDependencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxDependencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDependencia.FormattingEnabled = true;
            this.comboBoxDependencia.Items.AddRange(new object[] {
            "COC AER",
            "COC EZE",
            "CREV",
            "COC SFO",
            "COC EPA",
            "COC MDP",
            "COC BHI",
            "N/C"});
            this.comboBoxDependencia.Location = new System.Drawing.Point(7, 306);
            this.comboBoxDependencia.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDependencia.Name = "comboBoxDependencia";
            this.comboBoxDependencia.Size = new System.Drawing.Size(175, 24);
            this.comboBoxDependencia.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 286);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(178, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "Dependencia Interveniniente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "N° de DVD";
            // 
            // textBoxNroDvd
            // 
            this.textBoxNroDvd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxNroDvd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNroDvd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNroDvd.Location = new System.Drawing.Point(4, 145);
            this.textBoxNroDvd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNroDvd.Name = "textBoxNroDvd";
            this.textBoxNroDvd.Size = new System.Drawing.Size(198, 22);
            this.textBoxNroDvd.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "N° de Acta / Elevacion ";
            // 
            // textBoxNroActa_elevacion
            // 
            this.textBoxNroActa_elevacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxNroActa_elevacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNroActa_elevacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNroActa_elevacion.Location = new System.Drawing.Point(199, 37);
            this.textBoxNroActa_elevacion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNroActa_elevacion.Name = "textBoxNroActa_elevacion";
            this.textBoxNroActa_elevacion.Size = new System.Drawing.Size(229, 22);
            this.textBoxNroActa_elevacion.TabIndex = 44;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 17);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 16);
            this.label17.TabIndex = 47;
            this.label17.Text = "Fecha Salida";
            // 
            // dateTimePickerFechaSalida
            // 
            this.dateTimePickerFechaSalida.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaSalida.Location = new System.Drawing.Point(10, 35);
            this.dateTimePickerFechaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaSalida.Name = "dateTimePickerFechaSalida";
            this.dateTimePickerFechaSalida.Size = new System.Drawing.Size(162, 22);
            this.dateTimePickerFechaSalida.TabIndex = 46;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 73);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 16);
            this.label18.TabIndex = 49;
            this.label18.Text = "Retirado por";
            // 
            // textBoxRetirado
            // 
            this.textBoxRetirado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxRetirado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxRetirado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxRetirado.Location = new System.Drawing.Point(6, 93);
            this.textBoxRetirado.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRetirado.Name = "textBoxRetirado";
            this.textBoxRetirado.Size = new System.Drawing.Size(187, 22);
            this.textBoxRetirado.TabIndex = 48;
            // 
            // comboBoxOrganismo
            // 
            this.comboBoxOrganismo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxOrganismo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxOrganismo.FormattingEnabled = true;
            this.comboBoxOrganismo.Items.AddRange(new object[] {
            "PSA",
            "UOCN Y DC I",
            "PROCUNAR-PFA",
            "PFA",
            "AFIP",
            "CONTROL POLICIAL",
            "FISCALIA FEDERAL N° 2"});
            this.comboBoxOrganismo.Location = new System.Drawing.Point(203, 91);
            this.comboBoxOrganismo.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOrganismo.Name = "comboBoxOrganismo";
            this.comboBoxOrganismo.Size = new System.Drawing.Size(225, 24);
            this.comboBoxOrganismo.TabIndex = 50;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(200, 71);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 16);
            this.label19.TabIndex = 51;
            this.label19.Text = "Organismo";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "FINALIZADO",
            "INICIADO",
            "ESPERA DE REGISTRO EXTERNO",
            "ENTREGADO",
            "PENDIENTE"});
            this.comboBoxEstado.Location = new System.Drawing.Point(200, 354);
            this.comboBoxEstado.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(180, 24);
            this.comboBoxEstado.TabIndex = 52;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(197, 334);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 16);
            this.label20.TabIndex = 53;
            this.label20.Text = "Estado";
            // 
            // textBoxNroAsunto
            // 
            this.textBoxNroAsunto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxNroAsunto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNroAsunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNroAsunto.Location = new System.Drawing.Point(6, 34);
            this.textBoxNroAsunto.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNroAsunto.Name = "textBoxNroAsunto";
            this.textBoxNroAsunto.Size = new System.Drawing.Size(183, 22);
            this.textBoxNroAsunto.TabIndex = 54;
            // 
            // groupBoxEntrega
            // 
            this.groupBoxEntrega.Controls.Add(this.textBoxRetirado);
            this.groupBoxEntrega.Controls.Add(this.label9);
            this.groupBoxEntrega.Controls.Add(this.label18);
            this.groupBoxEntrega.Controls.Add(this.textBoxNroActa_elevacion);
            this.groupBoxEntrega.Controls.Add(this.comboBoxOrganismo);
            this.groupBoxEntrega.Controls.Add(this.label19);
            this.groupBoxEntrega.Controls.Add(this.dateTimePickerFechaSalida);
            this.groupBoxEntrega.Controls.Add(this.label17);
            this.groupBoxEntrega.Enabled = false;
            this.groupBoxEntrega.Location = new System.Drawing.Point(8, 498);
            this.groupBoxEntrega.Name = "groupBoxEntrega";
            this.groupBoxEntrega.Size = new System.Drawing.Size(435, 131);
            this.groupBoxEntrega.TabIndex = 55;
            this.groupBoxEntrega.TabStop = false;
            // 
            // checkBoxEntrega
            // 
            this.checkBoxEntrega.AutoSize = true;
            this.checkBoxEntrega.Location = new System.Drawing.Point(13, 478);
            this.checkBoxEntrega.Name = "checkBoxEntrega";
            this.checkBoxEntrega.Size = new System.Drawing.Size(76, 20);
            this.checkBoxEntrega.TabIndex = 56;
            this.checkBoxEntrega.Text = "Entrega";
            this.checkBoxEntrega.UseVisualStyleBackColor = true;
            this.checkBoxEntrega.CheckedChanged += new System.EventHandler(this.checkBoxEntrega_CheckedChanged);
            // 
            // Form_Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1751, 757);
            this.Controls.Add(this.checkBoxEntrega);
            this.Controls.Add(this.groupBoxEntrega);
            this.Controls.Add(this.textBoxNroAsunto);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNroDvd);
            this.Controls.Add(this.comboBoxDependencia);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboBoxTipoDelito);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxCaratula);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numericUpDownOrden);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.textBoxCausa_Prevencion);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.comboBoxSolicitante);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxObservacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxNroInforme);
            this.Controls.Add(this.comboBoxTipoSolicitud);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNroSolicitud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerFechaRegistro);
            this.Controls.Add(this.dgvInformes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.dateTimePickerFechaIngreso);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonRegistrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form_Informes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_BackUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrden)).EndInit();
            this.groupBoxEntrega.ResumeLayout(false);
            this.groupBoxEntrega.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonRegistrar;
        private Button buttonEliminar;
        private DateTimePicker dateTimePickerFechaIngreso;
        private Button buttonBuscar;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvInformes;
        private DateTimePicker dateTimePickerFechaRegistro;
        private Label label4;
        private TextBox textBoxNroSolicitud;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxTipoSolicitud;
        private TextBox textBoxNroInforme;
        private Label label8;
        private TextBox textBoxObservacion;
        private Label label10;
        private Label label11;
        private ComboBox comboBoxSolicitante;
        private Button buttonLimpiar;
        private TextBox textBoxCausa_Prevencion;
        private Button buttonActualizar;
        private NumericUpDown numericUpDownOrden;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox textBoxCaratula;
        private ComboBox comboBoxTipoDelito;
        private Label label12;
        private ComboBox comboBoxDependencia;
        private Label label16;
        private Label label7;
        private TextBox textBoxNroDvd;
        private Label label9;
        private TextBox textBoxNroActa_elevacion;
        private Label label17;
        private DateTimePicker dateTimePickerFechaSalida;
        private Label label18;
        private TextBox textBoxRetirado;
        private ComboBox comboBoxOrganismo;
        private Label label19;
        private ComboBox comboBoxEstado;
        private Label label20;
        private TextBox textBoxNroAsunto;
        private GroupBox groupBoxEntrega;
        private CheckBox checkBoxEntrega;
    }
}