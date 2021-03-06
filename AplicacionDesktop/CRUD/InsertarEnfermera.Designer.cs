﻿namespace AplicacionDesktop.CRUD
{
    partial class InsertarEnfermera
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboComuna = new System.Windows.Forms.ComboBox();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblComuna = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblRutR = new System.Windows.Forms.Label();
            this.DateFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApP = new System.Windows.Forms.Label();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.lblApM = new System.Windows.Forms.Label();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.lblFN = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DateFechIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboComuna);
            this.groupBox2.Controls.Add(this.cboRegion);
            this.groupBox2.Controls.Add(this.txtCodigoP);
            this.groupBox2.Controls.Add(this.txtCiudad);
            this.groupBox2.Controls.Add(this.txtCalle);
            this.groupBox2.Controls.Add(this.lblCodigoPostal);
            this.groupBox2.Controls.Add(this.lblRegion);
            this.groupBox2.Controls.Add(this.lblCiudad);
            this.groupBox2.Controls.Add(this.lblComuna);
            this.groupBox2.Controls.Add(this.lblCalle);
            this.groupBox2.Location = new System.Drawing.Point(12, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 199);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Direccion";
            // 
            // cboComuna
            // 
            this.cboComuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComuna.FormattingEnabled = true;
            this.cboComuna.Location = new System.Drawing.Point(128, 53);
            this.cboComuna.Name = "cboComuna";
            this.cboComuna.Size = new System.Drawing.Size(159, 21);
            this.cboComuna.TabIndex = 11;
            // 
            // cboRegion
            // 
            this.cboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(128, 22);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(159, 21);
            this.cboRegion.TabIndex = 10;
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Location = new System.Drawing.Point(128, 158);
            this.txtCodigoP.MaxLength = 38;
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.Size = new System.Drawing.Size(159, 20);
            this.txtCodigoP.TabIndex = 9;
            this.txtCodigoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoP_KeyPress);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(129, 88);
            this.txtCiudad.MaxLength = 100;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(158, 20);
            this.txtCiudad.TabIndex = 7;
            this.txtCiudad.Validating += new System.ComponentModel.CancelEventHandler(this.txtCiudad_Validating);
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(128, 124);
            this.txtCalle.MaxLength = 100;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(159, 20);
            this.txtCalle.TabIndex = 5;
            this.txtCalle.Validating += new System.ComponentModel.CancelEventHandler(this.txtCalle_Validating);
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(8, 158);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(72, 13);
            this.lblCodigoPostal.TabIndex = 4;
            this.lblCodigoPostal.Text = "Codigo Postal";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(8, 25);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 3;
            this.lblRegion.Text = "Region";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(8, 91);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 2;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblComuna
            // 
            this.lblComuna.AutoSize = true;
            this.lblComuna.Location = new System.Drawing.Point(8, 59);
            this.lblComuna.Name = "lblComuna";
            this.lblComuna.Size = new System.Drawing.Size(46, 13);
            this.lblComuna.TabIndex = 1;
            this.lblComuna.Text = "Comuna";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(8, 124);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 0;
            this.lblCalle.Text = "Calle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblRutR);
            this.groupBox1.Controls.Add(this.DateFechaNac);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblApP);
            this.groupBox1.Controls.Add(this.txtApePaterno);
            this.groupBox1.Controls.Add(this.lblApM);
            this.groupBox1.Controls.Add(this.txtApeMaterno);
            this.groupBox1.Controls.Add(this.lblFN);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 248);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Personal";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(139, 216);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 20);
            this.txtEmail.TabIndex = 56;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(139, 186);
            this.txtTelefono.MaxLength = 38;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(177, 20);
            this.txtTelefono.TabIndex = 55;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoP_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(8, 216);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 54;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(7, 186);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 53;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblRutR
            // 
            this.lblRutR.AutoSize = true;
            this.lblRutR.Location = new System.Drawing.Point(7, 30);
            this.lblRutR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRutR.Name = "lblRutR";
            this.lblRutR.Size = new System.Drawing.Size(24, 13);
            this.lblRutR.TabIndex = 23;
            this.lblRutR.Text = "Rut";
            // 
            // DateFechaNac
            // 
            this.DateFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFechaNac.Location = new System.Drawing.Point(140, 153);
            this.DateFechaNac.Name = "DateFechaNac";
            this.DateFechaNac.Size = new System.Drawing.Size(177, 20);
            this.DateFechaNac.TabIndex = 52;
            this.DateFechaNac.Value = new System.DateTime(2017, 6, 13, 1, 31, 13, 0);
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(139, 27);
            this.txtRut.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtRut.MaxLength = 10;
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(179, 20);
            this.txtRut.TabIndex = 31;
            this.txtRut.Validating += new System.ComponentModel.CancelEventHandler(this.txtRut_Validating);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 56);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 20);
            this.txtNombre.TabIndex = 51;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 61);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApP
            // 
            this.lblApP.AutoSize = true;
            this.lblApP.Location = new System.Drawing.Point(7, 92);
            this.lblApP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApP.Name = "lblApP";
            this.lblApP.Size = new System.Drawing.Size(84, 13);
            this.lblApP.TabIndex = 25;
            this.lblApP.Text = "Apellido Paterno";
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.Location = new System.Drawing.Point(139, 87);
            this.txtApePaterno.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtApePaterno.MaxLength = 50;
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(179, 20);
            this.txtApePaterno.TabIndex = 33;
            this.txtApePaterno.Validating += new System.ComponentModel.CancelEventHandler(this.txtApePaterno_Validating);
            // 
            // lblApM
            // 
            this.lblApM.AutoSize = true;
            this.lblApM.Location = new System.Drawing.Point(8, 120);
            this.lblApM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApM.Name = "lblApM";
            this.lblApM.Size = new System.Drawing.Size(83, 13);
            this.lblApM.TabIndex = 26;
            this.lblApM.Text = "ApellidoMaterno";
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.Location = new System.Drawing.Point(139, 118);
            this.txtApeMaterno.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtApeMaterno.MaxLength = 50;
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(179, 20);
            this.txtApeMaterno.TabIndex = 34;
            this.txtApeMaterno.Validating += new System.ComponentModel.CancelEventHandler(this.txtApeMaterno_Validating);
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(8, 158);
            this.lblFN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(108, 13);
            this.lblFN.TabIndex = 27;
            this.lblFN.Text = "Fecha de Nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(248, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 24);
            this.label8.TabIndex = 60;
            this.label8.Text = "Ingreso de Enfermera";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DateFechIngreso);
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Controls.Add(this.txtEspecialidad);
            this.groupBox3.Controls.Add(this.txtTurno);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(351, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 248);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Laborales";
            // 
            // DateFechIngreso
            // 
            this.DateFechIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFechIngreso.Location = new System.Drawing.Point(94, 177);
            this.DateFechIngreso.Name = "DateFechIngreso";
            this.DateFechIngreso.Size = new System.Drawing.Size(179, 20);
            this.DateFechIngreso.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(94, 131);
            this.txtDescripcion.MaxLength = 150;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(179, 20);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescripcion_Validating);
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(94, 74);
            this.txtEspecialidad.MaxLength = 100;
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(179, 20);
            this.txtEspecialidad.TabIndex = 5;
            this.txtEspecialidad.Validating += new System.ComponentModel.CancelEventHandler(this.txtEspecialidad_Validating);
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(94, 27);
            this.txtTurno.MaxLength = 25;
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(179, 20);
            this.txtTurno.TabIndex = 4;
            this.txtTurno.Validating += new System.ComponentModel.CancelEventHandler(this.txtTurno_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Especialidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turno";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtContraseña);
            this.groupBox4.Controls.Add(this.cboRol);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(351, 327);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 149);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(86, 104);
            this.txtContraseña.MaxLength = 100;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(149, 20);
            this.txtContraseña.TabIndex = 7;
            this.txtContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.txtContraseña_Validating);
            // 
            // cboRol
            // 
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(74, 38);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(121, 21);
            this.cboRol.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo Rol";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(173, 523);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(101, 41);
            this.btnIngresar.TabIndex = 63;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(534, 523);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(78, 41);
            this.btnVolver.TabIndex = 64;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // InsertarEnfermera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 576);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(662, 615);
            this.Name = "InsertarEnfermera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertarEnfermera";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboComuna;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.TextBox txtCodigoP;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblComuna;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblRutR;
        private System.Windows.Forms.DateTimePicker DateFechaNac;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApP;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.Label lblApM;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker DateFechIngreso;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnVolver;
    }
}