using AplicacionDesktop.MENU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.NegocioFarmacia;

namespace AplicacionDesktop.CRUD
{
    public partial class ListarSolicitudMedicamentos : Form
    {
        public ListarSolicitudMedicamentos()
        {
            InitializeComponent();
            
        }

        private void CargarGrilla()
        {
            NegocioSolicitudMed auxSolicitudM = new NegocioSolicitudMed();

            try
            {
                if (auxSolicitudM.listarSolicitudMedica() != null)
                {
                    dataGridView1.DataSource = auxSolicitudM.listarSolicitudMedica();
                    dataGridView1.ReadOnly = true;

                    dataGridView1.Update();
                }
                else
                {
                    MessageBox.Show("No hay Solicitudes Medicas Ingresadas");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No hay Solicitudes Medicas Ingresadas");
            }
        }
        public ListarSolicitudMedicamentos(string rol)
        {
            InitializeComponent();
            CargarGrilla();
            lblRol.Text = rol;
            lblRol.Visible = false;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuSupervisor MS = new MenuSupervisor();
            MenuEnfermera ME = new MenuEnfermera();
            if (lblRol.Text.Equals("SUPERVISOR"))
            {
                MS.Show();
            }
            else
            {
                ME.Show();
            }
        }
    }
}
