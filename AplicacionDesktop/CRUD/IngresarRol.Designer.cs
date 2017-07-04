namespace AplicacionDesktop.CRUD
{
    partial class IngresarRol
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescRol = new System.Windows.Forms.TextBox();
            this.btnIngresoR = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dttingrol = new System.Windows.Forms.DataGridView();
            this.txtRol = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dttingrol)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción del Rol";
            // 
            // txtDescRol
            // 
            this.txtDescRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescRol.Location = new System.Drawing.Point(229, 152);
            this.txtDescRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescRol.MaxLength = 42767;
            this.txtDescRol.Multiline = true;
            this.txtDescRol.Name = "txtDescRol";
            this.txtDescRol.Size = new System.Drawing.Size(295, 94);
            this.txtDescRol.TabIndex = 4;
            this.txtDescRol.TextChanged += new System.EventHandler(this.txtDescRol_TextChanged);
            this.txtDescRol.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescRol_Validating_1);
            // 
            // btnIngresoR
            // 
            this.btnIngresoR.Location = new System.Drawing.Point(555, 194);
            this.btnIngresoR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresoR.Name = "btnIngresoR";
            this.btnIngresoR.Size = new System.Drawing.Size(112, 37);
            this.btnIngresoR.TabIndex = 5;
            this.btnIngresoR.Text = "Ingresar";
            this.btnIngresoR.UseVisualStyleBackColor = true;
            this.btnIngresoR.Click += new System.EventHandler(this.btnIngresoR_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(590, 434);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(73, 32);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dttingrol
            // 
            this.dttingrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dttingrol.Location = new System.Drawing.Point(38, 266);
            this.dttingrol.Name = "dttingrol";
            this.dttingrol.Size = new System.Drawing.Size(545, 169);
            this.dttingrol.TabIndex = 7;
            this.dttingrol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dttingrol_CellContentClick);
            // 
            // txtRol
            // 
            this.txtRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRol.Location = new System.Drawing.Point(229, 105);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(265, 20);
            this.txtRol.TabIndex = 8;
            this.txtRol.TextChanged += new System.EventHandler(this.txtRol_TextChanged);
            this.txtRol.Validating += new System.ComponentModel.CancelEventHandler(this.txtRol_Validating);
            // 
            // IngresarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(682, 471);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.dttingrol);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnIngresoR);
            this.Controls.Add(this.txtDescRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(698, 510);
            this.Name = "IngresarRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarRol";
            ((System.ComponentModel.ISupportInitialize)(this.dttingrol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescRol;
        private System.Windows.Forms.Button btnIngresoR;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dttingrol;
        private System.Windows.Forms.TextBox txtRol;
    }
}