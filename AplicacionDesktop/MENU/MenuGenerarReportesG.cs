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
    public partial class MenuGenerarReportesG : Form
    {
        public MenuGenerarReportesG()
        {
            InitializeComponent();
        }
        public MenuGenerarReportesG(string rol)
        {
            InitializeComponent();
            lblRol.Text = rol;
            lblRol.Visible = false;
        }

        

        private void btnReporteIngresos_Click(object sender, EventArgs e)
        {
            ReporteIngresos RI = new ReporteIngresos(lblRol.Text);
            RI.Show();
            this.Close();
        }

        private void btnCargosAportadores_Click(object sender, EventArgs e)
        {
            PlanillaCargosAportadores PCA = new PlanillaCargosAportadores(lblRol.Text);
            PCA.Show();
            this.Close();
        }

        

        private void btnVolverF_Click(object sender, EventArgs e)
        {
            MenuSupervisor MR = new MenuSupervisor(lblRol.Text);
            MR.Show();
        }

        
    }
}
