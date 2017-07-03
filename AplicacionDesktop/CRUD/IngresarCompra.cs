using AplicacionDesktop.MENU;
using Capa_DTO.Farmacia;
using CapaNegocio.NegocioFarmacia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDesktop.CRUD
{
    public partial class IngresarCompra : Form
    {
        public IngresarCompra()
        {
            InitializeComponent();
                        
        }
        public IngresarCompra(string rol)
        {
            InitializeComponent();
            lblRol.Text = rol;
            lblRol.Visible = false;

        }
        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioCompra compra = new NegocioCompra();
                Compra auxCompra = new Compra();
                //NegocioDetalleCompra det = new NegocioDetalleCompra();


                if (txtDes.Text!=""&txtMontoT.Text!="")
                {
                    if (int.Parse(txtMontoT.Text)>0 & !validaCampoVacio(txtDes))
                    {
                        
                    
                    auxCompra.Descripcion = txtDes.Text;
                    auxCompra.Fecha = dtpFechaCompra.Value;
                    auxCompra.MontoTotal = int.Parse(txtMontoT.Text);                   
                    DialogResult dialogResult = MessageBox.Show("Desea agregar: " + txtDes.Text, "Información", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DialogResult result = MessageBox.Show("Se ingresara  ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        switch (result)
                        {

                            case DialogResult.No:
                                break;

                            case DialogResult.Yes:



                                if (compra.ingresarCompra(auxCompra) > 0)
                                {
                                    MessageBox.Show("Compra Ingresada");

                                    txtDes.Text = "";
                                    txtMontoT.Text = "";

                                    //dtpfecha.Value = DateTime.Now;


                                    cargarGrillaCompra();


                                }
                                else
                                {
                                    MessageBox.Show("Error al ingresar compra");
                                }

                                break;
                        }
                    }
                    }
                    else
                    {
                        MessageBox.Show("ingrese datos válidos");
                    }
                }
                else
                {
                    MessageBox.Show("ingrese todos los campos");
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void btnVolverr_Click(object sender, EventArgs e)
        {
            MenuAdminCompra mCompra = new MenuAdminCompra(lblRol.Text);
            mCompra.Show();
            Hide();
        }

        private void txtMontoT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cargarGrillaCompra()
        {
            NegocioCompra compra = new NegocioCompra();
            try
            {
                if (compra.listarCompras() != null)
                {
                    dataGridView1.DataSource = compra.listarCompras();
                    dataGridView1.ReadOnly = true;
                    dataGridView1.Columns[0].HeaderText = "DESCRIPCION";
                    dataGridView1.Columns[1].HeaderText = "FECHA COMPRA";
                    dataGridView1.Columns[3].HeaderText = "ID COMPRA";                    
                    dataGridView1.Columns[4].HeaderText = "MONTO TOTAL";
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.AutoSize = true;
                    dataGridView1.Update();

                }
                else
                {
                    MessageBox.Show("No hay datos ingresados");

                    //btn_pdf.Enabled = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No hay datos ingresados");

                //btn_pdf.Enabled = false;
            }

        }
        private void focusComponente(TextBox text)
        {
            text.Focus();
        }

        private Boolean validaCampoVacio(TextBox campo)
        {
            if (String.IsNullOrEmpty(campo.Text.Trim()))
            {
                return true;
            }
            else
            {
                focusComponente(campo);
                return false;
            }
        }

        private void btnAgregarD_Click(object sender, EventArgs e)
        {
            AgregarDetalleCompra det = new AgregarDetalleCompra();
            det.Show();
            this.Show();
        }

        private void txtDes_TextChanged(object sender, EventArgs e)
        {
            txtDes.MaxLength = 100;
        }

        private void txtMontoT_TextChanged(object sender, EventArgs e)
        {
            txtMontoT.MaxLength = 38;
        }

        private void txtDes_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtDes.Text, @"^[A-Z0-9 a-z]*$")) && (txtDes.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtDes.Focus();
                txtDes.Text = "";
            }
        }
        
        

    }
}
