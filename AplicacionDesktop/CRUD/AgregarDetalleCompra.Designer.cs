namespace AplicacionDesktop.CRUD
{
    partial class AgregarDetalleCompra
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
            this.btningresarCompra = new System.Windows.Forms.Button();
            this.gpbDetCompra = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblNC = new System.Windows.Forms.Label();
            this.cbxProd = new System.Windows.Forms.ComboBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblng = new System.Windows.Forms.Label();
            this.btnVolverr = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gpbCompra = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontoT = new System.Windows.Forms.TextBox();
            this.cbxCompra = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCompra = new System.Windows.Forms.Label();
            this.gpbDetCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gpbCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // btningresarCompra
            // 
            this.btningresarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresarCompra.Location = new System.Drawing.Point(503, 133);
            this.btningresarCompra.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btningresarCompra.Name = "btningresarCompra";
            this.btningresarCompra.Size = new System.Drawing.Size(87, 29);
            this.btningresarCompra.TabIndex = 130;
            this.btningresarCompra.Text = "Ingresar";
            this.btningresarCompra.UseVisualStyleBackColor = true;
            this.btningresarCompra.Click += new System.EventHandler(this.btningresarCompra_Click);
            // 
            // gpbDetCompra
            // 
            this.gpbDetCompra.Controls.Add(this.btningresarCompra);
            this.gpbDetCompra.Controls.Add(this.dataGridView2);
            this.gpbDetCompra.Controls.Add(this.lblNC);
            this.gpbDetCompra.Controls.Add(this.cbxProd);
            this.gpbDetCompra.Controls.Add(this.lblC);
            this.gpbDetCompra.Controls.Add(this.txtDes);
            this.gpbDetCompra.Controls.Add(this.txtCantidad);
            this.gpbDetCompra.Controls.Add(this.lblDe);
            this.gpbDetCompra.Controls.Add(this.txtTotal);
            this.gpbDetCompra.Controls.Add(this.lblng);
            this.gpbDetCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDetCompra.Location = new System.Drawing.Point(12, 158);
            this.gpbDetCompra.Name = "gpbDetCompra";
            this.gpbDetCompra.Size = new System.Drawing.Size(768, 386);
            this.gpbDetCompra.TabIndex = 129;
            this.gpbDetCompra.TabStop = false;
            this.gpbDetCompra.Text = "Detalle Compra";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(43, 170);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(664, 210);
            this.dataGridView2.TabIndex = 118;
            // 
            // lblNC
            // 
            this.lblNC.AutoSize = true;
            this.lblNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNC.Location = new System.Drawing.Point(39, 38);
            this.lblNC.Name = "lblNC";
            this.lblNC.Size = new System.Drawing.Size(81, 20);
            this.lblNC.TabIndex = 98;
            this.lblNC.Text = "Producto";
            // 
            // cbxProd
            // 
            this.cbxProd.AccessibleDescription = "";
            this.cbxProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProd.FormattingEnabled = true;
            this.cbxProd.Location = new System.Drawing.Point(158, 40);
            this.cbxProd.Name = "cbxProd";
            this.cbxProd.Size = new System.Drawing.Size(199, 21);
            this.cbxProd.TabIndex = 110;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(39, 78);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(81, 20);
            this.lblC.TabIndex = 106;
            this.lblC.Text = "Cantidad";
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(503, 41);
            this.txtDes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(200, 58);
            this.txtDes.TabIndex = 116;
            this.txtDes.TextChanged += new System.EventHandler(this.txtDes_TextChanged);
            this.txtDes.Validating += new System.ComponentModel.CancelEventHandler(this.txtDes_Validating);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(158, 78);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 117;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(385, 41);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(103, 20);
            this.lblDe.TabIndex = 115;
            this.lblDe.Text = "Descripción";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(158, 114);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(200, 20);
            this.txtTotal.TabIndex = 104;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // lblng
            // 
            this.lblng.AutoSize = true;
            this.lblng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblng.Location = new System.Drawing.Point(39, 114);
            this.lblng.Name = "lblng";
            this.lblng.Size = new System.Drawing.Size(49, 20);
            this.lblng.TabIndex = 99;
            this.lblng.Text = "Total";
            // 
            // btnVolverr
            // 
            this.btnVolverr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverr.Location = new System.Drawing.Point(696, 594);
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
            this.label8.Location = new System.Drawing.Point(290, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 24);
            this.label8.TabIndex = 126;
            this.label8.Text = "Ingresar Detalle Compra";
            // 
            // gpbCompra
            // 
            this.gpbCompra.Controls.Add(this.label1);
            this.gpbCompra.Controls.Add(this.dtpFechaCompra);
            this.gpbCompra.Controls.Add(this.label2);
            this.gpbCompra.Controls.Add(this.txtMontoT);
            this.gpbCompra.Controls.Add(this.cbxCompra);
            this.gpbCompra.Controls.Add(this.label3);
            this.gpbCompra.Controls.Add(this.lblCompra);
            this.gpbCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCompra.Location = new System.Drawing.Point(12, 33);
            this.gpbCompra.Name = "gpbCompra";
            this.gpbCompra.Size = new System.Drawing.Size(768, 109);
            this.gpbCompra.TabIndex = 130;
            this.gpbCompra.TabStop = false;
            this.gpbCompra.Text = "Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 128;
            this.label1.Text = "Monto Total";
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCompra.Location = new System.Drawing.Point(532, 34);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCompra.TabIndex = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 129;
            this.label2.Text = "Fecha";
            // 
            // txtMontoT
            // 
            this.txtMontoT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoT.Location = new System.Drawing.Point(532, 75);
            this.txtMontoT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMontoT.Name = "txtMontoT";
            this.txtMontoT.Size = new System.Drawing.Size(199, 20);
            this.txtMontoT.TabIndex = 127;
            // 
            // cbxCompra
            // 
            this.cbxCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCompra.FormattingEnabled = true;
            this.cbxCompra.Location = new System.Drawing.Point(25, 53);
            this.cbxCompra.Name = "cbxCompra";
            this.cbxCompra.Size = new System.Drawing.Size(333, 21);
            this.cbxCompra.TabIndex = 126;
            this.cbxCompra.SelectionChangeCommitted += new System.EventHandler(this.cbxCompra_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 125;
            this.label3.Text = "Compras Registradas";
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(72, 0);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(0, 20);
            this.lblCompra.TabIndex = 124;
            // 
            // AgregarDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(792, 629);
            this.Controls.Add(this.gpbCompra);
            this.Controls.Add(this.gpbDetCompra);
            this.Controls.Add(this.btnVolverr);
            this.Controls.Add(this.label8);
            this.Name = "AgregarDetalleCompra";
            this.Text = "AgregarDetalleCompra";
            this.gpbDetCompra.ResumeLayout(false);
            this.gpbDetCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gpbCompra.ResumeLayout(false);
            this.gpbCompra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btningresarCompra;
        private System.Windows.Forms.GroupBox gpbDetCompra;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblNC;
        private System.Windows.Forms.ComboBox cbxProd;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblng;
        private System.Windows.Forms.Button btnVolverr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gpbCompra;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontoT;
    }
}