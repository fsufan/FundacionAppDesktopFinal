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
    public partial class ModificarCompra : Form
    {
        public ModificarCompra()
        {
            InitializeComponent();
            cargarCombobox();
        }
        public ModificarCompra(string rol)
        {
            InitializeComponent();
            lblRol.Text = rol;
            lblRol.Visible = false;
            cargarCombobox();
            
        }
        private void cargarCombobox()
        {
            try
            {
                NegocioCompra compra = new NegocioCompra();
                
                if (compra.listarCompras()!=null)
                {
                    cbxCompra.DataSource = compra.listarCompras();
                    cbxCompra.DisplayMember = "descripcion";
                    cbxCompra.ValueMember = "id_compra";
                }
                else
                {
                    MessageBox.Show("No hay datos ingresados");
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("No hay datos ingresados");
            }
            
        }
        private void cargarGrilla()
        {
            NegocioCompra compra = new NegocioCompra();
            try
            {
                if (compra.listarCompras() != null)
                {
                    dataGridView1.DataSource = compra.CompraPorId(int.Parse(cbxCompra.SelectedValue.ToString()));
                    dataGridView1.ReadOnly = true;
                    dataGridView1.Columns[0].HeaderText = "DESCRIPCION";
                    dataGridView1.Columns[1].HeaderText = "FECHA COMPRA";
                    dataGridView1.Columns[3].HeaderText = "ID COMPRA";
                    dataGridView1.Columns[4].HeaderText = "MONTO TOTAL";
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Update();

                }
                else
                {
                    MessageBox.Show("No hay datos ingresados");
                    this.Close();
                    //btn_pdf.Enabled = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No hay datos ingresados");
                this.Close();
                //btn_pdf.Enabled = false;
            }

        }
        private void btnVolverr_Click(object sender, EventArgs e)
        {
            MenuAdminCompra mCompra = new MenuAdminCompra(lblRol.Text);
            mCompra.Show();
            Hide();
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
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioCompra compra = new NegocioCompra();
                Compra auxCompra = new Compra();
                //Compra auxCompraM = new Compra();

                //NegocioDetalleCompra dCompra = new NegocioDetalleCompra();
                //DetalleCompra auxdCompra= new DetalleCompra();
                //DetalleCompra auxdCompraM = new DetalleCompra();

                DialogResult dialogResult = MessageBox.Show("Desea modificar la Compra: " + cbxCompra.Text.ToString(), "Información", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult result = MessageBox.Show("Se modificara la compra ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        
                        case DialogResult.No:
                            break;
                        
                        case DialogResult.Yes:
                            if (txtDes.Text != "" & txtMontoT.Text!= "")
                            {
                                if (cbxCompra.SelectedIndex != -1)
                                {
                                    if (!validaCampoVacio(txtDes)&int.Parse(txtMontoT.Text)>0)
                                    {
                                        //compra
                                        auxCompra.Descripcion = txtDes.Text;
                                        auxCompra.Fecha = dtpfecha.Value;
                                        auxCompra.MontoTotal = int.Parse(txtMontoT.Text);
                                        auxCompra.Id_compra = int.Parse(cbxCompra.SelectedValue.ToString());
                                        //obtener objeto compra
                                        if (compra.actualizarCompra(auxCompra)>0)
                                        {
                                            MessageBox.Show("Compra actualizada correctamente");
                                            txtDes.Text = "";
                                            txtMontoT.Text ="";
                                            dtpfecha.Value = DateTime.Now;
                                            dataGridView1.DataSource = compra.CompraPorId(auxCompra.Id_compra);
                                        }
                                        else
                                        {
                                               MessageBox.Show("Error al ingresar");
                                           
                                        }
                                        
                                        
                                        //detalle compra
                                        //auxdCompra.Cantidad = int.Parse(txtCantidad.Text);
                                        //auxdCompra.Descripcion = txtDes.Text;                                        
                                        //auxdCompra.Total = int.Parse(txtTotal.Text);
                                        //obtener producto 
                                        //auxdCompra.Id_producto = int.Parse(txtProducto.Text);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Ingrese datos válidos");

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Seleccione una compra");

                                }

                            }
                            else
                            {
                                MessageBox.Show("Ingrese todos los campos");

                            }
                            break;
                        default:
                            break;
                    }
                }

            }
            catch (Exception)
            {
                
                MessageBox.Show("Error intentelo nuevamente");
            }
        }

        private void cbxCompra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                NegocioCompra compra = new NegocioCompra();
                Compra auxCompra = new Compra();
                auxCompra = compra.consultarPorId(int.Parse(cbxCompra.SelectedValue.ToString()));
                txtDes.Text = auxCompra.Descripcion;
                txtMontoT.Text = auxCompra.MontoTotal.ToString();
                dtpfecha.Value = auxCompra.Fecha;
            }
            catch (Exception)
            {

                MessageBox.Show("Solo se permiten números");
            }
            
            
             
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
