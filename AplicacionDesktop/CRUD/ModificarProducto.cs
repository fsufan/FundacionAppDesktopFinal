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
    public partial class ModificarProducto : Form
    {
        public ModificarProducto()
        {
            InitializeComponent();
            cargarProductos();
        }
        private void cargarProveedor()
        { 
            NegocioProveedor prov = new NegocioProveedor();
            cbxProveedor.DataSource = prov.listarProveedor();
            cbxProveedor.DisplayMember = "razon_social";
            cbxProveedor.ValueMember = "id_proveedor";

            //cbxProveedor.SelectedIndex = -1;
            if (cbxProveedor.SelectedIndex==-1)
            {
                cbxProveedor.Text = "Seleccione un proveedor";
            }
        }
        private void cargarProductos()
        {
            NegocioProducto prod = new NegocioProducto();
            if (prod.listarProductos()!=null)
            {
                cbxNombre.DataSource = prod.listarProductos();
                cbxNombre.DisplayMember = "nombre";
                cbxNombre.ValueMember = "id_producto";

                cbxNombre.SelectedIndex = -1;
                if (cbxNombre.SelectedIndex == -1)
                {
                    cbxNombre.Text = "Seleccione un producto";
                }
            }
            else
            {
                MessageBox.Show("No hay datos ingresadas");
            }
            

        }
        private void cargarTipo()
        {
            Dictionary<string, string> tipo = new Dictionary<string, string>();
            tipo.Add("1", "CURACION");
            tipo.Add("2 ", "PRIMERO AUXILIOS");
            //tipo.Add("3", "");
            //tipo.Add("4", "");
            cbxTipo.DisplayMember = "Value";
            cbxTipo.ValueMember = "Key";
            cbxTipo.DataSource = tipo.ToArray();
            //cbxTipo.SelectedIndex = -1;
            if (cbxTipo.SelectedIndex == -1)
            {
                cbxTipo.Text = "Seleccione Tipo";
            }
        }
        private void cargarCategoria()
        {
            Dictionary<string, string> categoria = new Dictionary<string, string>();
            //categoria.Add("CURACION", "CURACION");
            //categoria.Add("PA", "PRIMERO AUXILIOS");
            categoria.Add("ELEMENTOS", "ELEMENTOS");
            categoria.Add("INSUMOS", "INSUMOS");
            cbxCategoria.DisplayMember = "Value";
            cbxCategoria.ValueMember = "Key";
            cbxCategoria.DataSource = categoria.ToArray();
            //cbxCategoria.SelectedIndex = -1;
            if (cbxCategoria.SelectedIndex == -1)
            {
                cbxCategoria.Text = "Seleccione Categoria";
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdminProductos menu = new MenuAdminProductos();
            menu.Show();
            Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioProducto producto = new NegocioProducto();
                Producto auxProducto = new Producto();
                if (txtPrecio.Text != "")
                {
                    if (cbxCategoria.SelectedIndex != -1 & cbxTipo.SelectedIndex != -1 & cbxProveedor.SelectedIndex != -1 & cbxNombre.SelectedIndex!=-1)
                    {
                        if (int.Parse(txtPrecio.Text)>0&cbxNombre.Text!="")
                        {
                            //consultar producto 
                            //crear metodo ws
                            //if (producto.consultarProductoPorNombre(cbxNombre.Text)==0)
                            //{
                                DialogResult dialogResult = MessageBox.Show("Desea modificar el producto: " + cbxNombre.Text, "Información", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    auxProducto.Id_proveedor = int.Parse(cbxProveedor.SelectedValue.ToString());
                                    auxProducto.Id_producto = int.Parse(cbxNombre.SelectedValue.ToString());
                                    auxProducto.Nombre = cbxNombre.Text.ToUpper().ToString();
                                    auxProducto.Precio = int.Parse(txtPrecio.Text);
                                    auxProducto.Tipo = cbxTipo.SelectedValue.ToString();
                                    auxProducto.Categoria = cbxCategoria.SelectedValue.ToString();
                                    DialogResult result = MessageBox.Show("Se modificar el producto ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                    switch (result)
                                    {
                                        case DialogResult.Yes:
                                            if (producto.actualizarProducto(auxProducto) > 0)
                                            {
                                                MessageBox.Show("Producto Modificado");
                                                
                                               
                                                txtPrecio.Text = "";
                                                dataGridView1.DataSource = producto.productoPorId(auxProducto.Id_producto);
                                                cbxTipo.SelectedIndex = -1;
                                                cbxProveedor.SelectedIndex = -1;
                                                cbxCategoria.SelectedIndex = -1;
                                                cargarCategoria();
                                                cargarProductos();
                                                cargarProveedor();
                                                cargarTipo();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error al modificar Producto");
                                            }
                                            break;
                                        case DialogResult.No:
                                            break;

                                    }
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
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cbxNombre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                NegocioProducto producto = new NegocioProducto();
                Producto auxProd = new Producto();

                NegocioProveedor proveedor = new NegocioProveedor();
                Proveedor auxProv = new Proveedor();

                cargarCategoria();
                //cargarProductos();
                cargarProveedor();
                cargarTipo();

                auxProd.Id_producto = int.Parse(cbxNombre.SelectedValue.ToString());
                auxProd = producto.consultarPorId(auxProd.Id_producto);

                auxProv = proveedor.consultarPorId(auxProd.Id_proveedor);

                cbxCategoria.Text = auxProd.Categoria;
                cbxProveedor.Text = auxProv.Razon_social;
                cbxTipo.Text = auxProd.Tipo;
                txtPrecio.Text = auxProd.Precio.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar, intentelo nuevamente");
            }
           

        }

        private void cbxNombre_TextChanged(object sender, EventArgs e)
        {
            cbxNombre.MaxLength = 100;
        }

        private void cbxCategoria_TextChanged(object sender, EventArgs e)
        {
            cbxCategoria.MaxLength = 25;
        }

        private void cbxTipo_TextChanged(object sender, EventArgs e)
        {
            cbxTipo.MaxLength = 25;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            txtPrecio.MaxLength = 38;
        }

        private void cbxNombre_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.cbxNombre.Text, @"^[A-Z0-9 a-z]*$")) && (cbxNombre.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.cbxNombre.Focus();
                cbxNombre.Text = "";
            }
        }
    }
}
