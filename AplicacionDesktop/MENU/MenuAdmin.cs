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

namespace AplicacionDesktop.MENU
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
            //btnAdminP.Visible = false;
        }
        //public MenuAdmin(string admin)
        //{
        //    string var = admin;
        //    lblAdmin.Text = admin;
        //    InitializeComponent();
        //}
        private void btnAdminR_Click(object sender, EventArgs e)
        {
            MenuAdminResidentes MenuR = new MenuAdminResidentes();
            MenuR.Show();
            Hide();
        }

        private void btnAdminm_Click(object sender, EventArgs e)
        {
            MenuAdminMedicamentos ADM = new MenuAdminMedicamentos();
            ADM.Show();
            Hide();
        }

        private void btnAdminP_Click(object sender, EventArgs e)
        {
            MenuAdminProductos Mp = new MenuAdminProductos();
            Mp.Show();
            Hide();
        }

        private void btnCerrarAdmin_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("¿Seguro que desea cerrar?", "Cerrar", MessageBoxButtons.YesNo);
             switch (result)
            {
                case DialogResult.Yes:
                    
                    InicioSesion ise = new InicioSesion();
                    ise.Show();
                    Hide();
                    
                    break;
                case DialogResult.No:
                    break;
                   
  
            }
           
        }

        private void btnAdminu_Click(object sender, EventArgs e)
        {
            MenuUsuario mu = new MenuUsuario();
            mu.Show();
            Hide();
            
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            MenuRol menu = new MenuRol();
            menu.Show();
        }

        private void btnAdministarP_Click(object sender, EventArgs e)
        {
            MenuAdminPersonal MAP = new MenuAdminPersonal();
            MAP.Show();
            this.Hide();
        }
    }
}
