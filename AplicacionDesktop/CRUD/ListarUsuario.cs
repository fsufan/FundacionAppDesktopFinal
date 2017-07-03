using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionDesktop.CRUD;
using CapaNegocio.NegocioUsuario;
using AplicacionDesktop.MENU;

namespace AplicacionDesktop.CRUDUsuario
{
    public partial class ListarUsuario : Form
    {
        public ListarUsuario()
        {
            InitializeComponent();
            cargar();
        }

        public void cargar()
        {
            NegocioUsuario usuario = new NegocioUsuario();
            if (usuario.listarUsuarios()!=null)
            {
                dtListar.DataSource = usuario.listarUsuarios();
                dtListar.ReadOnly = true;
                dtListar.Update();
            }
            else
            {
                MessageBox.Show("No hay usuarios registrados");
            }
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuUsuario mu = new MenuUsuario();
            mu.Show();
            Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void dtListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
