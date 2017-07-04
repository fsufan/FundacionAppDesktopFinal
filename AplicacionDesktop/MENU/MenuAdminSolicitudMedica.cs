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
    public partial class MenuAdminSolicitudMedica : Form
    {
        public MenuAdminSolicitudMedica()
        {
            InitializeComponent();
        }
        public MenuAdminSolicitudMedica(string rol)
        {
            InitializeComponent();            
            lblSM.Text = rol;
            lblSM.Visible = false;
        }
        private void btnVolverU_Click(object sender, EventArgs e)
        {
            MenuSupervisor MS = new MenuSupervisor(lblSM.Text);
            MenuEnfermera ME = new MenuEnfermera(lblSM.Text);
            if (lblSM.Text.Equals("SUPERVISOR"))
            {
                MS.Show();
                this.Hide();
            }
            else if (lblSM.Text.Equals("ENFERMERA"))
            {
                ME.Show();
                this.Hide();
            }
           
            //MenuParamedico MP = new MenuParamedico();
        }

        private void btnIngresarU_Click(object sender, EventArgs e)
        {
            IngresarSolicitudMedicamentos SM = new IngresarSolicitudMedicamentos(lblSM.Text);
            SM.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarSolicitudMedicamentos SM = new ListarSolicitudMedicamentos(lblSM.Text);
            SM.Show();
            this.Hide();
        }

        private void btnModificarU_Click(object sender, EventArgs e)
        {
            ModificarSolicitudMedicamentos SM = new ModificarSolicitudMedicamentos(lblSM.Text);
            SM.Show();
            this.Hide();
        }

        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            EliminarSolicitudMedicamentos SM = new EliminarSolicitudMedicamentos(lblSM.Text);
            SM.Show();
            this.Hide();
        }
    }
}
