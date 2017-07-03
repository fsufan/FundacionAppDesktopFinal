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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDesktop.CRUD
{
    public partial class EliminarCompra : Form
    {
        public EliminarCompra()
        {
            InitializeComponent();
            cargarCombobox();
        }
        public EliminarCompra(string rol)
        {
            InitializeComponent();
            cargarCombobox();
            lblRol.Text = rol;
            lblRol.Visible = false;
            
        }
        public void cargarCombobox()
        {
            NegocioCompra compra = new NegocioCompra();
            try
            {
                if (compra.listarCompras() != null)
                {
                    cbxProducto.DataSource = compra.listarCompras();
                    //validar q contenga datos
                    cbxProducto.DisplayMember = "descripcion";
                    cbxProducto.ValueMember = "id_compra";

                    cbxProducto.SelectedIndex = -1;
                    if (cbxProducto.SelectedIndex == -1)
                    {
                        cbxProducto.Text = "Seleccione una Compra";
                    }
                }
                else
                {
                    MessageBox.Show("No hay Compras ingresadas");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay Compras ingresadas");
                btnEliminar.Enabled = false;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Compra auxCompra = new Compra();
            NegocioCompra auxNCompra = new NegocioCompra();
            try
            {
                if (auxNCompra.listarCompras() != null)
                {
                    auxCompra.Id_compra = int.Parse(cbxProducto.SelectedValue.ToString());
                    DialogResult result = MessageBox.Show("Está intentando eliminar. Si continua el proceso, se eliminaran TODOS los datos asociados a este. Desea continuar?", "Atención!. Lea cuidadosamente.", MessageBoxButtons.YesNo);

                    switch (result)
                    {
                        case DialogResult.Yes:

                            if (auxNCompra.eliminarCompra(auxCompra.Id_compra) > 0)
                            {
                                MessageBox.Show("Eliminado.", "Información");
                                cargarCombobox();
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar");
                            }

                            break;
                        case DialogResult.No:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos ingresados");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error intentelo nuevamente");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdminCompra mCompra = new MenuAdminCompra(lblRol.Text);
            mCompra.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdminCompra mCompra = new MenuAdminCompra(lblRol.Text);
            mCompra.Show();
            Hide();
        }
    }
}
