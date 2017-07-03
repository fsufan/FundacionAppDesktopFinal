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

namespace AplicacionDesktop.MENU
{
    public partial class MenuAdminParamedico : Form
    {
        public MenuAdminParamedico()
        {
            InitializeComponent();
        }

        private void btnVolverP_Click(object sender, EventArgs e)
        {
            MenuAdminPersonal MAP = new MenuAdminPersonal();
            MAP.Show();
            this.Hide();
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            EliminarParamedico EP = new EliminarParamedico();
            EP.Show();
            this.Hide();
        }

        private void btnListarP_Click(object sender, EventArgs e)
        {
            ListarParamedico LP = new ListarParamedico();
            LP.Show();
            this.Hide();
        }

        private void btnIngresarP_Click(object sender, EventArgs e)
        {
            InsertarParamedico IP = new InsertarParamedico();
            IP.Show();
            this.Hide();
        }

        private void btnModificarP_Click(object sender, EventArgs e)
        {
            ModificarParamedico MP = new ModificarParamedico();
            MP.Show();
            this.Hide();
        }
    }
}
