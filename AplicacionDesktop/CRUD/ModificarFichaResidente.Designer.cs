namespace AplicacionDesktop.CRUD
{
    partial class ModificarFichaResidente
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
            this.cboRut = new System.Windows.Forms.ComboBox();
            this.lblRut = new System.Windows.Forms.Label();
            this.rtxtComentarios = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFechaInsc = new System.Windows.Forms.DateTimePicker();
            this.rtxtSituacionM = new System.Windows.Forms.RichTextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtidfresidente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblidFicha = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.AgregarNuevoHistorial = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtTrataEspe = new System.Windows.Forms.RichTextBox();
            this.rtxtEnfermedades = new System.Windows.Forms.RichTextBox();
            this.rtxtAlergias = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombreR = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(313, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 24);
            this.label8.TabIndex = 167;
            this.label8.Text = "Modificar Ficha de Residente";
            // 
            // cboRut
            // 
            this.cboRut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRut.FormattingEnabled = true;
            this.cboRut.Location = new System.Drawing.Point(80, 22);
            this.cboRut.Name = "cboRut";
            this.cboRut.Size = new System.Drawing.Size(121, 21);
            this.cboRut.TabIndex = 168;
            this.cboRut.SelectionChangeCommitted += new System.EventHandler(this.cboRut_SelectionChangeCommitted);
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(31, 25);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(24, 13);
            this.lblRut.TabIndex = 169;
            this.lblRut.Text = "Rut";
            // 
            // rtxtComentarios
            // 
            this.rtxtComentarios.Location = new System.Drawing.Point(238, 96);
            this.rtxtComentarios.MaxLength = 250;
            this.rtxtComentarios.Name = "rtxtComentarios";
            this.rtxtComentarios.Size = new System.Drawing.Size(194, 91);
            this.rtxtComentarios.TabIndex = 170;
            this.rtxtComentarios.Text = "";
            this.rtxtComentarios.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtComentarios_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 171;
            this.label1.Text = "Situacion Medica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 172;
            this.label2.Text = "Fecha de Inscripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 173;
            this.label3.Text = "Comentarios";
            // 
            // dateFechaInsc
            // 
            this.dateFechaInsc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaInsc.Location = new System.Drawing.Point(163, 37);
            this.dateFechaInsc.Name = "dateFechaInsc";
            this.dateFechaInsc.Size = new System.Drawing.Size(124, 20);
            this.dateFechaInsc.TabIndex = 174;
            // 
            // rtxtSituacionM
            // 
            this.rtxtSituacionM.Location = new System.Drawing.Point(38, 96);
            this.rtxtSituacionM.MaxLength = 50;
            this.rtxtSituacionM.Name = "rtxtSituacionM";
            this.rtxtSituacionM.Size = new System.Drawing.Size(194, 91);
            this.rtxtSituacionM.TabIndex = 175;
            this.rtxtSituacionM.Text = "";
            this.rtxtSituacionM.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtSituacionM_Validating);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(98, 200);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 32);
            this.btnModificar.TabIndex = 176;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(849, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 177;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 150);
            this.dataGridView1.TabIndex = 178;
            // 
            // txtidfresidente
            // 
            this.txtidfresidente.Location = new System.Drawing.Point(6, 19);
            this.txtidfresidente.Name = "txtidfresidente";
            this.txtidfresidente.Size = new System.Drawing.Size(19, 20);
            this.txtidfresidente.TabIndex = 179;
            this.txtidfresidente.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblidFicha);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.rtxtComentarios);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtxtSituacionM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateFechaInsc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(472, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 404);
            this.groupBox1.TabIndex = 180;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ficha Residente";
            // 
            // lblidFicha
            // 
            this.lblidFicha.AutoSize = true;
            this.lblidFicha.Location = new System.Drawing.Point(322, 37);
            this.lblidFicha.Name = "lblidFicha";
            this.lblidFicha.Size = new System.Drawing.Size(0, 13);
            this.lblidFicha.TabIndex = 179;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRol);
            this.groupBox2.Controls.Add(this.AgregarNuevoHistorial);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rtxtTrataEspe);
            this.groupBox2.Controls.Add(this.rtxtEnfermedades);
            this.groupBox2.Controls.Add(this.rtxtAlergias);
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 309);
            this.groupBox2.TabIndex = 181;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial Medico";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(0, 286);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(0, 13);
            this.lblRol.TabIndex = 7;
            // 
            // AgregarNuevoHistorial
            // 
            this.AgregarNuevoHistorial.Location = new System.Drawing.Point(251, 198);
            this.AgregarNuevoHistorial.Name = "AgregarNuevoHistorial";
            this.AgregarNuevoHistorial.Size = new System.Drawing.Size(128, 37);
            this.AgregarNuevoHistorial.TabIndex = 6;
            this.AgregarNuevoHistorial.Text = "Agregar Nuevo Historial";
            this.AgregarNuevoHistorial.UseVisualStyleBackColor = true;
            this.AgregarNuevoHistorial.Click += new System.EventHandler(this.AgregarNuevoHistorial_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tratamientos Especiales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alergias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enfermedades";
            // 
            // rtxtTrataEspe
            // 
            this.rtxtTrataEspe.Location = new System.Drawing.Point(6, 185);
            this.rtxtTrataEspe.MaxLength = 500;
            this.rtxtTrataEspe.Name = "rtxtTrataEspe";
            this.rtxtTrataEspe.Size = new System.Drawing.Size(198, 63);
            this.rtxtTrataEspe.TabIndex = 2;
            this.rtxtTrataEspe.Text = "";
            this.rtxtTrataEspe.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtTrataEspe_Validating);
            // 
            // rtxtEnfermedades
            // 
            this.rtxtEnfermedades.Location = new System.Drawing.Point(6, 78);
            this.rtxtEnfermedades.MaxLength = 500;
            this.rtxtEnfermedades.Name = "rtxtEnfermedades";
            this.rtxtEnfermedades.Size = new System.Drawing.Size(198, 64);
            this.rtxtEnfermedades.TabIndex = 1;
            this.rtxtEnfermedades.Text = "";
            this.rtxtEnfermedades.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtEnfermedades_Validating);
            // 
            // rtxtAlergias
            // 
            this.rtxtAlergias.Location = new System.Drawing.Point(219, 78);
            this.rtxtAlergias.MaxLength = 500;
            this.rtxtAlergias.Name = "rtxtAlergias";
            this.rtxtAlergias.Size = new System.Drawing.Size(201, 64);
            this.rtxtAlergias.TabIndex = 0;
            this.rtxtAlergias.Text = "";
            this.rtxtAlergias.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtAlergias_Validating);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblFechaNac);
            this.groupBox3.Controls.Add(this.lblApellidos);
            this.groupBox3.Controls.Add(this.lblNombreR);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtidfresidente);
            this.groupBox3.Controls.Add(this.cboRut);
            this.groupBox3.Controls.Add(this.lblRut);
            this.groupBox3.Location = new System.Drawing.Point(12, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 116);
            this.groupBox3.TabIndex = 182;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Residente";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(315, 64);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(0, 13);
            this.lblFechaNac.TabIndex = 185;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(87, 96);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(0, 13);
            this.lblApellidos.TabIndex = 184;
            // 
            // lblNombreR
            // 
            this.lblNombreR.AutoSize = true;
            this.lblNombreR.Location = new System.Drawing.Point(87, 64);
            this.lblNombreR.Name = "lblNombreR";
            this.lblNombreR.Size = new System.Drawing.Size(0, 13);
            this.lblNombreR.TabIndex = 183;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 182;
            this.label10.Text = "Fecha Nacimiento :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 181;
            this.label9.Text = "Apellidos :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 180;
            this.label7.Text = "Nombre :";
            // 
            // ModificarFichaResidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 501);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.MaximumSize = new System.Drawing.Size(952, 540);
            this.Name = "ModificarFichaResidente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarFichaResidente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboRut;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.RichTextBox rtxtComentarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFechaInsc;
        private System.Windows.Forms.RichTextBox rtxtSituacionM;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtidfresidente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxtTrataEspe;
        private System.Windows.Forms.RichTextBox rtxtEnfermedades;
        private System.Windows.Forms.RichTextBox rtxtAlergias;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AgregarNuevoHistorial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombreR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblidFicha;
        private System.Windows.Forms.Label lblRol;
    }
}