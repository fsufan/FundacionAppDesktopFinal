namespace AplicacionDesktop.CRUDUsuario
{
    partial class IngresarUsuario
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
            this.lblRut = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.txtrut = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.dtingresou = new System.Windows.Forms.DataGridView();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtrpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxidrol = new System.Windows.Forms.ComboBox();
            this.lblir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtingresou)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(39, 99);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(38, 20);
            this.lblRut.TabIndex = 1;
            this.lblRut.Text = "Rut";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(39, 170);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(107, 20);
            this.lblc.TabIndex = 2;
            this.lblc.Text = "Contraseña ";
            // 
            // txtrut
            // 
            this.txtrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrut.Location = new System.Drawing.Point(251, 92);
            this.txtrut.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtrut.Name = "txtrut";
            this.txtrut.Size = new System.Drawing.Size(200, 20);
            this.txtrut.TabIndex = 9;
            this.txtrut.TextChanged += new System.EventHandler(this.txtrut_TextChanged);
            this.txtrut.Validating += new System.ComponentModel.CancelEventHandler(this.txtrut_Validating);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtContraseña.Location = new System.Drawing.Point(251, 170);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(200, 20);
            this.txtContraseña.TabIndex = 10;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.txtContraseña_Validating);
            // 
            // dtingresou
            // 
            this.dtingresou.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtingresou.Location = new System.Drawing.Point(10, 245);
            this.dtingresou.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtingresou.Name = "dtingresou";
            this.dtingresou.Size = new System.Drawing.Size(734, 243);
            this.dtingresou.TabIndex = 18;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(601, 180);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(88, 43);
            this.btnIngresar.TabIndex = 19;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Location = new System.Drawing.Point(649, 498);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(76, 26);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(310, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ingresar Usuario";
            // 
            // txtrpass
            // 
            this.txtrpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtrpass.Location = new System.Drawing.Point(251, 203);
            this.txtrpass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtrpass.Name = "txtrpass";
            this.txtrpass.Size = new System.Drawing.Size(200, 20);
            this.txtrpass.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Repita la Contraseña ";
            // 
            // cmbxidrol
            // 
            this.cmbxidrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbxidrol.FormattingEnabled = true;
            this.cmbxidrol.Location = new System.Drawing.Point(251, 130);
            this.cmbxidrol.Name = "cmbxidrol";
            this.cmbxidrol.Size = new System.Drawing.Size(200, 21);
            this.cmbxidrol.TabIndex = 26;
            // 
            // lblir
            // 
            this.lblir.AutoSize = true;
            this.lblir.Location = new System.Drawing.Point(39, 131);
            this.lblir.Name = "lblir";
            this.lblir.Size = new System.Drawing.Size(103, 20);
            this.lblir.TabIndex = 25;
            this.lblir.Text = "Nombre Rol";
            // 
            // IngresarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(749, 525);
            this.Controls.Add(this.cmbxidrol);
            this.Controls.Add(this.lblir);
            this.Controls.Add(this.txtrpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.dtingresou);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtrut);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.lblRut);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximumSize = new System.Drawing.Size(765, 564);
            this.Name = "IngresarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dtingresou)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.TextBox txtrut;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.DataGridView dtingresou;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtrpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxidrol;
        private System.Windows.Forms.Label lblir;
    }
}