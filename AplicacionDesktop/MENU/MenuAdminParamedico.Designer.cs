namespace AplicacionDesktop.MENU
{
    partial class MenuAdminParamedico
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
            this.btnListarP = new System.Windows.Forms.Button();
            this.btnVolverP = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnModificarP = new System.Windows.Forms.Button();
            this.btnIngresarP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListarP
            // 
            this.btnListarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnListarP.Location = new System.Drawing.Point(165, 99);
            this.btnListarP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarP.Name = "btnListarP";
            this.btnListarP.Size = new System.Drawing.Size(126, 37);
            this.btnListarP.TabIndex = 29;
            this.btnListarP.Text = "Listar";
            this.btnListarP.UseVisualStyleBackColor = true;
            this.btnListarP.Click += new System.EventHandler(this.btnListarP_Click);
            // 
            // btnVolverP
            // 
            this.btnVolverP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverP.Location = new System.Drawing.Point(506, 359);
            this.btnVolverP.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnVolverP.Name = "btnVolverP";
            this.btnVolverP.Size = new System.Drawing.Size(90, 30);
            this.btnVolverP.TabIndex = 28;
            this.btnVolverP.Text = "Volver";
            this.btnVolverP.UseVisualStyleBackColor = true;
            this.btnVolverP.Click += new System.EventHandler(this.btnVolverP_Click);
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminarP.Location = new System.Drawing.Point(470, 99);
            this.btnEliminarP.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(126, 37);
            this.btnEliminarP.TabIndex = 27;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.UseVisualStyleBackColor = true;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // btnModificarP
            // 
            this.btnModificarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificarP.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnModificarP.Location = new System.Drawing.Point(320, 99);
            this.btnModificarP.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnModificarP.Name = "btnModificarP";
            this.btnModificarP.Size = new System.Drawing.Size(126, 37);
            this.btnModificarP.TabIndex = 26;
            this.btnModificarP.Text = "Modificar";
            this.btnModificarP.UseVisualStyleBackColor = true;
            this.btnModificarP.Click += new System.EventHandler(this.btnModificarP_Click);
            // 
            // btnIngresarP
            // 
            this.btnIngresarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnIngresarP.Location = new System.Drawing.Point(15, 99);
            this.btnIngresarP.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnIngresarP.Name = "btnIngresarP";
            this.btnIngresarP.Size = new System.Drawing.Size(126, 37);
            this.btnIngresarP.TabIndex = 25;
            this.btnIngresarP.Text = "Ingresar";
            this.btnIngresarP.UseVisualStyleBackColor = true;
            this.btnIngresarP.Click += new System.EventHandler(this.btnIngresarP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(204, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Administrar Paramedicos";
            // 
            // MenuAdminParamedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 398);
            this.Controls.Add(this.btnListarP);
            this.Controls.Add(this.btnVolverP);
            this.Controls.Add(this.btnEliminarP);
            this.Controls.Add(this.btnModificarP);
            this.Controls.Add(this.btnIngresarP);
            this.Controls.Add(this.label1);
            this.Name = "MenuAdminParamedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdminParamedico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarP;
        private System.Windows.Forms.Button btnVolverP;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Button btnModificarP;
        private System.Windows.Forms.Button btnIngresarP;
        private System.Windows.Forms.Label label1;
    }
}