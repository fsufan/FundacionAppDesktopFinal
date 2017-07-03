namespace AplicacionDesktop.MENU
{
    partial class MenuAdminEnfermera
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
            this.btnListarP = new System.Windows.Forms.Button();
            this.btnVolverE = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnModificarP = new System.Windows.Forms.Button();
            this.btnIngresarE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(190, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Administrar Enfermeras";
            // 
            // btnListarP
            // 
            this.btnListarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnListarP.Location = new System.Drawing.Point(179, 93);
            this.btnListarP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarP.Name = "btnListarP";
            this.btnListarP.Size = new System.Drawing.Size(126, 37);
            this.btnListarP.TabIndex = 23;
            this.btnListarP.Text = "Listar";
            this.btnListarP.UseVisualStyleBackColor = true;
            this.btnListarP.Click += new System.EventHandler(this.btnListarP_Click);
            // 
            // btnVolverE
            // 
            this.btnVolverE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverE.Location = new System.Drawing.Point(535, 367);
            this.btnVolverE.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnVolverE.Name = "btnVolverE";
            this.btnVolverE.Size = new System.Drawing.Size(90, 30);
            this.btnVolverE.TabIndex = 22;
            this.btnVolverE.Text = "Volver";
            this.btnVolverE.UseVisualStyleBackColor = true;
            this.btnVolverE.Click += new System.EventHandler(this.btnVolverE_Click);
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminarP.Location = new System.Drawing.Point(498, 93);
            this.btnEliminarP.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(126, 37);
            this.btnEliminarP.TabIndex = 21;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.UseVisualStyleBackColor = true;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // btnModificarP
            // 
            this.btnModificarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificarP.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnModificarP.Location = new System.Drawing.Point(347, 93);
            this.btnModificarP.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnModificarP.Name = "btnModificarP";
            this.btnModificarP.Size = new System.Drawing.Size(126, 37);
            this.btnModificarP.TabIndex = 20;
            this.btnModificarP.Text = "Modificar";
            this.btnModificarP.UseVisualStyleBackColor = true;
            this.btnModificarP.Click += new System.EventHandler(this.btnModificarP_Click);
            // 
            // btnIngresarE
            // 
            this.btnIngresarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnIngresarE.Location = new System.Drawing.Point(14, 93);
            this.btnIngresarE.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnIngresarE.Name = "btnIngresarE";
            this.btnIngresarE.Size = new System.Drawing.Size(126, 37);
            this.btnIngresarE.TabIndex = 19;
            this.btnIngresarE.Text = "Ingresar";
            this.btnIngresarE.UseVisualStyleBackColor = true;
            this.btnIngresarE.Click += new System.EventHandler(this.btnIngresarE_Click);
            // 
            // MenuAdminEnfermera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 418);
            this.Controls.Add(this.btnListarP);
            this.Controls.Add(this.btnVolverE);
            this.Controls.Add(this.btnEliminarP);
            this.Controls.Add(this.btnModificarP);
            this.Controls.Add(this.btnIngresarE);
            this.Controls.Add(this.label1);
            this.Name = "MenuAdminEnfermera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdminEnfermera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListarP;
        private System.Windows.Forms.Button btnVolverE;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Button btnModificarP;
        private System.Windows.Forms.Button btnIngresarE;
    }
}