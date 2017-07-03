namespace AplicacionDesktop.MENU
{
    partial class MenuAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdminu = new System.Windows.Forms.Button();
            this.btnAdminR = new System.Windows.Forms.Button();
            this.btnAdminP = new System.Windows.Forms.Button();
            this.btnAdminm = new System.Windows.Forms.Button();
            this.btnCerrarAdmin = new System.Windows.Forms.Button();
            this.btnRol = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnAdministarP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(131, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido Administrador";
            // 
            // btnAdminu
            // 
            this.btnAdminu.Location = new System.Drawing.Point(89, 116);
            this.btnAdminu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdminu.Name = "btnAdminu";
            this.btnAdminu.Size = new System.Drawing.Size(144, 51);
            this.btnAdminu.TabIndex = 1;
            this.btnAdminu.Text = "Administrar Usuarios";
            this.btnAdminu.UseVisualStyleBackColor = true;
            this.btnAdminu.Click += new System.EventHandler(this.btnAdminu_Click);
            // 
            // btnAdminR
            // 
            this.btnAdminR.Location = new System.Drawing.Point(267, 116);
            this.btnAdminR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdminR.Name = "btnAdminR";
            this.btnAdminR.Size = new System.Drawing.Size(144, 51);
            this.btnAdminR.TabIndex = 2;
            this.btnAdminR.Text = "Administrar Residentes";
            this.btnAdminR.UseVisualStyleBackColor = true;
            this.btnAdminR.Click += new System.EventHandler(this.btnAdminR_Click);
            // 
            // btnAdminP
            // 
            this.btnAdminP.Location = new System.Drawing.Point(89, 261);
            this.btnAdminP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdminP.Name = "btnAdminP";
            this.btnAdminP.Size = new System.Drawing.Size(144, 55);
            this.btnAdminP.TabIndex = 3;
            this.btnAdminP.Text = "Administrar Productos";
            this.btnAdminP.UseVisualStyleBackColor = true;
            this.btnAdminP.Click += new System.EventHandler(this.btnAdminP_Click);
            // 
            // btnAdminm
            // 
            this.btnAdminm.Location = new System.Drawing.Point(267, 187);
            this.btnAdminm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdminm.Name = "btnAdminm";
            this.btnAdminm.Size = new System.Drawing.Size(144, 51);
            this.btnAdminm.TabIndex = 4;
            this.btnAdminm.Text = "Administrar Medicamentos";
            this.btnAdminm.UseVisualStyleBackColor = true;
            this.btnAdminm.Click += new System.EventHandler(this.btnAdminm_Click);
            // 
            // btnCerrarAdmin
            // 
            this.btnCerrarAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarAdmin.Location = new System.Drawing.Point(183, 395);
            this.btnCerrarAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarAdmin.Name = "btnCerrarAdmin";
            this.btnCerrarAdmin.Size = new System.Drawing.Size(139, 27);
            this.btnCerrarAdmin.TabIndex = 5;
            this.btnCerrarAdmin.Text = "Cerrar Sesion";
            this.btnCerrarAdmin.UseVisualStyleBackColor = true;
            this.btnCerrarAdmin.Click += new System.EventHandler(this.btnCerrarAdmin_Click);
            // 
            // btnRol
            // 
            this.btnRol.Location = new System.Drawing.Point(89, 187);
            this.btnRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(144, 51);
            this.btnRol.TabIndex = 6;
            this.btnRol.Text = "Administrar Rol";
            this.btnRol.UseVisualStyleBackColor = true;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(416, 445);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(0, 20);
            this.lblAdmin.TabIndex = 7;
            // 
            // btnAdministarP
            // 
            this.btnAdministarP.Location = new System.Drawing.Point(267, 261);
            this.btnAdministarP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdministarP.Name = "btnAdministarP";
            this.btnAdministarP.Size = new System.Drawing.Size(144, 55);
            this.btnAdministarP.TabIndex = 8;
            this.btnAdministarP.Text = "Administrar Personal";
            this.btnAdministarP.UseVisualStyleBackColor = true;
            this.btnAdministarP.Click += new System.EventHandler(this.btnAdministarP_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(485, 474);
            this.Controls.Add(this.btnAdministarP);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnRol);
            this.Controls.Add(this.btnCerrarAdmin);
            this.Controls.Add(this.btnAdminm);
            this.Controls.Add(this.btnAdminP);
            this.Controls.Add(this.btnAdminR);
            this.Controls.Add(this.btnAdminu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(501, 512);
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdminu;
        private System.Windows.Forms.Button btnAdminR;
        private System.Windows.Forms.Button btnAdminP;
        private System.Windows.Forms.Button btnAdminm;
        private System.Windows.Forms.Button btnCerrarAdmin;
        private System.Windows.Forms.Button btnRol;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnAdministarP;
    }
}