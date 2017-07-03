namespace AplicacionDesktop.MENU
{
    partial class MenuGenerarReportesG
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
            this.btnVolverF = new System.Windows.Forms.Button();
            this.btnCargosAportadores = new System.Windows.Forms.Button();
            this.btnReporteIngresos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolverF
            // 
            this.btnVolverF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverF.Location = new System.Drawing.Point(484, 377);
            this.btnVolverF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolverF.Name = "btnVolverF";
            this.btnVolverF.Size = new System.Drawing.Size(74, 24);
            this.btnVolverF.TabIndex = 17;
            this.btnVolverF.Text = "Volver";
            this.btnVolverF.UseVisualStyleBackColor = true;
            this.btnVolverF.Click += new System.EventHandler(this.btnVolverF_Click);
            // 
            // btnCargosAportadores
            // 
            this.btnCargosAportadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargosAportadores.Location = new System.Drawing.Point(71, 146);
            this.btnCargosAportadores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargosAportadores.Name = "btnCargosAportadores";
            this.btnCargosAportadores.Size = new System.Drawing.Size(170, 54);
            this.btnCargosAportadores.TabIndex = 16;
            this.btnCargosAportadores.Text = "Planilla de Cargos a Aportadores";
            this.btnCargosAportadores.UseVisualStyleBackColor = true;
            this.btnCargosAportadores.Click += new System.EventHandler(this.btnCargosAportadores_Click);
            // 
            // btnReporteIngresos
            // 
            this.btnReporteIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteIngresos.Location = new System.Drawing.Point(308, 146);
            this.btnReporteIngresos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReporteIngresos.Name = "btnReporteIngresos";
            this.btnReporteIngresos.Size = new System.Drawing.Size(170, 54);
            this.btnReporteIngresos.TabIndex = 14;
            this.btnReporteIngresos.Text = "Reporte Mensual";
            this.btnReporteIngresos.UseVisualStyleBackColor = true;
            this.btnReporteIngresos.Click += new System.EventHandler(this.btnReporteIngresos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Generar Reportes de Gestión";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(-1, 393);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(0, 13);
            this.lblRol.TabIndex = 18;
            // 
            // MenuGenerarReportesG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(564, 406);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.btnVolverF);
            this.Controls.Add(this.btnCargosAportadores);
            this.Controls.Add(this.btnReporteIngresos);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "MenuGenerarReportesG";
            this.Text = "ReportesGestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverF;
        private System.Windows.Forms.Button btnCargosAportadores;
        private System.Windows.Forms.Button btnReporteIngresos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRol;
    }
}