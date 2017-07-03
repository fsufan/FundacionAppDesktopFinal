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
    public partial class MenuAdminProveedor : Form
    {
        public MenuAdminProveedor()
        {
            InitializeComponent();
        }
        public MenuAdminProveedor(string rol)
        {
            InitializeComponent();
            lblRol.Text = rol;
            lblRol.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ListarProveedores prov = new ListarProveedores(lblRol.Text);
            prov.Show();
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

        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            EliminarProveedor prov = new EliminarProveedor(lblRol.Text);
            prov.Show();
            Hide();
        }

        private void btnModificarU_Click(object sender, EventArgs e)
        {
            ModificarProveedor prov = new ModificarProveedor(lblRol.Text);
            prov.Show();
            Hide();
        }

        private void btnIngresarU_Click(object sender, EventArgs e)
        {
            IngresarProveedor prov = new IngresarProveedor(lblRol.Text);
            prov.Show();
            Hide();
        }
    }
}
