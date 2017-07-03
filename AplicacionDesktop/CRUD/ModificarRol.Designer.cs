namespace AplicacionDesktop.CRUD
{
    partial class ModificarRol
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
            this.cmbnrol = new System.Windows.Forms.ComboBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.btnModRol = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dtmodrol = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtmodrol)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nueva Descripción";
            // 
            // cmbnrol
            // 
            this.cmbnrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbnrol.FormattingEnabled = true;
            this.cmbnrol.Location = new System.Drawing.Point(206, 100);
            this.cmbnrol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbnrol.Name = "cmbnrol";
            this.cmbnrol.Size = new System.Drawing.Size(243, 21);
            this.cmbnrol.TabIndex = 3;
            this.cmbnrol.SelectionChangeCommitted += new System.EventHandler(this.cmbnrol_SelectionChangeCommitted);
            this.cmbnrol.Validating += new System.ComponentModel.CancelEventHandler(this.cmbnrol_Validating);
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(206, 160);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(270, 115);
            this.txtdesc.TabIndex = 4;
            this.txtdesc.TextChanged += new System.EventHandler(this.txtdesc_TextChanged);
            this.txtdesc.Validating += new System.ComponentModel.CancelEventHandler(this.txtdesc_Validating);
            // 
            // btnModRol
            // 
            this.btnModRol.Location = new System.Drawing.Point(490, 186);
            this.btnModRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModRol.Name = "btnModRol";
            this.btnModRol.Size = new System.Drawing.Size(112, 37);
            this.btnModRol.TabIndex = 5;
            this.btnModRol.Text = "Modificar";
            this.btnModRol.UseVisualStyleBackColor = true;
            this.btnModRol.Click += new System.EventHandler(this.btnModRol_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(514, 465);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(87, 27);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dtmodrol
            // 
            this.dtmodrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtmodrol.Location = new System.Drawing.Point(29, 294);
            this.dtmodrol.Name = "dtmodrol";
            this.dtmodrol.Size = new System.Drawing.Size(573, 163);
            this.dtmodrol.TabIndex = 7;
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(614, 506);
            this.Controls.Add(this.dtmodrol);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModRol);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.cmbnrol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ModificarRol";
            this.Text = "ModificarRol";
            ((System.ComponentModel.ISupportInitialize)(this.dtmodrol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbnrol;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Button btnModRol;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dtmodrol;
    }
}