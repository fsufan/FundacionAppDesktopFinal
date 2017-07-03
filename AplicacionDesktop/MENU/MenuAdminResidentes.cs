using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionDesktop.CRUDUsuario;
using AplicacionDesktop.MENU;

namespace AplicacionDesktop.MENU
{
    public partial class MenuAdminResidentes : Form
    {
        public MenuAdminResidentes()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            IngresarResidente IR = new IngresarResidente();
            IR.Show();
            Hide();
            
        }

        private void btnListarU_Click(object sender, EventArgs e)
        {
            ListarResidente LR = new ListarResidente();
            LR.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuSupervisor MS = new MenuSupervisor();
            MS.Show();
            Hide();

            MenuEnfermera MPM = new MenuEnfermera();
        }

        private void btnModificarU_Click(object sender, EventArgs e)
        {
            ModificarResidente MR = new ModificarResidente();
            MR.Show();
            Hide();
        }

        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            EliminarResidente ER = new EliminarResidente();
            ER.Show();
            Hide();
        }
    }
}
