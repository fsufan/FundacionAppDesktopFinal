namespace AplicacionDesktop.MENU
{
    partial class MenuEnfermera
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGestionarParame = new System.Windows.Forms.Button();
            this.btnFicP = new System.Windows.Forms.Button();
            this.lbltit = new System.Windows.Forms.Label();
            this.lblEnf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(596, 326);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 26);
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGestionarParame
            // 
            this.btnGestionarParame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarParame.Location = new System.Drawing.Point(426, 107);
            this.btnGestionarParame.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnGestionarParame.Name = "btnGestionarParame";
            this.btnGestionarParame.Size = new System.Drawing.Size(191, 61);
            this.btnGestionarParame.TabIndex = 22;
            this.btnGestionarParame.Text = "Gestionar Solicitud de Medicamentos";
            this.btnGestionarParame.UseVisualStyleBackColor = true;
            this.btnGestionarParame.Click += new System.EventHandler(this.btnGestionarParame_Click);
            // 
            // btnFicP
            // 
            this.btnFicP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFicP.Location = new System.Drawing.Point(124, 107);
            this.btnFicP.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnFicP.Name = "btnFicP";
            this.btnFicP.Size = new System.Drawing.Size(178, 61);
            this.btnFicP.TabIndex = 21;
            this.btnFicP.Text = "Gestionar Fichas de Residentes";
            this.btnFicP.UseVisualStyleBackColor = true;
            this.btnFicP.Click += new System.EventHandler(this.btnFicP_Click);
            // 
            // lbltit
            // 
            this.lbltit.AutoSize = true;
            this.lbltit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltit.ForeColor = System.Drawing.Color.Green;
            this.lbltit.Location = new System.Drawing.Point(241, 9);
            this.lbltit.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lbltit.Name = "lbltit";
            this.lbltit.Size = new System.Drawing.Size(226, 24);
            this.lbltit.TabIndex = 20;
            this.lbltit.Text = "Menu Personal Medico";
            // 
            // lblEnf
            // 
            this.lblEnf.AutoSize = true;
            this.lblEnf.Location = new System.Drawing.Point(-1, 339);
            this.lblEnf.Name = "lblEnf";
            this.lblEnf.Size = new System.Drawing.Size(0, 13);
            this.lblEnf.TabIndex = 24;
            // 
            // MenuEnfermera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(719, 352);
            this.Controls.Add(this.lblEnf);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGestionarParame);
            this.Controls.Add(this.btnFicP);
            this.Controls.Add(this.lbltit);
            this.Name = "MenuEnfermera";
            this.Text = "MenuEnfermera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGestionarParame;
        private System.Windows.Forms.Button btnFicP;
        private System.Windows.Forms.Label lbltit;
        private System.Windows.Forms.Label lblEnf;
    }
}