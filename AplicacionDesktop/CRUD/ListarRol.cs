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

using AplicacionDesktop.MENU;
using CapaNegocio.NegocioUsuario;


namespace AplicacionDesktop.CRUD
{
    public partial class ListarRol : Form

    {
        CapaNegocio.webServiceFundacion.webServiceFundacion webF = new CapaNegocio.webServiceFundacion.webServiceFundacion();
        public ListarRol()
        {
            InitializeComponent();
            cargar();
        }

        public void cargar()
        {
           

            NegocioRol rol = new NegocioRol();
            
            if (rol.listarRoles()!=null)
            {
                dtlistarroles.DataSource = rol.listarRoles();
            }
            else
            {
                MessageBox.Show("No hay roles registrados");
            }
            //CapaNegocio.webServiceFundacion.webServiceFundacion wsr = new CapaNegocio.webServiceFundacion.webServiceFundacion();
            //Array objeto = wsr.listadoRol();

            //if (webF.listadoRol() == null)
            //    //(rol.listarRoles().Length > 0)
            //{
            //    dtlistarroles.DataSource = webF.listadoRol();
            //    dtlistarroles.ReadOnly = true;
            //    dtlistarroles.Update();
            //}
            //else
            //{
            //    MessageBox.Show("No hay roles registrados");
            //}
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuRol mr = new MenuRol();
            mr.Show();
            Hide();
        }
    }
}
