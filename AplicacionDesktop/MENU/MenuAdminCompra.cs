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
    public partial class MenuAdminCompra : Form
    {
        public MenuAdminCompra()
        {
            InitializeComponent();
        }
        public MenuAdminCompra(string rol)
        {
            InitializeComponent();
            lblRol.Text = rol;
            lblRol.Visible = false;
        }
        private void btnIngresarU_Click(object sender, EventArgs e)
        {
            IngresarCompra compra = new IngresarCompra(lblRol.Text);
            compra.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarCompras compra = new ListarCompras(lblRol.Text);
            compra.Show();
            Hide();
        }

        private void btnModificarU_Click(object sender, EventArgs e)
        {
            ModificarCompra compra = new ModificarCompra(lblRol.Text);
            compra.Show();
            Hide();
        }

        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            EliminarCompra compra = new EliminarCompra(lblRol.Text);
            compra.Show();
            Hide();
        }

        private void btnVolverU_Click(object sender, EventArgs e)
        {
            MenuSupervisor menu = new MenuSupervisor(lblRol.Text);
            menu.Show();
            Hide();
            //MenuAdmin menu = new MenuAdmin();
            //menu.Show();
            //Hide();
        }
    }
}
