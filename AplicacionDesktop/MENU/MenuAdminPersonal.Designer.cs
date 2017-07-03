namespace AplicacionDesktop.MENU
{
    partial class MenuAdminPersonal
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
            this.btnParamedico = new System.Windows.Forms.Button();
            this.btnEnfermeras = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(74, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Administrar Personal";
            // 
            // btnParamedico
            // 
            this.btnParamedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnParamedico.Location = new System.Drawing.Point(197, 141);
            this.btnParamedico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParamedico.Name = "btnParamedico";
            this.btnParamedico.Size = new System.Drawing.Size(126, 37);
            this.btnParamedico.TabIndex = 27;
            this.btnParamedico.Text = "Paramedicos";
            this.btnParamedico.UseVisualStyleBackColor = true;
            this.btnParamedico.Click += new System.EventHandler(this.btnParamedico_Click);
            // 
            // btnEnfermeras
            // 
            this.btnEnfermeras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEnfermeras.Location = new System.Drawing.Point(32, 141);
            this.btnEnfermeras.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnEnfermeras.Name = "btnEnfermeras";
            this.btnEnfermeras.Size = new System.Drawing.Size(126, 37);
            this.btnEnfermeras.TabIndex = 26;
            this.btnEnfermeras.Text = "Enfermeras";
            this.btnEnfermeras.UseVisualStyleBackColor = true;
            this.btnEnfermeras.Click += new System.EventHandler(this.btnEnfermeras_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(249, 271);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 30);
            this.btnVolver.TabIndex = 28;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // MenuAdminPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(354, 318);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnParamedico);
            this.Controls.Add(this.btnEnfermeras);
            this.Controls.Add(this.label1);
            this.Name = "MenuAdminPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdminPersonal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParamedico;
        private System.Windows.Forms.Button btnEnfermeras;
        private System.Windows.Forms.Button btnVolver;

    }
}