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
    public partial class MenuRol : Form
    {
        public MenuRol()
        {
            InitializeComponent();
            //btnIngresarR.Enabled = false;
            //btnModificar.Enabled = false;
            //btnEliminarR.Enabled = false;
        }

        private void btnIngresarR_Click(object sender, EventArgs e)
        {
            IngresarRol ingreso = new IngresarRol();
            ingreso.Show();
            Hide();
        }

        private void btnListarR_Click(object sender, EventArgs e)
        {
            ListarRol lista = new ListarRol();
            lista.Show();
            Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarRol modi = new ModificarRol();
            modi.Show();
            Hide();
        }

        private void btnEliminarR_Click(object sender, EventArgs e)
        {
            EliminarRol elimina = new EliminarRol();
            elimina.Show();
            Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdmin Mr = new MenuAdmin();
            Mr.Show();
            Hide();
        }
    }
}
