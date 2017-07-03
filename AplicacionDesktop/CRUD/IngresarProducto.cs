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
    public partial class IngresarProducto : Form
    {
        public IngresarProducto()
        {
            InitializeComponent();
            cargarCombobox();
        }
        public void cargarCombobox()
        {
            NegocioProveedor prov = new NegocioProveedor();
            try
            {
                if (prov.listarProveedor() != null)
                {
                   
                    cbxProveedor.DataSource = prov.listarProveedor();
                    //validar q contenga datos
                    cbxProveedor.DisplayMember = "razon_social";
                    cbxProveedor.ValueMember = "id_proveedor";

                    cbxProveedor.SelectedIndex = -1;
                    if (cbxProveedor.SelectedIndex == -1)
                    {
                        cbxProveedor.Text = "Seleccione un Proveedor";
                    }
                    Dictionary<string, string> categoria = new Dictionary<string, string>();
                    categoria.Add("CURACION", "CURACION");
                    categoria.Add("PA", "PRIMERO AUXILIOS");
                    categoria.Add("ELEMENTOS", "ELEMENTOS");
                    categoria.Add("INSUMOS", "INSUMOS");
                    cbxCategoria.DisplayMember = "Value";
                    cbxCategoria.ValueMember = "Key";
                    cbxCategoria.DataSource = categoria.ToArray();
                    cbxCategoria.SelectedIndex = -1;
                    if (cbxCategoria.SelectedIndex == -1)
                    {
                        cbxCategoria.Text = "Seleccione Categoria";
                    }
                    Dictionary<string, string> tipo = new Dictionary<string, string>();
                    tipo.Add("1", "");
                    tipo.Add("2 "," ");
                    tipo.Add("3", "");
                    tipo.Add("4", "");
                    cbxTipo.DisplayMember = "Value";
                    cbxTipo.ValueMember = "Key";
                    cbxTipo.DataSource = categoria.ToArray();
                    cbxTipo.SelectedIndex = -1;
                    if (cbxTipo.SelectedIndex == -1)
                    {
                        cbxTipo.Text = "Seleccione Tipo";
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos, ingrese un proveedor");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error intentelo nuevamente");
            }

        }
        private void cargarGrilla()
        {
            NegocioProducto producto = new NegocioProducto();
            if (producto.listarProductos() != null)
            {

                dataGridView1.DataSource = producto.listarProductos();
                dataGridView1.ReadOnly = true;
                dataGridView1.Columns[0].HeaderText = "CATEGORIA";
                dataGridView1.Columns[1].HeaderText = "ID PRODUCTO";
                dataGridView1.Columns[2].HeaderText = "ID PROVEEDOR";
                dataGridView1.Columns[3].HeaderText = "NOMBRE";
                dataGridView1.Columns[4].HeaderText = "PRECIO";
                dataGridView1.Columns[5].HeaderText = "TIPO";
                //dataGridView1.Columns[2].Visible = false;
                dataGridView1.Update();

            }
            else
            {
                MessageBox.Show("No hay datos ingresados");
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioProducto producto = new NegocioProducto();
                Producto auxProducto = new Producto();
                if (txtNombre.Text!="" & txtPrecio.Text !="")
                {
                    if (cbxCategoria.SelectedIndex !=-1 & cbxTipo.SelectedIndex!=-1&cbxProveedor.SelectedIndex!=-1)
                    {
                        if (!validaCampoVacio(txtNombre)&int.Parse(txtPrecio.Text)>0)
                        {

                            auxProducto.Nombre = txtNombre.Text.ToUpper().ToString();
                            if (producto.consultarProductoPorNombre(txtNombre.Text.ToUpper().ToString())==0)
                            {
                                DialogResult dialogResult = MessageBox.Show("Desea agregar el producto: " + txtNombre.Text, "Información", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    auxProducto.Id_proveedor = int.Parse(cbxProveedor.SelectedValue.ToString());
                                    auxProducto.Nombre = txtNombre.Text.ToUpper().ToString();
                                    auxProducto.Precio = int.Parse(txtPrecio.Text);
                                    auxProducto.Tipo = cbxTipo.SelectedValue.ToString();
                                    auxProducto.Categoria = cbxCategoria.SelectedValue.ToString();
                                    DialogResult result = MessageBox.Show("Se ingresara el producto ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                    switch (result)
                                    {
                                        case DialogResult.Yes:
                                            if (producto.ingresarProducto(auxProducto)>0)
                                            {
                                                MessageBox.Show("Producto Ingresado");
                                                cargarCombobox();
                                                txtNombre.Text = "";
                                                txtPrecio.Text = "";
                                                cargarGrilla();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error al ingresar Producto");
                                            }
                                            break;
                                        case DialogResult.No:
                                            break;

                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("El producto ya existe");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese datos válidos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione todos las listas");
                    }
                }
                else
                {
                    MessageBox.Show("Complete todos los campos");
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error intentelo nuevamente");
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
        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdminProductos menu = new MenuAdminProductos();
            menu.Show();
            Hide();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.MaxLength = 100;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            txtPrecio.MaxLength = 38;
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtNombre.Text, @"^[A-Z0-9 a-z]*$")) && (txtNombre.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtNombre.Focus();
                txtNombre.Text = "";
            }
        }
    }
}
