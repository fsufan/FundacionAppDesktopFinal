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
using Capa_DTO.Usuario;
using Capa_DTO.Farmacia;
using Capa_DTO.Medicamento;
using Capa_DTO.Residente;
using CapaNegocio.NegocioResidente;
using CapaNegocio.NegocioUsuario;
using System.Text.RegularExpressions;

namespace AplicacionDesktop.CRUD
{
    public partial class ModificarSolicitudMedicamentos : Form
    {
        public ModificarSolicitudMedicamentos()
        {
            InitializeComponent();
        }

        public void CargarIDSolicitud()
        {
            NegocioSolicitudMed auxSoliMed = new NegocioSolicitudMed();
            try
            {
                if (auxSoliMed.listarSolicitudMedica() != null)
                {
                    cboIDSolicitud.DataSource = auxSoliMed.listarSolicitudMedica();
                    cboIDSolicitud.DisplayMember = "ID_SOLIC_MED";
                    cboIDSolicitud.ValueMember = "ID_SOLIC_MED";

                    cboIDSolicitud.SelectedIndex = -1;
                    if (cboIDSolicitud.SelectedIndex == -1)
                    {
                        cboIDSolicitud.Text = "Seleccione ID Solicitud Medica";
                    }

                }
                else
                {
                    MessageBox.Show("No hay Solicitudes Medicas Ingresadas");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No hay Solicitudes Medicas Ingresadas");
            }
        }

        private void CargarMedicina()
        {
            NegocioMedicina medic = new NegocioMedicina();
            try
            {
                if (medic.listarMedicinas() != null)
                {
                    cboMedicina.DataSource = medic.listarMedicinas();
                    //validar q contenga datos
                    cboMedicina.DisplayMember = "nom_comercial";
                    cboMedicina.ValueMember = "id_medicina";

                    cboMedicina.SelectedIndex = -1;
                    if (cboMedicina.SelectedIndex == -1)
                    {
                        cboMedicina.Text = "Seleccione una Medicina";
                    }
                }
                else
                {
                    MessageBox.Show("No hay medicinas ingresadas");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No hay medicinas ingresadas");

            }
        }

        public void cargarEstado(String estado)
        {
            try
            {
                Dictionary<string, string> DEstado = new Dictionary<string, string>();
                DEstado.Add("1", "En Espera");
                DEstado.Add("2", "Rechazada");
                DEstado.Add("3", "Aprobada");

                cboEstado.DisplayMember = "Value";
                cboEstado.ValueMember = "Value";
                cboEstado.DataSource = DEstado.ToArray();

                if (estado.ToUpper().ToString().Equals("En Espera"))
                {
                    cboEstado.Text = "En Espera";
                }
                else if (estado.ToUpper().ToString().Equals("Rechazada"))
                {
                    cboEstado.Text = "Rechazada";
                }
                else if (estado.ToUpper().ToString().Equals("Aprobada"))
                {
                    cboEstado.Text = "Aprobada";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        public ModificarSolicitudMedicamentos(string rol)
        {
            InitializeComponent();
            CargarIDSolicitud();
            CargarMedicina();
            lblRol.Text = rol;
            lblRol.Visible = false;
            txtRutParamedico.Enabled = false;
            txtRutResidente.Enabled = false;
            txtRutEnfermera.Enabled = false;
            lblDetaSolidMed.Visible = false;
            lblidFichaR.Visible = false;
            lblidParamedico.Visible = false;
            lblidDetaSolicitud.Visible = false;
            lblidEnfermera.Visible = false;
            dateFechaSolicitud.Enabled = false;
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioSolicitudMed auxSoliMed = new NegocioSolicitudMed();
                SolicitudMedica SoliMedica = new SolicitudMedica();
                DetalleSolicitud detaSoli = new DetalleSolicitud();
                NegocioDetalleSolicitud auxDetaSoli = new NegocioDetalleSolicitud();
                DetalleSolicitudMedica detaSoliMed = new DetalleSolicitudMedica();
                NegocioDetalleSolictudMed auxDetaSoliMed = new NegocioDetalleSolictudMed();
                Medicina medicina = new Medicina();
                NegocioMedicina auxMedicina = new NegocioMedicina();

                if (txtCantidad.Text != "" && txtCuidadosEspe.Text != "" && txtMotivo.Text != "")
                {

                    if (cboMedicina.SelectedIndex != -1 && cboEstado.SelectedIndex != -1)
                    {
                        medicina = auxMedicina.consultarPorIdMedicina(int.Parse(cboMedicina.SelectedValue.ToString()));
                        DialogResult dialogResult = MessageBox.Show("Desea Ingresar una Solicitud Medica para el medicamento :" + medicina.Nom_comercial, "Informacion", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            DialogResult resultado = MessageBox.Show("Se Ingresara la Solicitud Medica ¿Desea Continuar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            
                            switch (resultado)
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

                                    detaSoli.Id_det_solicitud = int.Parse(lblidDetaSolicitud.Text);
                                    detaSoli.Cantidad = int.Parse(txtCantidad.Text);
                                    detaSoli.Fecha = dateFechaSolicitud.Value;
                                    detaSoli.Id_medicina = int.Parse(cboMedicina.SelectedValue.ToString());
                                    if (auxDetaSoli.actualizarDetSolicirud(detaSoli) > 0)
                                    {
                                        detaSoliMed.Id_det_solic_med = int.Parse(lblDetaSolidMed.Text);
                                        detaSoliMed.Estado_solicitud = cboEstado.SelectedValue.ToString();
                                        detaSoliMed.Motivo = txtMotivo.Text;
                                        detaSoliMed.Cuidados_espe = txtCuidadosEspe.Text;

                                        if (auxDetaSoliMed.actualizarDtSolMed(detaSoliMed) > 0)
                                        {
                                            SoliMedica.Id_solic_med = int.Parse(cboIDSolicitud.SelectedValue.ToString());
                                            SoliMedica.Id_det_solic_med = int.Parse(lblDetaSolidMed.Text);
                                            SoliMedica.Id_fic_residente = int.Parse(lblidFichaR.Text);
                                            SoliMedica.Id_enfermera = int.Parse(lblidEnfermera.Text);
                                            SoliMedica.Id_paramedico = int.Parse(lblidParamedico.Text);
                                            SoliMedica.Id_det_solicitud = int.Parse(lblidDetaSolicitud.Text);

                                            if (auxSoliMed.actualizarSolicitudMedica(SoliMedica) > 0)
                                            {

                                                txtRutEnfermera.Text = string.Empty;
                                                txtRutParamedico.Text = string.Empty;
                                                txtRutResidente.Text = string.Empty;
                                                lblNombreEnfermera.Text = string.Empty;
                                                lblApellidoEnfermera.Text = string.Empty;
                                                lblidEnfermera.Text = string.Empty;
                                                lblNombreParamedico.Text = string.Empty;
                                                lblApellidoParamedico.Text = string.Empty;
                                                lblidParamedico.Text = string.Empty;
                                                lblNombreResidente.Text = string.Empty;
                                                lblApellidoResidente.Text = string.Empty;
                                                lblidFichaR.Text = string.Empty;
                                                txtCantidad.Text = string.Empty;
                                                txtCuidadosEspe.Text = string.Empty;
                                                txtMotivo.Text = string.Empty;
                                                cboMedicina.SelectedIndex = -1;
                                                cboEstado.SelectedIndex = -1;

                                                MessageBox.Show("Solicitud Medicina Modificada");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Solicitud medicina NO Modificada");
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Detalles Solicitud Medica no Modificada");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Detalle solicitud no Modificada");
                                    }




                                    break;
                                default:
                                    break;
                            }
                        }






                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar en informacion en todas las listas");
                    }



                }
                else
                {
                    MessageBox.Show("Debe Ingresar todos los datos Solicitados");
                }



            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void cboIDSolicitud_SelectionChangeCommitted(object sender, EventArgs e)
        {
            NegocioSolicitudMed auxSolMedica = new NegocioSolicitudMed();
            SolicitudMedica soliMed = new SolicitudMedica();

            Residente residente = new Residente();
            NegocioResidente auxresidente = new NegocioResidente();

            DetalleSolicitud detasoli = new DetalleSolicitud();
            NegocioDetalleSolicitud auxDetaSoli = new NegocioDetalleSolicitud();
            DetalleSolicitudMedica detasoliMED = new DetalleSolicitudMedica();
            NegocioDetalleSolictudMed auxDetaSoliMed = new NegocioDetalleSolictudMed();
            Medicina medicina = new Medicina();
            NegocioMedicina auxMedicina = new NegocioMedicina();
            Enfermera enfermera = new Enfermera();
            NegocioEnfermera auxEnfermera = new NegocioEnfermera();
            Paramedico paramedico = new Paramedico();
            NegocioParamedico auxParamedico = new NegocioParamedico();
            NegocioInfoPersonal auxInfoP = new NegocioInfoPersonal();



            soliMed = auxSolMedica.consultarPorIdSolMedica(int.Parse(cboIDSolicitud.SelectedValue.ToString()));
            detasoli = auxDetaSoli.consultarPorId(soliMed.Id_det_solicitud);
            txtCantidad.Text = detasoli.Cantidad.ToString();
            dateFechaSolicitud.Value = detasoli.Fecha;
            cboMedicina.SelectedValue = detasoli.Id_medicina;
            lblidDetaSolicitud.Text = detasoli.Id_det_solicitud.ToString();

            detasoliMED = auxDetaSoliMed.consultarPorId(soliMed.Id_det_solic_med);
            enfermera = auxEnfermera.consultarEnfermeraporID(soliMed.Id_enfermera);
            paramedico = auxParamedico.consultarParamedicoporID(soliMed.Id_paramedico);

            txtMotivo.Text = detasoliMED.Motivo;
            txtCuidadosEspe.Text = detasoliMED.Cuidados_espe;
            cargarEstado(detasoliMED.Estado_solicitud);
            lblDetaSolidMed.Text = detasoliMED.Id_det_solic_med.ToString();

            InformacionPersonal infopEnfermera = new InformacionPersonal();
            infopEnfermera = auxInfoP.consultaporIdInfoPersonal(enfermera.Id_infopersonal);

            txtRutEnfermera.Text = infopEnfermera.Rut;
            lblNombreEnfermera.Text = infopEnfermera.Nombre;
            lblApellidoEnfermera.Text = infopEnfermera.ApellidoPat + " " + infopEnfermera.ApellidoMat;
            lblidEnfermera.Text = soliMed.Id_enfermera.ToString();

            InformacionPersonal infoPParamedico = new InformacionPersonal();
            infoPParamedico = auxInfoP.consultaporIdInfoPersonal(paramedico.Id_infopersonal);
            txtRutParamedico.Text = infoPParamedico.Rut;
            lblNombreParamedico.Text = infoPParamedico.Nombre;
            lblApellidoParamedico.Text = infoPParamedico.ApellidoPat + " " + infoPParamedico.ApellidoMat;
            lblidParamedico.Text = soliMed.Id_paramedico.ToString();

            InformacionPersonal infoResidente = new InformacionPersonal();
            FichaResidente ficha = new FichaResidente();
            NegocioFichaResidente auxficha = new NegocioFichaResidente();
            residente = auxresidente.consultaResidenteporIDFichaR(soliMed.Id_fic_residente);
            infoResidente = auxInfoP.consultaporIdInfoPersonal(residente.IdInfoPersonal);

            txtRutResidente.Text = infoResidente.Rut;
            lblNombreResidente.Text = infoResidente.Nombre;
            lblApellidoResidente.Text = infoResidente.ApellidoPat + " " + infoResidente.ApellidoMat;
            lblidFichaR.Text = soliMed.Id_fic_residente.ToString(); 
            
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtMotivo_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtMotivo.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (txtMotivo.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtMotivo.Focus();
                txtMotivo.Text = "";
            }
        }

        private void txtCuidadosEspe_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtCuidadosEspe.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (txtCuidadosEspe.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtCuidadosEspe.Focus();
                txtCuidadosEspe.Text = "";
            }
        }
    }
}
