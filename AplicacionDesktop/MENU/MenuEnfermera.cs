using AplicacionDesktop.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDesktop.MENU
{
    public partial class MenuEnfermera : Form
    {
        public MenuEnfermera()
        {
            InitializeComponent();
        }
        public MenuEnfermera(string rol)
        {
            InitializeComponent();
            lblEnf.Visible = false;
            lblEnf.Text = rol;
            if (rol.Equals("PARAMEDICO"))
	        {
                lbltit.Text = "Bienvenido Paramedico";
            }
            else
            {
                lbltit.Text = "Bienvenida Enfermera";
            }
            
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Seguro que desea cerrar?", "Cerrar", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:

                    InicioSesion ise = new InicioSesion();
                    ise.Show();
                    this.Hide();

                    break;
                case DialogResult.No:
                    break;


            }
           
        }

        private void btnFicP_Click(object sender, EventArgs e)
        {
            ModificarFichaResidente FR = new ModificarFichaResidente(lblEnf.Text);
            FR.Show();

        }

        private void btnGestionarParame_Click(object sender, EventArgs e)
        {
            MenuAdminSolicitudMedica MSM = new MenuAdminSolicitudMedica(lblEnf.Text);
            MSM.Show();
        }
    }
}
