﻿namespace AplicacionDesktop.MENU
{
    partial class MenuAdminCompra
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnVolverU = new System.Windows.Forms.Button();
            this.btnEliminarU = new System.Windows.Forms.Button();
            this.btnModificarU = new System.Windows.Forms.Button();
            this.btnIngresarU = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(157, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolverU
            // 
            this.btnVolverU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverU.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnVolverU.Location = new System.Drawing.Point(481, 372);
            this.btnVolverU.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnVolverU.Name = "btnVolverU";
            this.btnVolverU.Size = new System.Drawing.Size(90, 30);
            this.btnVolverU.TabIndex = 17;
            this.btnVolverU.Text = "Volver";
            this.btnVolverU.UseVisualStyleBackColor = true;
            this.btnVolverU.Click += new System.EventHandler(this.btnVolverU_Click);
            // 
            // btnEliminarU
            // 
            this.btnEliminarU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminarU.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEliminarU.Location = new System.Drawing.Point(429, 111);
            this.btnEliminarU.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnEliminarU.Name = "btnEliminarU";
            this.btnEliminarU.Size = new System.Drawing.Size(112, 37);
            this.btnEliminarU.TabIndex = 16;
            this.btnEliminarU.Text = "Eliminar";
            this.btnEliminarU.UseVisualStyleBackColor = true;
            this.btnEliminarU.Click += new System.EventHandler(this.btnEliminarU_Click);
            // 
            // btnModificarU
            // 
            this.btnModificarU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificarU.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnModificarU.Location = new System.Drawing.Point(293, 111);
            this.btnModificarU.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnModificarU.Name = "btnModificarU";
            this.btnModificarU.Size = new System.Drawing.Size(112, 37);
            this.btnModificarU.TabIndex = 15;
            this.btnModificarU.Text = "Modificar";
            this.btnModificarU.UseVisualStyleBackColor = true;
            this.btnModificarU.Click += new System.EventHandler(this.btnModificarU_Click);
            // 
            // btnIngresarU
            // 
            this.btnIngresarU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarU.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnIngresarU.Location = new System.Drawing.Point(24, 111);
            this.btnIngresarU.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnIngresarU.Name = "btnIngresarU";
            this.btnIngresarU.Size = new System.Drawing.Size(112, 37);
            this.btnIngresarU.TabIndex = 14;
            this.btnIngresarU.Text = "Ingresar";
            this.btnIngresarU.UseVisualStyleBackColor = true;
            this.btnIngresarU.Click += new System.EventHandler(this.btnIngresarU_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Administrar Compra";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(2, 389);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(0, 13);
            this.lblRol.TabIndex = 19;
            // 
            // MenuAdminCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(586, 406);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolverU);
            this.Controls.Add(this.btnEliminarU);
            this.Controls.Add(this.btnModificarU);
            this.Controls.Add(this.btnIngresarU);
            this.Controls.Add(this.label1);
            this.Name = "MenuAdminCompra";
            this.ShowIcon = false;
            this.Text = "MenuAdminCompra";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVolverU;
        private System.Windows.Forms.Button btnEliminarU;
        private System.Windows.Forms.Button btnModificarU;
        private System.Windows.Forms.Button btnIngresarU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRol;
    }
}