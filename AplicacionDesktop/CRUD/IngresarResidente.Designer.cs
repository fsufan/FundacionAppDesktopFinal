namespace AplicacionDesktop.CRUDUsuario
{
    partial class IngresarResidente
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
            this.label8 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblApellidoR = new System.Windows.Forms.Label();
            this.lblNombreR = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboRutResidente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupContrato = new System.Windows.Forms.GroupBox();
            this.txtCondiciones = new System.Windows.Forms.TextBox();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RtxtComentarios = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSituacionM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DatePFechaInscripcion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.RtxtTrataEspecial = new System.Windows.Forms.RichTextBox();
            this.RtxtAlergias = new System.Windows.Forms.RichTextBox();
            this.RtxtEnfermedades = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDatosResidente = new System.Windows.Forms.Button();
            this.btnDatosFamiliar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblApellidoF = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblNombreF = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboRutFamiliar = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.GroupContrato.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(280, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 24);
            this.label8.TabIndex = 43;
            this.label8.Text = "Ingreso Residente";
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(631, 553);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(68, 26);
            this.btnVolver.TabIndex = 48;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(563, 475);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(95, 47);
            this.btnIngresar.TabIndex = 50;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblApellidoR);
            this.groupBox3.Controls.Add(this.lblNombreR);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cboRutResidente);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(676, 72);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Residente";
            // 
            // lblApellidoR
            // 
            this.lblApellidoR.AutoSize = true;
            this.lblApellidoR.Location = new System.Drawing.Point(577, 33);
            this.lblApellidoR.Name = "lblApellidoR";
            this.lblApellidoR.Size = new System.Drawing.Size(0, 21);
            this.lblApellidoR.TabIndex = 83;
            // 
            // lblNombreR
            // 
            this.lblNombreR.AutoSize = true;
            this.lblNombreR.Location = new System.Drawing.Point(389, 31);
            this.lblNombreR.Name = "lblNombreR";
            this.lblNombreR.Size = new System.Drawing.Size(0, 21);
            this.lblNombreR.TabIndex = 82;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(488, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 21);
            this.label15.TabIndex = 81;
            this.label15.Text = "Apellido :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(303, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 21);
            this.label14.TabIndex = 80;
            this.label14.Text = "Nombre :";
            // 
            // cboRutResidente
            // 
            this.cboRutResidente.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboRutResidente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRutResidente.FormattingEnabled = true;
            this.cboRutResidente.Location = new System.Drawing.Point(116, 31);
            this.cboRutResidente.Name = "cboRutResidente";
            this.cboRutResidente.Size = new System.Drawing.Size(165, 29);
            this.cboRutResidente.TabIndex = 75;
            this.cboRutResidente.SelectionChangeCommitted += new System.EventHandler(this.cboRutResidente_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 74;
            this.label4.Text = "Rut";
            // 
            // GroupContrato
            // 
            this.GroupContrato.Controls.Add(this.txtCondiciones);
            this.GroupContrato.Controls.Add(this.txtCostoTotal);
            this.GroupContrato.Controls.Add(this.label5);
            this.GroupContrato.Controls.Add(this.label1);
            this.GroupContrato.Location = new System.Drawing.Point(396, 217);
            this.GroupContrato.Name = "GroupContrato";
            this.GroupContrato.Size = new System.Drawing.Size(303, 108);
            this.GroupContrato.TabIndex = 56;
            this.GroupContrato.TabStop = false;
            this.GroupContrato.Text = "Contrato";
            // 
            // txtCondiciones
            // 
            this.txtCondiciones.Location = new System.Drawing.Point(119, 26);
            this.txtCondiciones.Name = "txtCondiciones";
            this.txtCondiciones.Size = new System.Drawing.Size(167, 26);
            this.txtCondiciones.TabIndex = 4;
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Location = new System.Drawing.Point(120, 69);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.Size = new System.Drawing.Size(167, 26);
            this.txtCostoTotal.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Costo Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Condiciones";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtdescripcion);
            this.groupBox4.Controls.Add(this.txtNombreServicio);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 217);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 108);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Servicios";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(122, 64);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(240, 26);
            this.txtdescripcion.TabIndex = 5;
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Location = new System.Drawing.Point(154, 25);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(208, 26);
            this.txtNombreServicio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Servicio";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RtxtComentarios);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtSituacionM);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.DatePFechaInscripcion);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(16, 331);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(683, 126);
            this.groupBox5.TabIndex = 58;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos Ficha";
            // 
            // RtxtComentarios
            // 
            this.RtxtComentarios.Location = new System.Drawing.Point(161, 57);
            this.RtxtComentarios.MaxLength = 250;
            this.RtxtComentarios.Name = "RtxtComentarios";
            this.RtxtComentarios.Size = new System.Drawing.Size(310, 63);
            this.RtxtComentarios.TabIndex = 5;
            this.RtxtComentarios.Text = "";
            this.RtxtComentarios.Validating += new System.ComponentModel.CancelEventHandler(this.RtxtComentarios_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Comentarios";
            // 
            // txtSituacionM
            // 
            this.txtSituacionM.Location = new System.Drawing.Point(474, 26);
            this.txtSituacionM.MaxLength = 50;
            this.txtSituacionM.Name = "txtSituacionM";
            this.txtSituacionM.Size = new System.Drawing.Size(137, 26);
            this.txtSituacionM.TabIndex = 3;
            this.txtSituacionM.Validating += new System.ComponentModel.CancelEventHandler(this.txtSituacionM_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Situacion Medica";
            // 
            // DatePFechaInscripcion
            // 
            this.DatePFechaInscripcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePFechaInscripcion.Location = new System.Drawing.Point(161, 26);
            this.DatePFechaInscripcion.Name = "DatePFechaInscripcion";
            this.DatePFechaInscripcion.Size = new System.Drawing.Size(137, 26);
            this.DatePFechaInscripcion.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha Inscripcion";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.RtxtTrataEspecial);
            this.groupBox6.Controls.Add(this.RtxtAlergias);
            this.groupBox6.Controls.Add(this.RtxtEnfermedades);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Location = new System.Drawing.Point(12, 463);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(506, 116);
            this.groupBox6.TabIndex = 59;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Historial Medico";
            // 
            // RtxtTrataEspecial
            // 
            this.RtxtTrataEspecial.Location = new System.Drawing.Point(328, 49);
            this.RtxtTrataEspecial.Name = "RtxtTrataEspecial";
            this.RtxtTrataEspecial.Size = new System.Drawing.Size(160, 67);
            this.RtxtTrataEspecial.TabIndex = 5;
            this.RtxtTrataEspecial.Text = "";
            this.RtxtTrataEspecial.Validating += new System.ComponentModel.CancelEventHandler(this.RtxtTrataEspecial_Validating);
            // 
            // RtxtAlergias
            // 
            this.RtxtAlergias.Location = new System.Drawing.Point(185, 50);
            this.RtxtAlergias.Name = "RtxtAlergias";
            this.RtxtAlergias.Size = new System.Drawing.Size(127, 67);
            this.RtxtAlergias.TabIndex = 4;
            this.RtxtAlergias.Text = "";
            this.RtxtAlergias.Validating += new System.ComponentModel.CancelEventHandler(this.RtxtAlergias_Validating);
            // 
            // RtxtEnfermedades
            // 
            this.RtxtEnfermedades.Location = new System.Drawing.Point(17, 50);
            this.RtxtEnfermedades.Name = "RtxtEnfermedades";
            this.RtxtEnfermedades.Size = new System.Drawing.Size(148, 66);
            this.RtxtEnfermedades.TabIndex = 3;
            this.RtxtEnfermedades.Text = "";
            this.RtxtEnfermedades.Validating += new System.ComponentModel.CancelEventHandler(this.RtxtEnfermedades_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(326, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tratamiento Especial";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(183, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "Alergias";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Enfermedades";
            // 
            // btnDatosResidente
            // 
            this.btnDatosResidente.Location = new System.Drawing.Point(47, 12);
            this.btnDatosResidente.Name = "btnDatosResidente";
            this.btnDatosResidente.Size = new System.Drawing.Size(219, 32);
            this.btnDatosResidente.TabIndex = 60;
            this.btnDatosResidente.Text = "Ingresar Datos Personales";
            this.btnDatosResidente.UseVisualStyleBackColor = true;
            this.btnDatosResidente.Click += new System.EventHandler(this.btnDatosResidente_Click);
            // 
            // btnDatosFamiliar
            // 
            this.btnDatosFamiliar.Location = new System.Drawing.Point(481, 12);
            this.btnDatosFamiliar.Name = "btnDatosFamiliar";
            this.btnDatosFamiliar.Size = new System.Drawing.Size(161, 32);
            this.btnDatosFamiliar.TabIndex = 61;
            this.btnDatosFamiliar.Text = "Ingresar Familiar";
            this.btnDatosFamiliar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDatosFamiliar.UseVisualStyleBackColor = true;
            this.btnDatosFamiliar.Click += new System.EventHandler(this.btnDatosFamiliar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblApellidoF);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lblNombreF);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cboRutFamiliar);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 72);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Familiar";
            // 
            // lblApellidoF
            // 
            this.lblApellidoF.AutoSize = true;
            this.lblApellidoF.Location = new System.Drawing.Point(567, 33);
            this.lblApellidoF.Name = "lblApellidoF";
            this.lblApellidoF.Size = new System.Drawing.Size(0, 21);
            this.lblApellidoF.TabIndex = 83;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(494, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 21);
            this.label18.TabIndex = 82;
            this.label18.Text = "Apellido :";
            // 
            // lblNombreF
            // 
            this.lblNombreF.AutoSize = true;
            this.lblNombreF.Location = new System.Drawing.Point(383, 32);
            this.lblNombreF.Name = "lblNombreF";
            this.lblNombreF.Size = new System.Drawing.Size(0, 21);
            this.lblNombreF.TabIndex = 81;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(309, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 21);
            this.label16.TabIndex = 80;
            this.label16.Text = "Nombre :";
            // 
            // cboRutFamiliar
            // 
            this.cboRutFamiliar.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboRutFamiliar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRutFamiliar.FormattingEnabled = true;
            this.cboRutFamiliar.Location = new System.Drawing.Point(116, 31);
            this.cboRutFamiliar.Name = "cboRutFamiliar";
            this.cboRutFamiliar.Size = new System.Drawing.Size(165, 29);
            this.cboRutFamiliar.TabIndex = 75;
            this.cboRutFamiliar.SelectionChangeCommitted += new System.EventHandler(this.cboParentesco_SelectionChangeCommitted);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 21);
            this.label13.TabIndex = 74;
            this.label13.Text = "Rut";
            // 
            // IngresarResidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(711, 591);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDatosFamiliar);
            this.Controls.Add(this.btnDatosResidente);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GroupContrato);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IngresarResidente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarResidente";
            this.Load += new System.EventHandler(this.IngresarResidente_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GroupContrato.ResumeLayout(false);
            this.GroupContrato.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GroupContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCostoTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox RtxtComentarios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSituacionM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DatePFechaInscripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox RtxtTrataEspecial;
        private System.Windows.Forms.RichTextBox RtxtAlergias;
        private System.Windows.Forms.RichTextBox RtxtEnfermedades;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboRutResidente;
        private System.Windows.Forms.Button btnDatosResidente;
        private System.Windows.Forms.Button btnDatosFamiliar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboRutFamiliar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCondiciones;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label lblApellidoR;
        private System.Windows.Forms.Label lblNombreR;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblApellidoF;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblNombreF;
        private System.Windows.Forms.Label label16;
    }
}