namespace AplicacionDesktop.CRUDUsuario
{
    partial class ModificarUsuario
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.dtMoDU = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRut = new System.Windows.Forms.Label();
            this.cmboxRut = new System.Windows.Forms.ComboBox();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtrpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtMoDU)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(650, 195);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 38);
            this.btnModificar.TabIndex = 58;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dtMoDU
            // 
            this.dtMoDU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMoDU.Location = new System.Drawing.Point(13, 254);
            this.dtMoDU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtMoDU.Name = "dtMoDU";
            this.dtMoDU.Size = new System.Drawing.Size(789, 256);
            this.dtMoDU.TabIndex = 59;
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Location = new System.Drawing.Point(714, 520);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 35);
            this.btnVolver.TabIndex = 60;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(340, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 24);
            this.label8.TabIndex = 61;
            this.label8.Text = "Modificar Usuario";
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(47, 90);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(34, 18);
            this.lblRut.TabIndex = 62;
            this.lblRut.Text = "Rut";
            // 
            // cmboxRut
            // 
            this.cmboxRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxRut.FormattingEnabled = true;
            this.cmboxRut.Location = new System.Drawing.Point(287, 87);
            this.cmboxRut.Name = "cmboxRut";
            this.cmboxRut.Size = new System.Drawing.Size(220, 21);
            this.cmboxRut.TabIndex = 68;
            this.cmboxRut.SelectionChangeCommitted += new System.EventHandler(this.cmboxRut_SelectionChangeCommitted);
            this.cmboxRut.Validating += new System.ComponentModel.CancelEventHandler(this.cmboxRut_Validating);
            // 
            // cbxRol
            // 
            this.cbxRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Location = new System.Drawing.Point(287, 129);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(220, 21);
            this.cbxRol.TabIndex = 72;
            this.cbxRol.Validating += new System.ComponentModel.CancelEventHandler(this.cbxRol_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 71;
            this.label2.Text = "Rol";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(47, 178);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(152, 18);
            this.lblc.TabIndex = 73;
            this.lblc.Text = "Nueva Contraseña ";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtContraseña.Location = new System.Drawing.Point(287, 172);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(220, 20);
            this.txtContraseña.TabIndex = 74;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.txtContraseña_Validating);
            // 
            // txtrpass
            // 
            this.txtrpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtrpass.Location = new System.Drawing.Point(287, 209);
            this.txtrpass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtrpass.Name = "txtrpass";
            this.txtrpass.Size = new System.Drawing.Size(220, 20);
            this.txtrpass.TabIndex = 76;
            this.txtrpass.Validating += new System.ComponentModel.CancelEventHandler(this.txtrpass_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 18);
            this.label1.TabIndex = 75;
            this.label1.Text = "Repita la Nueva Contraseña ";
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(811, 562);
            this.Controls.Add(this.txtrpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.cbxRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmboxRut);
            this.Controls.Add(this.lblRut);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtMoDU);
            this.Controls.Add(this.btnModificar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ModificarUsuario";
            this.Text = "Actualizar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dtMoDU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dtMoDU;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.ComboBox cmboxRut;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtrpass;
        private System.Windows.Forms.Label label1;
    }
}