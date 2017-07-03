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
    public partial class MenuAdminEnfermera : Form
    {
        public MenuAdminEnfermera()
        {
            InitializeComponent();
        }

        private void btnVolverE_Click(object sender, EventArgs e)
        {
            MenuAdminPersonal MAP = new MenuAdminPersonal();
            MAP.Show();
            this.Hide();
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            EliminarEnfermera EE = new EliminarEnfermera();
            EE.Show();
            this.Hide();
        }

        private void btnListarP_Click(object sender, EventArgs e)
        {
            ListarEnfermera LE = new ListarEnfermera();
            LE.Show();
            this.Hide();
        }

        private void btnIngresarE_Click(object sender, EventArgs e)
        {
            InsertarEnfermera IE = new InsertarEnfermera();
            IE.Show();
            this.Hide();
        }

        private void btnModificarP_Click(object sender, EventArgs e)
        {
            ModificarEnfermera ME = new ModificarEnfermera();
            ME.Show();
            this.Hide();
        }
    }
}
