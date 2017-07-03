using AplicacionDesktop.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDesktop.MENU
{
    public partial class MenuAdminProductos : Form
    {
        public MenuAdminProductos()
        {
            InitializeComponent();
        }

        private void btnIngresarU_Click(object sender, EventArgs e)
        {
            IngresarProducto prod = new IngresarProducto();
            prod.Show();
            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarProductos prod = new ListarProductos();
            prod.Show();
            Hide();
        }

        private void btnModificarU_Click(object sender, EventArgs e)
        {
            ModificarProducto prod = new ModificarProducto();
            prod.Show();
            Hide();
        }

        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            EliminarProducto prod = new EliminarProducto();
            prod.Show();
            Hide();
        }

        private void btnVolverU_Click(object sender, EventArgs e)
        {
            MenuAdmin menu = new MenuAdmin();
            menu.Show();
            Hide();
        }
    }
}
