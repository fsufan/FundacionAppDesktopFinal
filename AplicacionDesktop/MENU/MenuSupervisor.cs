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
using AplicacionDesktop;
using AplicacionDesktop.CRUD;

namespace AplicacionDesktop.MENU
{
    public partial class MenuSupervisor : Form
    {
        public MenuSupervisor()
        {
            InitializeComponent();
            //btnAdSolicitudMed.Enabled = false;
            //btnGRG.Enabled = false;
            //btnFicPS.Enabled = false;
        }
        
        public MenuSupervisor(string supervisor)
        {
            InitializeComponent();
            lblsupervisor.Text = supervisor.ToString();
            lblsupervisor.Visible = false;
        }
        private void btnAdMedicina_Click(object sender, EventArgs e)
        {
            MenuAdminMedicamentos menuMed = new MenuAdminMedicamentos();
            menuMed.Show();
            Hide();
            
        }

        private void btnAdProducto_Click(object sender, EventArgs e)
        {
            MenuAdminProductos menuProd = new MenuAdminProductos();
            menuProd.Show();
            Hide();
        }

        private void btnAdInventario_Click(object sender, EventArgs e)
        {
            MenuAdministrarInventario menuInv = new MenuAdministrarInventario(lblsupervisor.Text);
            menuInv.Show();
            Hide();
        }

        private void btnAdProveedor_Click(object sender, EventArgs e)
        {
            MenuAdminProveedor menuProv = new MenuAdminProveedor(lblsupervisor.Text);
            menuProv.Show();
            Hide();
        }

        private void btnAdCompra_Click(object sender, EventArgs e)
        {
            MenuAdminCompra menuCompra = new MenuAdminCompra(lblsupervisor.Text);
            menuCompra.Show();
            Hide();
        }

        private void btnAdSolicitudMed_Click(object sender, EventArgs e)
        {
            MenuAdminSolicitudMedica menuSMed = new MenuAdminSolicitudMedica(lblsupervisor.Text);
            menuSMed.Show();
            Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Seguro que desea cerrar?", "Cerrar", MessageBoxButtons.YesNo);

            switch (result)
            {
                case DialogResult.Yes:
                    InicioSesion ini = new InicioSesion();
                    ini.Show();
                    Hide();

                    break;
                case DialogResult.No:
                    break;

            }
        }

        private void btnFicPS_Click(object sender, EventArgs e)
        {
            ModificarFichaResidente MR = new ModificarFichaResidente(lblsupervisor.Text);
            MR.Show();
        }

        private void btnGRG_Click(object sender, EventArgs e)
        {
            MenuGenerarReportesG MR = new MenuGenerarReportesG(lblsupervisor.Text);
            MR.Show();
        }
    }
}
