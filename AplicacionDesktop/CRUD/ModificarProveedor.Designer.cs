namespace AplicacionDesktop.CRUD
{
    partial class ModificarProveedor
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
            this.txtCPostal = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtComuna = new System.Windows.Forms.TextBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblFF = new System.Windows.Forms.Label();
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblC = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRazonS = new System.Windows.Forms.TextBox();
            this.TipoUsuario = new System.Windows.Forms.Label();
            this.lblum = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblng = new System.Windows.Forms.Label();
            this.lblNC = new System.Windows.Forms.Label();
            this.cbxRut = new System.Windows.Forms.ComboBox();
            this.btnVolverr = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCPostal
            // 
            this.txtCPostal.Location = new System.Drawing.Point(195, 287);
            this.txtCPostal.Name = "txtCPostal";
            this.txtCPostal.Size = new System.Drawing.Size(200, 20);
            this.txtCPostal.TabIndex = 138;
            this.txtCPostal.TextChanged += new System.EventHandler(this.txtCPostal_TextChanged);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(195, 239);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(200, 20);
            this.txtCiudad.TabIndex = 137;
            this.txtCiudad.TextChanged += new System.EventHandler(this.txtCiudad_TextChanged);
            this.txtCiudad.Validating += new System.ComponentModel.CancelEventHandler(this.txtCiudad_Validating);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 398);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 188);
            this.dataGridView1.TabIndex = 136;
            // 
            // txtComuna
            // 
            this.txtComuna.Location = new System.Drawing.Point(573, 191);
            this.txtComuna.Name = "txtComuna";
            this.txtComuna.Size = new System.Drawing.Size(200, 20);
            this.txtComuna.TabIndex = 135;
            this.txtComuna.TextChanged += new System.EventHandler(this.txtComuna_TextChanged);
            this.txtComuna.Validating += new System.ComponentModel.CancelEventHandler(this.txtComuna_Validating);
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(418, 239);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(66, 20);
            this.lblDe.TabIndex = 134;
            this.lblDe.Text = "Region";
            // 
            // lblFF
            // 
            this.lblFF.AutoSize = true;
            this.lblFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFF.Location = new System.Drawing.Point(19, 287);
            this.lblFF.Name = "lblFF";
            this.lblFF.Size = new System.Drawing.Size(120, 20);
            this.lblFF.TabIndex = 133;
            this.lblFF.Text = "Código Postal";
            // 
            // cbxRegion
            // 
            this.cbxRegion.AccessibleDescription = "";
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Location = new System.Drawing.Point(573, 236);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(199, 21);
            this.cbxRegion.TabIndex = 132;
            this.cbxRegion.TextChanged += new System.EventHandler(this.cbxRegion_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(288, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 24);
            this.label8.TabIndex = 131;
            this.label8.Text = "Modificar Proveedor";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(578, 346);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 43);
            this.btnModificar.TabIndex = 130;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(418, 193);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(75, 20);
            this.lblC.TabIndex = 129;
            this.lblC.Text = "Comuna";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(197, 195);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(198, 20);
            this.txtDireccion.TabIndex = 128;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.txtDireccion_Validating);
            // 
            // txtRazonS
            // 
            this.txtRazonS.Location = new System.Drawing.Point(573, 149);
            this.txtRazonS.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtRazonS.Name = "txtRazonS";
            this.txtRazonS.Size = new System.Drawing.Size(200, 20);
            this.txtRazonS.TabIndex = 127;
            this.txtRazonS.TextChanged += new System.EventHandler(this.txtRazonS_TextChanged);
            this.txtRazonS.Validating += new System.ComponentModel.CancelEventHandler(this.txtRazonS_Validating);
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.AutoSize = true;
            this.TipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoUsuario.Location = new System.Drawing.Point(439, 191);
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.Size = new System.Drawing.Size(0, 20);
            this.TipoUsuario.TabIndex = 125;
            // 
            // lblum
            // 
            this.lblum.AutoSize = true;
            this.lblum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblum.Location = new System.Drawing.Point(19, 237);
            this.lblum.Name = "lblum";
            this.lblum.Size = new System.Drawing.Size(65, 20);
            this.lblum.TabIndex = 124;
            this.lblum.Text = "Ciudad";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenido.Location = new System.Drawing.Point(19, 193);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(84, 20);
            this.lblContenido.TabIndex = 123;
            this.lblContenido.Text = "Direccion";
            // 
            // lblng
            // 
            this.lblng.AutoSize = true;
            this.lblng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblng.Location = new System.Drawing.Point(418, 147);
            this.lblng.Name = "lblng";
            this.lblng.Size = new System.Drawing.Size(115, 20);
            this.lblng.TabIndex = 122;
            this.lblng.Text = "Razon Social";
            // 
            // lblNC
            // 
            this.lblNC.AutoSize = true;
            this.lblNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNC.Location = new System.Drawing.Point(19, 147);
            this.lblNC.Name = "lblNC";
            this.lblNC.Size = new System.Drawing.Size(38, 20);
            this.lblNC.TabIndex = 121;
            this.lblNC.Text = "Rut";
            // 
            // cbxRut
            // 
            this.cbxRut.FormattingEnabled = true;
            this.cbxRut.Location = new System.Drawing.Point(197, 147);
            this.cbxRut.Name = "cbxRut";
            this.cbxRut.Size = new System.Drawing.Size(198, 21);
            this.cbxRut.TabIndex = 139;
            this.cbxRut.SelectionChangeCommitted += new System.EventHandler(this.cbxRut_SelectionChangeCommitted);
            this.cbxRut.TextChanged += new System.EventHandler(this.cbxRut_TextChanged);
            this.cbxRut.Validating += new System.ComponentModel.CancelEventHandler(this.cbxRut_Validating);
            // 
            // btnVolverr
            // 
            this.btnVolverr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverr.Location = new System.Drawing.Point(696, 592);
            this.btnVolverr.Name = "btnVolverr";
            this.btnVolverr.Size = new System.Drawing.Size(84, 29);
            this.btnVolverr.TabIndex = 140;
            this.btnVolverr.Text = "Volver";
            this.btnVolverr.UseVisualStyleBackColor = true;
            this.btnVolverr.Click += new System.EventHandler(this.btnVolverr_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(1, 617);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(0, 13);
            this.lblRol.TabIndex = 141;
            // 
            // ModificarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(792, 629);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.btnVolverr);
            this.Controls.Add(this.cbxRut);
            this.Controls.Add(this.txtCPostal);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtComuna);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.lblFF);
            this.Controls.Add(this.cbxRegion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtRazonS);
            this.Controls.Add(this.TipoUsuario);
            this.Controls.Add(this.lblum);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblng);
            this.Controls.Add(this.lblNC);
            this.Name = "ModificarProveedor";
            this.Text = "ModificarProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCPostal;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtComuna;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblFF;
        private System.Windows.Forms.ComboBox cbxRegion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRazonS;
        private System.Windows.Forms.Label TipoUsuario;
        private System.Windows.Forms.Label lblum;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblng;
        private System.Windows.Forms.Label lblNC;
        private System.Windows.Forms.ComboBox cbxRut;
        private System.Windows.Forms.Button btnVolverr;
        private System.Windows.Forms.Label lblRol;
    }
}