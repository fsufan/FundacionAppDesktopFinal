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
using CapaNegocio.NegocioFarmacia;
using Capa_DTO.Farmacia;

namespace AplicacionDesktop.CRUD
{
    public partial class EliminarSolicitudMedicamentos : Form
    {
        public EliminarSolicitudMedicamentos()
        {
            InitializeComponent();
        }

        public void CargarCombo()
        {
            NegocioSolicitudMed auxSolicitudM = new NegocioSolicitudMed();
            try
            {
                if (auxSolicitudM.listarSolicitudMedica() != null)
                {
                    cboidSolMedica.DataSource = auxSolicitudM.listarSolicitudMedica();
                    cboidSolMedica.DisplayMember = "ID_SOLIC_MED";
                    cboidSolMedica.ValueMember = "ID_SOLIC_MED";

                    cboidSolMedica.SelectedIndex = -1;
                    if (cboidSolMedica.SelectedIndex == -1)
                    {
                        cboidSolMedica.Text = "Seleccione Id Soliditud";
                    }
                }
                else
                {
                    MessageBox.Show("No hay Solicitudes Medicas Ingresadas");
                    BtnEliminar.Enabled = false;
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay Solicitudes Medicas Ingresadas");
                BtnEliminar.Enabled = false;
            }
        }

        public EliminarSolicitudMedicamentos(string rol)
        {
            InitializeComponent();
            CargarCombo();
            lblRol.Text = rol;
            lblRol.Visible = false;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuSupervisor MS = new MenuSupervisor();
            MenuEnfermera ME = new MenuEnfermera();
            if (lblRol.Text.Equals("SUPERVISOR"))
            {
                MS.Show();
            }
            else
            {
                ME.Show();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            NegocioSolicitudMed auxSolMedica = new NegocioSolicitudMed();
            SolicitudMedica solicitudM = new SolicitudMedica();

            try
            {
                if (auxSolMedica.listarSolicitudMedica().Length > 0)
                {
                    solicitudM.Id_solic_med = int.Parse((cboidSolMedica.SelectedValue.ToString()));

                    DialogResult Resultado = MessageBox.Show("Esta intentando Eliminar. Si continua el proceso, se Eliminaran TODOS los Datos Asociados a este ID. Desea Continuar?","Atencion",MessageBoxButtons.YesNo);
                    switch (Resultado)
                    {
                        case DialogResult.Abort:
                            break;
                        case DialogResult.Cancel:
                            break;
                        case DialogResult.Ignore:
                            break;
                        case DialogResult.No:
                            break;
                        case DialogResult.None:
                            break;
                        case DialogResult.OK:
                            break;
                        case DialogResult.Retry:
                            break;
                        case DialogResult.Yes:
                            if (auxSolMedica.eliminarSolicitudMedica(solicitudM.Id_solic_med) > 0)
                            {
                                MessageBox.Show("Eliminado","Informacion");
                                CargarCombo();
                            }
                            else
                            {
                                MessageBox.Show("Error al Eliminar la Solicitud Medica"); 
                            }
                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("No hay Solicitudes Medicas Ingresadas");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No a seleccionado ninguna Solicitud Medica");
            }
            
        }
    }
}
