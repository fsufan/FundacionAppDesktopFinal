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
    public partial class AgregarDetalleCompra : Form
    {
        public AgregarDetalleCompra()
        {
            InitializeComponent();
            cargarCompras();
            Focus();
        }
        public AgregarDetalleCompra(string rol)
        {
            InitializeComponent();
            cargarCompras();
            
        }
        private void cargarCompras()
        {
            NegocioCompra compra = new NegocioCompra();
            Compra auxCompra = new Compra();
            try
            {
                if (compra.listarCompras()!=null)
                {
                    cbxCompra.DataSource = compra.listarCompras();
                    //foreach (var item in compra.listarCompras())
                    //{

                        //cbxCompra.Text = item.ToString();

                        //cbxCompra.DisplayMember = "fecha"+"descripcion"+"montototal";
                        cbxCompra.DisplayMember = "descripcion";
                        cbxCompra.ValueMember = "id_compra";
                    //}
                    
                    cbxCompra.SelectedIndex = -1;
                    if (cbxCompra.SelectedIndex == -1)
                    {
                        cbxCompra.Text = "Seleccione una compra";
                    }
                    cargarProductos();
                }
                else
                {
                    MessageBox.Show("No hay compras ingresadas", "Ingrese una primero");
                    IngresarCompra IC = new IngresarCompra();
                    IC.Show();
                    this.Close();
                }

                

            }
            catch (Exception)
            {

                MessageBox.Show("No hay compras ingresadas","Ingrese una primero");
                IngresarCompra IC = new IngresarCompra();
                IC.Show();
                this.Close();
            }
        
        }
        private void cargarProductos()
        {
            NegocioProducto prod = new NegocioProducto();
            if (prod.listarProductos() != null)
            {
                cbxProd.DataSource = prod.listarProductos();
                cbxProd.DisplayMember = "nombre";
                cbxProd.ValueMember = "id_producto";

                cbxProd.SelectedIndex = -1;
                if (cbxProd.SelectedIndex == -1)
                {
                    cbxProd.Text = "Seleccione un producto";
                }
            }
            else
            {
                MessageBox.Show("No hay datos productos ingresados","Ingrese un producto");
                IngresarProducto IP = new IngresarProducto();
                IP.Show();
                
            }


        }
        private void cargarGrillaDetCompra()
        {
            NegocioDetalleCompra dCompra = new NegocioDetalleCompra();
            DetalleCompra auxdCompra = new DetalleCompra();

            dataGridView2.DataSource = dCompra.listarDetalleCompras();
            dataGridView2.AutoSize = true;
            dataGridView2.Update();
        
        }
        private void btningresarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                //NegocioCompra compra = new NegocioCompra();
                //Compra auxCompra = new Compra();
                
                NegocioDetalleCompra dCompra = new NegocioDetalleCompra();
                DetalleCompra auxdCompra = new DetalleCompra();
                if (!txtDes.Text.Equals("") & txtTotal.Text!="" & !txtCantidad.Text.Equals("") )
                {
                    if (cbxProd.SelectedIndex != -1 & cbxCompra.SelectedIndex!=-1)
                    {
                        if (int.Parse(txtCantidad.Text)>0&int.Parse(txtMontoT.Text)>0&!validaCampoVacio(txtDes))
                        {
                            //if (dCompra.consultarDetCompra(txtDes.Text, int.Parse(cbxProd.SelectedValue.ToString())) == 0)
                            //{
                            //    //auxCompra.Descripcion = txtDes.Text;
                                //auxCompra.Fecha = dtpfecha.Value;
                                //auxCompra.MontoTotal = int.Parse(txtMontoT.Text);
                                DialogResult dialogResult = MessageBox.Show("Desea agregar: " + cbxProd.Text, "Información", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    DialogResult result = MessageBox.Show("Se ingresara  ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                    switch (result)
                                    {

                                        case DialogResult.No:
                                            break;

                                        case DialogResult.Yes:
                                            auxdCompra.Id_compra = int.Parse(cbxCompra.SelectedValue.ToString());
                                            auxdCompra.Cantidad = int.Parse(txtCantidad.Text);
                                            auxdCompra.Descripcion = txtDes.Text;
                                            auxdCompra.Id_producto = int.Parse(cbxProd.SelectedValue.ToString());
                                            auxdCompra.Total = int.Parse(txtTotal.Text);
                                            if (dCompra.ingresarDetalleCompra(auxdCompra) > 0)
                                            {
                                                //auxCompra.Id_det_compra = dCompra.consultarDetCompra(txtDes.Text, int.Parse(cbxProd.SelectedValue.ToString()));
                                                //if (compra.ingresarCompra(auxCompra)>0)
                                                //{

                                                MessageBox.Show("Detalle Compra Ingresada");
                                                txtCantidad.Text = "";
                                                txtDes.Text = "";
                                                txtTotal.Text = "";
                                                cbxCompra.SelectedIndex = -1;
                                                cargarCompras();
                                                cbxProd.SelectedIndex = -1;
                                                cargarGrillaDetCompra();
                                                dtpFechaCompra.Value = DateTime.Now;
                                                txtMontoT.Text = "";
                                                
                                                
                                                //dtpfecha.Value = DateTime.Now;
                                                
                                                
                                                //btningresarCompra.Enabled = true;
                                                //cargarGrilla();
                                                //}
                                                //else
                                                //{
                                                //    MessageBox.Show("Error al ingresar compra");
                                                //}
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error al ingresar detalle compra");
                                            }
                                            break;
                                    }
                                }
                            //}
                            //else
                            //{
                            //    MessageBox.Show("La compra ya existe");
                            //}
                        }
                        else
                        {
                            MessageBox.Show("Ingrese datos válidos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione las listas");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese todos los campos");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error, intentelo nuevamente");
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private Boolean validaCampoVacio(TextBox campo)
        {
            if (String.IsNullOrEmpty(campo.Text.Trim()))
            {
                return true;
            }
            else
            {
                //focusComponente(campo);
                return false;
            }
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

        private void btnVolverr_Click(object sender, EventArgs e)
        {
            IngresarCompra compra = new IngresarCompra();
            compra.Show();
            Hide();
        }

        private void cbxCompra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            NegocioCompra compra = new NegocioCompra();
            Compra auxCompra = new Compra();
            auxCompra = compra.consultarPorId(int.Parse(cbxCompra.SelectedValue.ToString()));            
            txtMontoT.Text = auxCompra.MontoTotal.ToString();
            dtpFechaCompra.Value = auxCompra.Fecha;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            txtCantidad.MaxLength = 38;
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtTotal.MaxLength = 38;
        }

        private void txtDes_TextChanged(object sender, EventArgs e)
        {
            txtDes.MaxLength = 100;
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
