namespace AplicacionDesktop.MENU
{
    partial class MenuUsuario
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
            this.btnIngresarU = new System.Windows.Forms.Button();
            this.btnListarU = new System.Windows.Forms.Button();
            this.btnModificarU = new System.Windows.Forms.Button();
            this.btnEliminarU = new System.Windows.Forms.Button();
            this.btnVolverU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrar Usuarios";
            // 
            // btnIngresarU
            // 
            this.btnIngresarU.Location = new System.Drawing.Point(25, 89);
            this.btnIngresarU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresarU.Name = "btnIngresarU";
            this.btnIngresarU.Size = new System.Drawing.Size(112, 37);
            this.btnIngresarU.TabIndex = 1;
            this.btnIngresarU.Text = "Ingresar";
            this.btnIngresarU.UseVisualStyleBackColor = true;
            this.btnIngresarU.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnListarU
            // 
            this.btnListarU.Location = new System.Drawing.Point(169, 89);
            this.btnListarU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarU.Name = "btnListarU";
            this.btnListarU.Size = new System.Drawing.Size(112, 37);
            this.btnListarU.TabIndex = 2;
            this.btnListarU.Text = "Listar";
            this.btnListarU.UseVisualStyleBackColor = true;
            this.btnListarU.Click += new System.EventHandler(this.btnListarU_Click);
            // 
            // btnModificarU
            // 
            this.btnModificarU.Location = new System.Drawing.Point(327, 89);
            this.btnModificarU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarU.Name = "btnModificarU";
            this.btnModificarU.Size = new System.Drawing.Size(112, 37);
            this.btnModificarU.TabIndex = 3;
            this.btnModificarU.Text = "Modificar";
            this.btnModificarU.UseVisualStyleBackColor = true;
            this.btnModificarU.Click += new System.EventHandler(this.btnModificarU_Click);
            // 
            // btnEliminarU
            // 
            this.btnEliminarU.Location = new System.Drawing.Point(484, 89);
            this.btnEliminarU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarU.Name = "btnEliminarU";
            this.btnEliminarU.Size = new System.Drawing.Size(112, 37);
            this.btnEliminarU.TabIndex = 4;
            this.btnEliminarU.Text = "Eliminar";
            this.btnEliminarU.UseVisualStyleBackColor = true;
            this.btnEliminarU.Click += new System.EventHandler(this.btnEliminarU_Click);
            // 
            // btnVolverU
            // 
            this.btnVolverU.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverU.Location = new System.Drawing.Point(540, 384);
            this.btnVolverU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolverU.Name = "btnVolverU";
            this.btnVolverU.Size = new System.Drawing.Size(74, 33);
            this.btnVolverU.TabIndex = 5;
            this.btnVolverU.Text = "Volver";
            this.btnVolverU.UseVisualStyleBackColor = true;
            this.btnVolverU.Click += new System.EventHandler(this.btnVolverU_Click);
            // 
            // MenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(627, 422);
            this.Controls.Add(this.btnVolverU);
            this.Controls.Add(this.btnEliminarU);
            this.Controls.Add(this.btnModificarU);
            this.Controls.Add(this.btnListarU);
            this.Controls.Add(this.btnIngresarU);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(643, 461);
            this.Name = "MenuUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresarU;
        private System.Windows.Forms.Button btnListarU;
        private System.Windows.Forms.Button btnModificarU;
        private System.Windows.Forms.Button btnEliminarU;
        private System.Windows.Forms.Button btnVolverU;
    }
}