namespace AplicacionDesktop.MENU
{
    partial class MenuRol
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
            this.btnIngresarR = new System.Windows.Forms.Button();
            this.btnListarR = new System.Windows.Forms.Button();
            this.btnEliminarR = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(257, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrar Roles";
            // 
            // btnIngresarR
            // 
            this.btnIngresarR.Location = new System.Drawing.Point(57, 116);
            this.btnIngresarR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresarR.Name = "btnIngresarR";
            this.btnIngresarR.Size = new System.Drawing.Size(112, 37);
            this.btnIngresarR.TabIndex = 1;
            this.btnIngresarR.Text = "Ingresar";
            this.btnIngresarR.UseVisualStyleBackColor = true;
            this.btnIngresarR.Click += new System.EventHandler(this.btnIngresarR_Click);
            // 
            // btnListarR
            // 
            this.btnListarR.Location = new System.Drawing.Point(207, 116);
            this.btnListarR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarR.Name = "btnListarR";
            this.btnListarR.Size = new System.Drawing.Size(112, 37);
            this.btnListarR.TabIndex = 2;
            this.btnListarR.Text = "Listar";
            this.btnListarR.UseVisualStyleBackColor = true;
            this.btnListarR.Click += new System.EventHandler(this.btnListarR_Click);
            // 
            // btnEliminarR
            // 
            this.btnEliminarR.Location = new System.Drawing.Point(492, 116);
            this.btnEliminarR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarR.Name = "btnEliminarR";
            this.btnEliminarR.Size = new System.Drawing.Size(112, 37);
            this.btnEliminarR.TabIndex = 3;
            this.btnEliminarR.Text = "Eliminar";
            this.btnEliminarR.UseVisualStyleBackColor = true;
            this.btnEliminarR.Click += new System.EventHandler(this.btnEliminarR_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(353, 116);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 37);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(550, 324);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(80, 27);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // MenuRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(643, 365);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarR);
            this.Controls.Add(this.btnListarR);
            this.Controls.Add(this.btnIngresarR);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(659, 404);
            this.Name = "MenuRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresarR;
        private System.Windows.Forms.Button btnListarR;
        private System.Windows.Forms.Button btnEliminarR;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVolver;
    }
}