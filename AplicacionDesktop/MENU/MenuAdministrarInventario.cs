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
using Capa_DTO.Usuario;
using CapaNegocio.NegocioUsuario;

namespace AplicacionDesktop.MENU
{
    public partial class MenuAdministrarInventario : Form
    {
        

        public MenuAdministrarInventario()
        {
            InitializeComponent();
            
            
        }
        public MenuAdministrarInventario(string rol)
        {
            InitializeComponent();

            
            lblRol.Text = rol;
            lblRol.Visible = false;
        }

        private void btnIngresarI_Click(object sender, EventArgs e)
        {
            IngresarInventario inv = new IngresarInventario(lblRol.Text);
            inv.Show();
            Hide();

        }

        private void btnListarI_Click(object sender, EventArgs e)
        {
            ListarInventario inv = new ListarInventario(lblRol.Text);
            inv.Show();
            Hide();
        }

        private void btnModificarI_Click(object sender, EventArgs e)
        {
            ModificarInventario inv = new ModificarInventario(lblRol.Text);
            inv.Show();
            Hide();
        }

        private void btnEliminarI_Click(object sender, EventArgs e)
        {
            EliminarInventario inv = new EliminarInventario(lblRol.Text);
            inv.Show();
            Hide();
        }

        private void btnVolverI_Click(object sender, EventArgs e)
        {
              
            MenuSupervisor menu = new MenuSupervisor();
            

            
            
           // ini.SendToBack();
            if (lblRol.Text.Equals("SUPERVISOR"))
            {
                menu.Show();
                Hide(); 
            }else
            {
                DialogResult result = MessageBox.Show("¿Desea volver al inicio de sesión?", "Cerrar sesión", MessageBoxButtons.YesNo);
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

           
        }
    }
}
