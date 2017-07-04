using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionDesktop.MENU;
using CapaNegocio.NegocioUsuario;

namespace AplicacionDesktop.CRUD
{
    public partial class ListarEnfermera : Form
    {
        public ListarEnfermera()
        {
            InitializeComponent();
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            try
            {
                NegocioEnfermera auxEnfermera = new NegocioEnfermera();
                if (auxEnfermera.listarEnfermera() != null)
                {
                    dataGridView1.DataSource = auxEnfermera.listarEnfermera();
                    dataGridView1.ReadOnly = true;

                    dataGridView1.Update();
                }
                else
                {
                    MessageBox.Show("No hay datos Ingresados");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay datos Ingresados");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdminEnfermera MAP = new MenuAdminEnfermera();
            MAP.Show();
            this.Hide();
        }
    }
}
