namespace AplicacionDesktop.CRUD
{
    partial class ModificarCompra
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.lblFF = new System.Windows.Forms.Label();
            this.cbxCompra = new System.Windows.Forms.ComboBox();
            this.btnVolverr = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoT = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(423, 188);
            this.dataGridView1.TabIndex = 134;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(244, 168);
            this.txtDes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(200, 58);
            this.txtDes.TabIndex = 132;
            this.txtDes.TextChanged += new System.EventHandler(this.txtDes_TextChanged);
            this.txtDes.Validating += new System.ComponentModel.CancelEventHandler(this.txtDes_Validating);
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(31, 165);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(103, 20);
            this.lblDe.TabIndex = 131;
            this.lblDe.Text = "Descripción";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(244, 128);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 130;
            // 
            // lblFF
            // 
            this.lblFF.AutoSize = true;
            this.lblFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFF.Location = new System.Drawing.Point(31, 125);
            this.lblFF.Name = "lblFF";
            this.lblFF.Size = new System.Drawing.Size(59, 20);
            this.lblFF.TabIndex = 129;
            this.lblFF.Text = "Fecha";
            // 
            // cbxCompra
            // 
            this.cbxCompra.AccessibleDescription = "";
            this.cbxCompra.FormattingEnabled = true;
            this.cbxCompra.Location = new System.Drawing.Point(244, 85);
            this.cbxCompra.Name = "cbxCompra";
            this.cbxCompra.Size = new System.Drawing.Size(199, 21);
            this.cbxCompra.TabIndex = 128;
            this.cbxCompra.SelectionChangeCommitted += new System.EventHandler(this.cbxCompra_SelectionChangeCommitted);
            // 
            // btnVolverr
            // 
            this.btnVolverr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverr.Location = new System.Drawing.Point(360, 588);
            this.btnVolverr.Name = "btnVolverr";
            this.btnVolverr.Size = new System.Drawing.Size(84, 29);
            this.btnVolverr.TabIndex = 127;
            this.btnVolverr.Text = "Volver";
            this.btnVolverr.UseVisualStyleBackColor = true;
            this.btnVolverr.Click += new System.EventHandler(this.btnVolverr_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(118, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 24);
            this.label8.TabIndex = 126;
            this.label8.Text = "Modificar Compra";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(244, 299);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 43);
            this.btnModificar.TabIndex = 125;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 136;
            this.label2.Text = "Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 139;
            this.label1.Text = "Monto Total";
            // 
            // txtMontoT
            // 
            this.txtMontoT.Location = new System.Drawing.Point(244, 248);
            this.txtMontoT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMontoT.Name = "txtMontoT";
            this.txtMontoT.Size = new System.Drawing.Size(199, 20);
            this.txtMontoT.TabIndex = 138;
            this.txtMontoT.TextChanged += new System.EventHandler(this.txtMontoT_TextChanged);
            this.txtMontoT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoT_KeyPress);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(0, 604);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(0, 13);
            this.lblRol.TabIndex = 140;
            // 
            // ModificarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(478, 620);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMontoT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.lblFF);
            this.Controls.Add(this.cbxCompra);
            this.Controls.Add(this.btnVolverr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnModificar);
            this.Name = "ModificarCompra";
            this.Text = "ModificarCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label lblFF;
        private System.Windows.Forms.ComboBox cbxCompra;
        private System.Windows.Forms.Button btnVolverr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontoT;
        private System.Windows.Forms.Label lblRol;
    }
}