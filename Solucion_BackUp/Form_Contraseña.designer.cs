using Seguridad;

namespace Presentacion
{
    partial class Form_Contraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Contraseña));
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.labelUsuarios = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.pictureBoxEyeContra2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEyeContra1 = new System.Windows.Forms.PictureBox();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.textBoxContra2 = new System.Windows.Forms.TextBox();
            this.textBoxContra1 = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEyeContra2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEyeContra1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nombre Completo";
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonNuevo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.buttonNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNuevo.Location = new System.Drawing.Point(46, 397);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(83, 32);
            this.buttonNuevo.TabIndex = 46;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = false;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.Black;
            this.buttonLimpiar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimpiar.Image")));
            this.buttonLimpiar.Location = new System.Drawing.Point(259, 26);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(53, 41);
            this.buttonLimpiar.TabIndex = 45;
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "Rol";
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(55, 209);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(191, 27);
            this.comboBoxRol.TabIndex = 43;
            // 
            // labelUsuarios
            // 
            this.labelUsuarios.AutoSize = true;
            this.labelUsuarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarios.Location = new System.Drawing.Point(49, 9);
            this.labelUsuarios.Name = "labelUsuarios";
            this.labelUsuarios.Size = new System.Drawing.Size(68, 18);
            this.labelUsuarios.TabIndex = 41;
            this.labelUsuarios.Text = "Usuarios";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEliminar.Location = new System.Drawing.Point(249, 397);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(95, 32);
            this.buttonEliminar.TabIndex = 40;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(52, 35);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(191, 27);
            this.comboBoxUsuario.TabIndex = 39;
            this.comboBoxUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsuario_SelectedIndexChanged);
            // 
            // pictureBoxEyeContra2
            // 
            this.pictureBoxEyeContra2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEyeContra2.Image")));
            this.pictureBoxEyeContra2.Location = new System.Drawing.Point(268, 339);
            this.pictureBoxEyeContra2.Name = "pictureBoxEyeContra2";
            this.pictureBoxEyeContra2.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxEyeContra2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEyeContra2.TabIndex = 38;
            this.pictureBoxEyeContra2.TabStop = false;
            // 
            // pictureBoxEyeContra1
            // 
            this.pictureBoxEyeContra1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEyeContra1.Image")));
            this.pictureBoxEyeContra1.Location = new System.Drawing.Point(268, 275);
            this.pictureBoxEyeContra1.Name = "pictureBoxEyeContra1";
            this.pictureBoxEyeContra1.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxEyeContra1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEyeContra1.TabIndex = 36;
            this.pictureBoxEyeContra1.TabStop = false;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.Gold;
            this.buttonActualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonActualizar.Location = new System.Drawing.Point(135, 397);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(108, 32);
            this.buttonActualizar.TabIndex = 35;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.ButtonActualizar_Click);
            // 
            // textBoxContra2
            // 
            this.textBoxContra2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContra2.Location = new System.Drawing.Point(52, 337);
            this.textBoxContra2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContra2.Name = "textBoxContra2";
            this.textBoxContra2.Size = new System.Drawing.Size(209, 26);
            this.textBoxContra2.TabIndex = 34;
            this.textBoxContra2.UseSystemPasswordChar = true;
            // 
            // textBoxContra1
            // 
            this.textBoxContra1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContra1.Location = new System.Drawing.Point(55, 273);
            this.textBoxContra1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContra1.Name = "textBoxContra1";
            this.textBoxContra1.Size = new System.Drawing.Size(206, 26);
            this.textBoxContra1.TabIndex = 33;
            this.textBoxContra1.UseSystemPasswordChar = true;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxUsuario.Enabled = false;
            this.textBoxUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(52, 89);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(260, 26);
            this.textBoxUsuario.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nombre Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Repetir Contraseña";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Contraseña";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(52, 147);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(260, 26);
            this.textBoxNombre.TabIndex = 25;
            // 
            // Form_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(381, 435);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.textBoxContra2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelUsuarios);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxEyeContra2);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.pictureBoxEyeContra1);
            this.Controls.Add(this.textBoxContra1);
            this.Controls.Add(this.buttonActualizar);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Contraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio Contraseña";
            this.Load += new System.EventHandler(this.FormPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEyeContra2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEyeContra1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxContra2;
        private System.Windows.Forms.TextBox textBoxContra1;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.PictureBox pictureBoxEyeContra1;
        private System.Windows.Forms.PictureBox pictureBoxEyeContra2;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.Label labelUsuarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonNuevo;
    }
}