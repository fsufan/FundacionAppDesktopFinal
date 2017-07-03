using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.NegocioUsuario;
using Capa_DTO.Usuario;
using AplicacionDesktop.CRUD;
using AplicacionDesktop.MENU;

namespace AplicacionDesktop.CRUDUsuario
{
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
            cargarCombx();
        }

        public void cargarCombx()
        {
            NegocioUsuario usu = new NegocioUsuario();
            try
            {
                if (usu.listarUsuarios()!=null)
                {
                    cmbxid.DataSource = usu.listarUsuarios();
                    cmbxid.DisplayMember = "rut_usuario";
                    cmbxid.ValueMember = "id_usuario";

                    cmbxid.SelectedIndex = -1;
                    if (cmbxid.SelectedIndex == -1)
                    {
                        cmbxid.Text = "--Seleccione--";
                    }
                }
                else
                {
                    MessageBox.Show("No hay usuarios registrados");
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error intentelo nuevamente");
            }
        }



        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            Usuario auxUsuario = new Usuario();
            NegocioUsuario auxNegUsuario = new NegocioUsuario();
            try
            {
                if (auxNegUsuario.listarUsuarios()!=null)
                {
                    auxUsuario.IdUsuario = int.Parse(cmbxid.SelectedValue.ToString());
                    DialogResult result = MessageBox.Show("Está intentando eliminar un Usuario. Se eliminarán todos los datos asociados a este usuario. ¿Desea continuar?", "Atención", MessageBoxButtons.YesNo);

                    switch (result)
                    {
                        case DialogResult.Yes:

                            if (auxNegUsuario.eliminarUsuario(auxUsuario.IdUsuario) > 0)
                            {
                                MessageBox.Show("Usuario eliminado.", "Información");
                                cargarCombx();
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar al usuario");
                            }

                            break;
                        case DialogResult.No:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("No hay usuarios ingresados");
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Error intentelo nuevamente");
            }
        }

        private void btnVolverr_Click(object sender, EventArgs e)
        {
            MenuUsuario usu = new MenuUsuario();
            usu.Show();
            Hide();
        }


        

    }
}
