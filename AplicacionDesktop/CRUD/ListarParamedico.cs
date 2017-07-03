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
    public partial class ListarParamedico : Form
    {
        public ListarParamedico()
        {
            InitializeComponent();
            cargarGrilla();
        }

        public void cargarGrilla()
        {
            try
            {
                NegocioParamedico auxParamedico = new NegocioParamedico();
                if (auxParamedico.listarParamedico() != null)
                {
                    dataGridView1.DataSource = auxParamedico.listarParamedico();
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
            MenuAdminParamedico MAP = new MenuAdminParamedico();
            MAP.Show();
            this.Hide();
        }
    }
}
