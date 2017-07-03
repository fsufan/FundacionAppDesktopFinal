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
using CapaNegocio.NegocioResidente;

namespace AplicacionDesktop.CRUDUsuario
{
    public partial class ListarResidente : Form
    {
        public ListarResidente()
        {
            InitializeComponent();
            cargar();
            
        }

        private void cargar()
        {
            
            NegocioResidente auxResidente = new NegocioResidente();
            //NegocioInfoPersonal auxInfoP = new NegocioInfoPersonal();

            try
            {
                if (auxResidente.listarResidenteALL().Length > 0)
                {

                    dataGridView1.DataSource = auxResidente.listarResidenteALL();
                    dataGridView1.Columns[4].Visible = false;
                    
                    dataGridView1.Update();

                }
                else
                {
                    MessageBox.Show("No hay datos ingresados");
                    
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No hay datos ingresados");
                
            }           

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdminResidentes MAR = new MenuAdminResidentes();
            MAR.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
