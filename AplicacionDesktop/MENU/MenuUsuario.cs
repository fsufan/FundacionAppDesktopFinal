using AplicacionDesktop.CRUDUsuario;
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
    public partial class MenuUsuario : Form
    {
        public MenuUsuario()
        {
            InitializeComponent();
           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IngresarUsuario ingresar = new IngresarUsuario();
            ingresar.Show();
            Hide();
        }

        private void btnListarU_Click(object sender, System.EventArgs e)
        {
            ListarUsuario listar = new ListarUsuario();
            listar.Show();
            Hide();
        }

        private void btnModificarU_Click(object sender, System.EventArgs e)
        {
            ModificarUsuario modificar = new ModificarUsuario();
            modificar.Show();
            Hide();
        }

        private void btnEliminarU_Click(object sender, System.EventArgs e)
        {
            EliminarUsuario eliminar = new EliminarUsuario();
            eliminar.Show();
            Hide();
        }

        private void btnVolverU_Click(object sender, System.EventArgs e)
        {

            MenuAdmin mu = new MenuAdmin();
            mu.Show();
            Hide();
        }

    }
}
