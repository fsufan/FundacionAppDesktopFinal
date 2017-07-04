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
using Capa_DTO.Residente;
using CapaNegocio.NegocioFarmacia;
using Capa_DTO.Medicamento;
using Capa_DTO.Farmacia;
using CapaNegocio.NegocioResidente;
using CapaNegocio.NegocioUsuario;
using System.Text.RegularExpressions;
using Capa_DTO.Seguridad;

namespace AplicacionDesktop.MENU
{
    public partial class IngresarSolicitudMedicamentos : Form
    {
        public IngresarSolicitudMedicamentos()
        {
            InitializeComponent();
            
        }
        public IngresarSolicitudMedicamentos(string rol)
        {
            InitializeComponent();
            lblidFichaR.Visible = false;
            CargarMedicina();
            lblRol.Text = rol;
            lblRol.Visible = false;
            lblidEnfermera.Visible = false;
            lblidFichaR.Visible = false;
            lblidParamedico.Visible = false;
            
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

        private void btnIngresar_Click(object sender, EventArgs e)
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
                

                if (txtRutResidente.Text != "" && txtRutEnfermera.Text != "" && txtCantidad.Text != "" && txtCuidadosEspe.Text != "" && txtMotivo.Text !="")
                {
                    if (DateTime.Compare(DateTime.Today,dateFechaSolicitud.Value.Date) <= 0)
                    {
                        medicina = auxMedicina.consultarPorIdMedicina(int.Parse(cboMedicina.SelectedValue.ToString()));
                        int cantidad = medicina.Cantidad;
                                                  


                            if (cboMedicina.SelectedIndex != -1)
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

                                            detaSoli.Id_medicina = int.Parse(cboMedicina.SelectedValue.ToString());
                                            detaSoli.Fecha = dateFechaSolicitud.Value;
                                            detaSoli.Cantidad = int.Parse(txtCantidad.Text.ToUpper().Trim());

                                            if (auxDetaSoli.ingresarDetSolicitud(detaSoli) > 0)
                                            {
                                                detaSoliMed.Estado_solicitud = "En Espera";
                                                detaSoliMed.Motivo = txtMotivo.Text.ToUpper().Trim();
                                                detaSoliMed.Cuidados_espe = txtCuidadosEspe.Text.ToUpper().Trim();

                                                if (auxDetaSoliMed.ingresarDtSolMed(detaSoliMed) > 0)
                                                {
                                                    DetalleSolicitud buscarDSO = new DetalleSolicitud();
                                                    DetalleSolicitudMedica buscarDSM = new DetalleSolicitudMedica();
                                                    buscarDSO = auxDetaSoli.consultarPorIDMedicina(int.Parse(cboMedicina.SelectedValue.ToString()));
                                                    buscarDSM = auxDetaSoliMed.ConsultaIDporMotyCuidados(detaSoliMed.Motivo, detaSoliMed.Cuidados_espe);

                                                    
                                                    SoliMedica.Id_det_solic_med = buscarDSM.Id_det_solic_med;
                                                    SoliMedica.Id_fic_residente = int.Parse(lblidFichaR.Text);
                                                    SoliMedica.Id_enfermera = int.Parse(lblidEnfermera.Text);                                                    
                                                    SoliMedica.Id_paramedico = int.Parse(lblidParamedico.Text);
                                                    SoliMedica.Id_det_solicitud = buscarDSO.Id_det_solicitud;

                                                    if (auxSoliMed.ingresarSolicitudMedica(SoliMedica) > 0)
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

                                                        MessageBox.Show("Solicitud Medica Ingresada");
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Error al Ingresar Solicitud Medica");
                                                    }


                                                }
                                                else
                                                {
                                                    MessageBox.Show("Detalle Solicitud Medica No Ingresada");
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("Detalle Solicitud no Ingresada");
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
                        MessageBox.Show("La Fecha de la Solicitud no puede ser menor a la fecha de hoy");
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

        private void btnVolverr_Click(object sender, EventArgs e)
        {
            //MenuSupervisor MS = new MenuSupervisor();
            //MenuEnfermera ME = new MenuEnfermera();
            //if (lblRol.Text.Equals("SUPERVISOR"))
            //{
            //    MS.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    ME.Show();
            //    this.Hide();
            //}
            MenuAdminSolicitudMedica MASM = new MenuAdminSolicitudMedica();
            MASM.Show();
            this.Hide();
        }

        private void btnbuscarResidente_Click(object sender, EventArgs e)
        {
            try
            {
                InformacionPersonal infop = new InformacionPersonal();
                NegocioInfoPersonal AuxInfo = new NegocioInfoPersonal();
                Residente residente = new Residente();
                NegocioResidente auxResidente = new NegocioResidente();
                FichaResidente fichaR = new FichaResidente();
                NegocioFichaResidente auxFichaR = new NegocioFichaResidente();
                Seguridad seguridad = new Seguridad();

                if (txtRutResidente.Text != "")
                {
                    
                    if (seguridad.validarRut(txtRutResidente.Text))
                    {

                        if (AuxInfo.consultarRut(txtRutResidente.Text) == true)
                        {
                            infop = AuxInfo.BuscaridPorRut(txtRutResidente.Text.ToUpper().Trim());
                            residente = auxResidente.consultaResidenteporIDinfoP(infop.Id_InfoPersonal);
                            fichaR = auxFichaR.consultarPorIdFichaR(residente.IdFicResidente);

                            lblNombreResidente.Text = infop.Nombre;
                            lblApellidoResidente.Text = infop.ApellidoPat + " " + infop.ApellidoMat;
                            lblidFichaR.Text = fichaR.IdFichaResidente.ToString();

                        }
                        else
                        {
                            MessageBox.Show("Rut no existe en los registros");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El formato del rut es Incorrecto");
                    }
                }
                else
                {
                    MessageBox.Show("Debe Ingresar un Rut ");
                }
            }
            catch (Exception)
            {
                txtRutResidente.Text = string.Empty;
                lblNombreResidente.Text = string.Empty;
                lblApellidoResidente.Text = string.Empty;
                lblidFichaR.Text = string.Empty;
                MessageBox.Show("Error");
            }
           

            
        }

        private void btnBuscarEnfermera_Click(object sender, EventArgs e)
        {
            try
            {
                InformacionPersonal infop = new InformacionPersonal();
                NegocioInfoPersonal AuxInfo = new NegocioInfoPersonal();                
                Enfermera enfermera = new Enfermera();
                NegocioEnfermera auxEnfermera = new NegocioEnfermera();
                Seguridad seguridad = new Seguridad();

                if (txtRutEnfermera.Text != "")
                {
                    
                    if (seguridad.validarRut(txtRutEnfermera.Text))
                    {

                        if (AuxInfo.consultarRut(txtRutEnfermera.Text) == true)
                        {
                            infop = AuxInfo.BuscaridPorRut(txtRutEnfermera.Text.ToUpper().Trim());
                            enfermera = auxEnfermera.consultarEnfermeraporIDinfoP(infop.Id_InfoPersonal);

                            lblNombreEnfermera.Text = infop.Nombre;
                            lblApellidoEnfermera.Text = infop.ApellidoPat + " " + infop.ApellidoMat;
                            lblidEnfermera.Text = enfermera.Id_enfermera.ToString();

                        }
                        else
                        {
                            MessageBox.Show("Rut no existe en los registros");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El formato del rut es Incorrecto");
                    }
                }
                else
                {
                    MessageBox.Show("Debe Ingresar un Rut ");
                }
            }
            catch (Exception)
            {
                txtRutEnfermera.Text = string.Empty;
                lblNombreEnfermera.Text = string.Empty;
                lblApellidoEnfermera.Text = string.Empty;
                lblidEnfermera.Text = string.Empty;
                MessageBox.Show("Rut no Pertenece a una Enfermera");
            }
        }

        private void btnBuscarParamedico_Click(object sender, EventArgs e)
        {
            try
            {
                InformacionPersonal infop = new InformacionPersonal();
                NegocioInfoPersonal AuxInfo = new NegocioInfoPersonal();

                Paramedico paramedico = new Paramedico();
                NegocioParamedico auxParamedico = new NegocioParamedico();
                Seguridad seguridad = new Seguridad();

                if (txtRutParamedico.Text != "")
                {
                    
                    if (seguridad.validarRut(txtRutParamedico.Text))
                    {

                        if (AuxInfo.consultarRut(txtRutParamedico.Text) == true)
                        {
                            infop = AuxInfo.BuscaridPorRut(txtRutParamedico.Text.ToUpper().Trim());
                            paramedico = auxParamedico.consultarParamedicoporIDinfoP(infop.Id_InfoPersonal);

                            lblNombreParamedico.Text = infop.Nombre;
                            lblApellidoParamedico.Text = infop.ApellidoPat + " " + infop.ApellidoMat;
                            lblidParamedico.Text = paramedico.Id_paramedico.ToString();

                        }
                        else
                        {
                            MessageBox.Show("Rut no existe en los registros");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El formato del rut es Incorrecto");
                    }
                }
                else
                {
                    MessageBox.Show("Debe Ingresar un Rut ");
                }
            }
            catch (Exception)
            {
                txtRutParamedico.Text = string.Empty;
                lblNombreParamedico.Text = string.Empty;
                lblApellidoParamedico.Text = string.Empty;
                lblidParamedico.Text = string.Empty;
                MessageBox.Show("Rut no Pertenece a un Paramedico");
            }
        }

        public bool validarRut(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                if (rutAux > 3000000 & rutAux < 30000000)
                {
                    if (dv.Equals('0'))
                    {
                        dv = 'K';
                    }

                    int m = 0, s = 1;
                    for (; rutAux != 0; rutAux /= 10)
                    {
                        s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                    }
                    if (dv == (char)(s != 0 ? s + 47 : 75))
                    {
                        validacion = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un Rut válido");
            }
            return validacion;
        }

        private void txtRutResidente_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtRutResidente.Text, @"\b\d{7,8}\-[K|k|0-9]")) && (txtRutResidente.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres válidos");
                this.txtRutResidente.Focus();
                txtRutResidente.Text = "";
            }
        }

        private void txtRutResidente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtRutEnfermera_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtRutEnfermera.Text, @"\b\d{7,8}\-[K|k|0-9]")) && (txtRutEnfermera.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres válidos");
                this.txtRutEnfermera.Focus();
                txtRutEnfermera.Text = "";
            }
        }

        private void txtRutParamedico_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtRutParamedico.Text, @"\b\d{7,8}\-[K|k|0-9]")) && (txtRutParamedico.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres válidos");
                this.txtRutParamedico.Focus();
                txtRutParamedico.Text = "";
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

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

    }
}
