using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionDesktop.MENU;
using CapaNegocio.NegocioResidente;
using CapaNegocio.NegocioFarmacia;
using Capa_DTO.Residente;
using Capa_DTO.Farmacia;
using AplicacionDesktop.CRUD;
using System.Text.RegularExpressions;

namespace AplicacionDesktop.CRUDUsuario
{
    public partial class ModificarResidente : Form
    {
        public ModificarResidente()
        {
            InitializeComponent();
            cargarcboRutResidente();
            CargarFamiliar();

            txtdescripcion.Enabled = false;
            txtCostoTotal.Enabled = false;
            txtCondiciones.Enabled = false;
            txtNombreServicio.Enabled = false;

            cboRutFamiliar.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRutResidente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void CargarFamiliar()
        {
            try
            {
                NegocioInfoPersonal InfoRF = new NegocioInfoPersonal();
                cboRutFamiliar.DataSource = InfoRF.listarInfoPersonal();
                cboRutFamiliar.DisplayMember = "Rut";
                cboRutFamiliar.ValueMember = "id_infopersonal";
                cboRutFamiliar.SelectedIndex = -1;
                if (cboRutFamiliar.SelectedIndex == -1)
                {
                    cboRutFamiliar.Text = "Seleccione un Familiar";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No existen datos en Informacion Personal");
            }
        }

        public void cargarcboRutResidente()
        {
            try
            {
                NegocioInfoPersonal auxInfoP = new NegocioInfoPersonal();
                cboRutResidente.DataSource = auxInfoP.listarInfoPersonal();
                cboRutResidente.DisplayMember = "Rut";
                cboRutResidente.ValueMember = "id_Infopersonal";
                cboRutResidente.SelectedIndex = -1;
                if (cboRutResidente.SelectedIndex == -1)
                {
                    cboRutResidente.Text = "Seleccione un Rut";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay datos de Residentes");
            }
            
        }

        private void focusComponente(TextBox text)
        {
            text.Focus();
        }

        private Boolean validaCampoVacio(TextBox campo)
        {
            if (String.IsNullOrEmpty(campo.Text.Trim()))
            {
                return true;
            }
            else
            {

                focusComponente(campo);
                return false;
            }
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAdminResidentes AR = new MenuAdminResidentes();
            AR.Show();
            Hide();
        }
        
        

        private void btnMod_Click(object sender, EventArgs e)
        {

            try
            {
                //Familiar
                Familiar familiar = new Familiar();
                NegocioFamiliar auxFamiliar = new NegocioFamiliar();
                //Contrato
                Contrato contrato = new Contrato();
                NegocioContrato auxContrato = new NegocioContrato();
                //Detalle Contrato
                DetaContrato DetContrato = new DetaContrato();
                NegocioDetContrato auxDetaContrato = new NegocioDetContrato();
                //Servicios
                Servicio servicio = new Servicio();
                NegocioServicio auxservicio = new NegocioServicio();
                //Ficha Residente
                FichaResidente fichaResidente = new FichaResidente();
                NegocioFichaResidente auxFichaResidente = new NegocioFichaResidente();
                //Historial Medico
                HistorialMedico historialM = new HistorialMedico();
                NegocioHistoMedico auxHMedico = new NegocioHistoMedico();
                //direccion
                Direccion direc = new Direccion();
                NegocioDireccion auxDireccion = new NegocioDireccion();

                //Informacion Personal
                InformacionPersonal infoP = new InformacionPersonal();
                NegocioInfoPersonal auxInfoP = new NegocioInfoPersonal();
                //Residente
                Residente residente = new Residente();
                NegocioResidente auxResidente = new NegocioResidente();



                if (txtCostoTotal.Text != "" || txtSituacionM.Text != "")
                {

                    if (DateTime.Compare(DateTime.Today, DatePFechaInscripcion.Value.Date) >= 0)
                    {



                        if (cboRutResidente.SelectedIndex != -1)
                        {
                            if (cboRutResidente.SelectedIndex != cboRutFamiliar.SelectedIndex)
                            {


                                infoP = auxInfoP.consultaporIdInfoPersonal(int.Parse(cboRutResidente.SelectedValue.ToString()));
                                familiar = auxFamiliar.consultaridFamiliarporidInfo(int.Parse(cboRutFamiliar.SelectedValue.ToString()));
                                DialogResult dialogResult = MessageBox.Show("Desea modificar el Residente :" + infoP.Nombre + " " + infoP.ApellidoPat, "Informacion", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    DialogResult resultado = MessageBox.Show("Se Cambiaran los datos del Residente ¿Desea Contianuar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                    switch (resultado)
                                    {
                                        case DialogResult.Yes:

                                            //Datos ficha residente

                                            fichaResidente.IdFichaResidente = int.Parse(txtidFichaR.Text);
                                            fichaResidente.FechaInscripcion = DatePFechaInscripcion.Value;
                                            fichaResidente.SituacionMedica = txtSituacionM.Text.ToUpper().Trim();
                                            fichaResidente.Comentarios = RtxtComentarios.Text.ToUpper().Trim();


                                            if (auxFichaResidente.actualizarFichaResidente(fichaResidente) > 0)
                                            {
                                                FichaResidente buscafic = new FichaResidente();
                                                NegocioFichaResidente auxbuscaf = new NegocioFichaResidente();
                                                buscafic = auxbuscaf.consultarPorComentariosSituacion(fichaResidente.Comentarios, fichaResidente.SituacionMedica);


                                                //datos de Historial Medico
                                                historialM.IdHistoMedico = int.Parse(txtidhistoM.Text);
                                                historialM.Enfermedades = RtxtEnfermedades.Text.ToUpper().Trim();
                                                historialM.Alergias = RtxtAlergias.Text.ToUpper().Trim();
                                                historialM.TratamientoEspecial = RtxtTrataEspecial.Text.ToUpper().Trim();
                                                historialM.IdFicResidente = buscafic.IdFichaResidente;

                                                if (auxHMedico.IngresarHistoMedico(historialM) > 0)
                                                {
                                                    int edad = DateTime.Now.Year - infoP.FechaNac.Year;

                                                    //Datos de Residente
                                                    residente.IdInfoPersonal = infoP.Id_InfoPersonal;
                                                    residente.Edad = edad;
                                                    residente.IdFamiliar = familiar.IdFamiliar;
                                                    residente.IdFicResidente = buscafic.IdFichaResidente;


                                                    if (auxResidente.IngresarResidente(residente) > 0)
                                                    {

                                                        cboRutResidente.SelectedIndex = -1;
                                                        cboRutFamiliar.SelectedIndex = -1;
                                                        txtNombreServicio.Text = string.Empty;
                                                        txtCondiciones.Text = string.Empty;
                                                        txtdescripcion.Text = string.Empty;
                                                        txtCostoTotal.Text = string.Empty;
                                                        DatePFechaInscripcion.Value = DateTime.Now;
                                                        txtSituacionM.Text = string.Empty;
                                                        RtxtComentarios.Text = string.Empty;
                                                        RtxtEnfermedades.Text = string.Empty;
                                                        RtxtAlergias.Text = string.Empty;
                                                        RtxtTrataEspecial.Text = string.Empty;

                                                        MessageBox.Show("Residente Modificado");
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Error al Modificar el Residente");
                                                    }

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Historial medico no Ingresado");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ficha Residente no Ingresada");
                                            }



                                            break;
                                        case DialogResult.No:
                                            break;
                                    }
                                }


                            }
                            else
                            {
                                MessageBox.Show("El residente no puede ser su Familiar");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Seleccione todos las listas.", "Información");
                        }

                    }
                    else
                    {
                        MessageBox.Show("La fecha de Inscripcion no puede ser menor a la fecha de hoy");
                    }

                }
                else
                {
                    MessageBox.Show("No deje ningún campo vacío");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar un Residente" + ex);
            }                     
        }

        private void btnModificarFamiliar_Click(object sender, EventArgs e)
        {
            ModificarFamiliar MF = new ModificarFamiliar();
            MF.Show();
            this.Hide();
        }

        private void btnModifResidente_Click(object sender, EventArgs e)
        {
            ModificarInfoPResidente MIR = new ModificarInfoPResidente();
            MIR.Show();
            this.Hide();
        }

        private void cboRutResidente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                HistorialMedico histoMedico = new HistorialMedico();
                NegocioHistoMedico auxHM = new NegocioHistoMedico();
                FichaResidente ficharesidente = new FichaResidente();
                NegocioFichaResidente auxFichaR = new NegocioFichaResidente();
                Residente residente = new Residente();
                NegocioResidente auxresidente = new NegocioResidente();
                InformacionPersonal infoP = new InformacionPersonal();
                NegocioInfoPersonal auxinfo = new NegocioInfoPersonal();

                residente = auxresidente.consultaResidenteporIDinfoP(int.Parse(cboRutResidente.SelectedValue.ToString()));
                infoP = auxinfo.consultaporIdInfoPersonal(residente.IdInfoPersonal);
                ficharesidente = auxFichaR.consultarPorIdFichaR(residente.IdFicResidente);
                histoMedico = auxHM.BuscaridHistoMporIdFichaR(ficharesidente.IdFichaResidente);

                txtidFichaR.Text = ficharesidente.IdFichaResidente.ToString();
                RtxtComentarios.Text = ficharesidente.Comentarios;
                txtSituacionM.Text = ficharesidente.SituacionMedica;
                DatePFechaInscripcion.MinDate = ficharesidente.FechaInscripcion;

                lblNombreR.Text = infoP.Nombre;
                lblApellidoR.Text = infoP.ApellidoPat;

                txtidhistoM.Text = histoMedico.IdHistoMedico.ToString();
                RtxtAlergias.Text = histoMedico.Alergias;
                RtxtEnfermedades.Text = histoMedico.Enfermedades;
                RtxtTrataEspecial.Text = histoMedico.TratamientoEspecial;
            }catch(Exception){

                MessageBox.Show("El rut que selecciono no corresponde a un Residente");
            }

        }

        private void cboRutFamiliar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Familiar fami = new Familiar();
                NegocioFamiliar auxfailiar = new NegocioFamiliar();
                Contrato Contra = new Contrato();
                NegocioContrato auxContrat = new NegocioContrato();
                DetaContrato detc = new DetaContrato();
                NegocioDetContrato auxdtC = new NegocioDetContrato();
                Servicio servi = new Servicio();
                NegocioServicio auxServ = new NegocioServicio();
                InformacionPersonal infoP = new InformacionPersonal();
                NegocioInfoPersonal auxInfoP = new NegocioInfoPersonal();


                fami = auxfailiar.consultaridFamiliarporidInfo(int.Parse(cboRutFamiliar.SelectedValue.ToString()));
                infoP = auxInfoP.consultaporIdInfoPersonal(int.Parse(cboRutFamiliar.SelectedValue.ToString()));
                Contra = auxContrat.consultaporIdContrato(fami.IdContrato);
                detc = auxdtC.consultaporIdDetContrato(Contra.IddetalleContrato);
                servi = auxServ.consultaporIdServicio(detc.IdServicio);

                lblNombreF.Text = infoP.Nombre;
                lblApellidoF.Text = infoP.ApellidoPat;
                txtCondiciones.Text = Contra.CondicionesPerm;
                //txtiddetalle.Text = Contra.IddetalleContrato.ToString();
                txtCostoTotal.Text = detc.CostoTotal.ToString();
                txtNombreServicio.Text = servi.NombreServicio;
                txtdescripcion.Text = servi.Descripcion;
            }
            catch (Exception)
            {
                MessageBox.Show("El rut que selecciono no Corresponde aun Familiar");
            }
        }



        private void RtxtComentarios_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.RtxtComentarios.Text, @"^[A-Z0-9 a-z]*$")) && (RtxtComentarios.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.RtxtComentarios.Focus();
                RtxtComentarios.Text = "";
            }
        }

        private void txtSituacionM_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtSituacionM.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (txtSituacionM.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtSituacionM.Focus();
                txtSituacionM.Text = "";
            }
        }

        private void RtxtEnfermedades_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.RtxtEnfermedades.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (RtxtEnfermedades.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.RtxtEnfermedades.Focus();
                RtxtEnfermedades.Text = "";
            }
        }

        private void RtxtAlergias_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.RtxtAlergias.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (RtxtAlergias.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.RtxtAlergias.Focus();
                RtxtAlergias.Text = "";
            }
        }

        private void RtxtTrataEspecial_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.RtxtTrataEspecial.Text, @"^[A-Z0-9 a-z]*$")) && (RtxtTrataEspecial.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.RtxtTrataEspecial.Focus();
                RtxtTrataEspecial.Text = "";
            }
        }



        }
    }
