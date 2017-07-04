namespace AplicacionDesktop.CRUD
{
    partial class IngresarCompra
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
            this.btnVolverr = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gpbCompra = new System.Windows.Forms.GroupBox();
            this.btnAgregarD = new System.Windows.Forms.Button();
            this.btningresarCompra = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontoT = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.gpbCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverr
            // 
            this.btnVolverr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverr.Location = new System.Drawing.Point(696, 597);
            this.btnVolverr.Name = "btnVolverr";
            this.btnVolverr.Size = new System.Drawing.Size(84, 29);
            this.btnVolverr.TabIndex = 109;
            this.btnVolverr.Text = "Volver";
            this.btnVolverr.UseVisualStyleBackColor = true;
            this.btnVolverr.Click += new System.EventHandler(this.btnVolverr_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(315, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 24);
            this.label8.TabIndex = 108;
            this.label8.Text = "Ingresar Compra";
            // 
            // gpbCompra
            // 
            this.gpbCompra.Controls.Add(this.btnAgregarD);
            this.gpbCompra.Controls.Add(this.btningresarCompra);
            this.gpbCompra.Controls.Add(this.dataGridView1);
            this.gpbCompra.Controls.Add(this.txtDes);
            this.gpbCompra.Controls.Add(this.label4);
            this.gpbCompra.Controls.Add(this.label1);
            this.gpbCompra.Controls.Add(this.dtpFechaCompra);
            this.gpbCompra.Controls.Add(this.label2);
            this.gpbCompra.Controls.Add(this.txtMontoT);
            this.gpbCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCompra.Location = new System.Drawing.Point(12, 36);
            this.gpbCompra.Name = "gpbCompra";
            this.gpbCompra.Size = new System.Drawing.Size(768, 480);
            this.gpbCompra.TabIndex = 123;
            this.gpbCompra.TabStop = false;
            this.gpbCompra.Text = "Compra";
            // 
            // btnAgregarD
            // 
            this.btnAgregarD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarD.Location = new System.Drawing.Point(573, 107);
            this.btnAgregarD.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAgregarD.Name = "btnAgregarD";
            this.btnAgregarD.Size = new System.Drawing.Size(134, 29);
            this.btnAgregarD.TabIndex = 126;
            this.btnAgregarD.Text = "Agregar Detalle";
            this.btnAgregarD.UseVisualStyleBackColor = true;
            this.btnAgregarD.Click += new System.EventHandler(this.btnAgregarD_Click);
            // 
            // btningresarCompra
            // 
            this.btningresarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresarCompra.Location = new System.Drawing.Point(425, 107);
            this.btningresarCompra.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btningresarCompra.Name = "btningresarCompra";
            this.btningresarCompra.Size = new System.Drawing.Size(87, 29);
            this.btningresarCompra.TabIndex = 125;
            this.btningresarCompra.Text = "Ingresar";
            this.btningresarCompra.UseVisualStyleBackColor = true;
            this.btningresarCompra.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 300);
            this.dataGridView1.TabIndex = 118;
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(158, 78);
            this.txtDes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(200, 58);
            this.txtDes.TabIndex = 123;
            this.txtDes.TextChanged += new System.EventHandler(this.txtDes_TextChanged);
            this.txtDes.Validating += new System.ComponentModel.CancelEventHandler(this.txtDes_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 122;
            this.label4.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 119;
            this.label1.Text = "Monto Total";
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCompra.Location = new System.Drawing.Point(157, 35);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCompra.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 119;
            this.label2.Text = "Fecha";
            // 
            // txtMontoT
            // 
            this.txtMontoT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoT.Location = new System.Drawing.Point(508, 35);
            this.txtMontoT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMontoT.Name = "txtMontoT";
            this.txtMontoT.Size = new System.Drawing.Size(199, 20);
            this.txtMontoT.TabIndex = 105;
            this.txtMontoT.TextChanged += new System.EventHandler(this.txtMontoT_TextChanged);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(0, 613);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(0, 13);
            this.lblRol.TabIndex = 124;
            // 
            // IngresarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(792, 629);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.gpbCompra);
            this.Controls.Add(this.btnVolverr);
            this.Controls.Add(this.label8);
            this.MaximumSize = new System.Drawing.Size(808, 668);
            this.Name = "IngresarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarCompra";
            this.gpbCompra.ResumeLayout(false);
            this.gpbCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gpbCompra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontoT;
        private System.Windows.Forms.Button btningresarCompra;
        private System.Windows.Forms.Button btnAgregarD;
        private System.Windows.Forms.Label lblRol;
    }
}