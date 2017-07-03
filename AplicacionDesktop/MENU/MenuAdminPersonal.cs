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
    public partial class MenuAdminPersonal : Form
    {
        public MenuAdminPersonal()
        {
            InitializeComponent();
        }

        private void btnEnfermeras_Click(object sender, EventArgs e)
        {
            MenuAdminEnfermera MAE = new MenuAdminEnfermera();
            MAE.Show();
            this.Hide();
        }

        private void btnParamedico_Click(object sender, EventArgs e)
        {
            MenuAdminParamedico MAP = new MenuAdminParamedico();
            MAP.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdmin MA = new MenuAdmin();
            MA.Show();
            this.Hide();
        }
    }
}
