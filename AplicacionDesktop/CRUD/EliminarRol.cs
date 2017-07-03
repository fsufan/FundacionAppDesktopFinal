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
using Capa_DTO.Usuario;
using CapaNegocio.NegocioUsuario;
using AplicacionDesktop.MENU;

namespace AplicacionDesktop.CRUD
{
    public partial class EliminarRol : Form
    {
        public EliminarRol()
        {
            InitializeComponent();
            cargarCombox();
        }

        public void cargarCombox()
        {
            NegocioRol rol = new NegocioRol();
            try
            {
                if (rol.listarRoles().Length > 0)
                {
                    cmbxerol.DataSource = rol.listarRoles();
                    cmbxerol.DisplayMember = "nombre_rol";
                    cmbxerol.ValueMember = "id_rol";

                    cmbxerol.SelectedIndex = -1;
                    if (cmbxerol.SelectedIndex == -1)
                    {
                        cmbxerol.Text = "--Seleccione--";
                    }


                }
                else
                {
                    MessageBox.Show("No hay roles registrados");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error intentelo nuevamente");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Rol auxRol = new Rol();
            NegocioRol auxRole = new NegocioRol();
            try
            {
                if (auxRole.listarRoles()!=null)
                {
                    auxRol.IdRol = int.Parse(cmbxerol.SelectedValue.ToString());
                    DialogResult result = MessageBox.Show("Se eliminarán todos los datos asociados a este rol, ¿Desea continuar?", "Atención", MessageBoxButtons.YesNo);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            if (auxRole.eliminarRol(auxRol.IdRol) > 0)
                            {
                                MessageBox.Show("Rol eliminado", "Información");
                                cargarCombox();
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar el rol");
                            }
                            auxRol = auxRole.rolPorNombreMO(cmbxerol.Text);
                            if (auxRole.eliminarRolMO(auxRol.IdRol)>0)
                            {
                                MessageBox.Show("Rol Moda Outlet eliminado", "Información");
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar el rol Moda Outlet");
                            }
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("No hay roles ingresados");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error intentelo nuevamente");
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuRol mr = new MenuRol();
            mr.Show();
            Hide();
        }

        private void cmbxerol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
