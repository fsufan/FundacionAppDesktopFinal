using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_DTO.Residente;
using CapaNegocio.NegocioResidente;
using CapaNegocio.NegocioFarmacia;
using AplicacionDesktop.MENU;
using System.Text.RegularExpressions;

namespace AplicacionDesktop.CRUD
{
    public partial class ModificarFichaResidente : Form
    {
        public ModificarFichaResidente()
        {
            InitializeComponent();
           
        }
        public ModificarFichaResidente(string rol)
        {
            InitializeComponent();
            CargarCboRut();
            dateFechaInsc.Enabled = false;
            lblidFicha.Visible = false;
            lblRol.Text = rol;
            lblRol.Visible = false;
        }
        public void CargarCboRut()
        {
            try
            {
                NegocioFamiliar auxfamiliar = new NegocioFamiliar();
                NegocioInfoPersonal auxInfoP = new NegocioInfoPersonal();
                InformacionPersonal infop = new InformacionPersonal();
                

                cboRut.DataSource = auxInfoP.listarInfoPersonal();
                cboRut.DisplayMember = "Rut";
                cboRut.ValueMember = "id_Infopersonal";
                cboRut.SelectedIndex = -1;
                if (cboRut.SelectedIndex == -1)
                {
                    cboRut.Text = "Seleccione un Rut";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay datos de Residentes");
            }
        }

        private void cboRut_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Residente residente = new Residente();
                NegocioResidente auxresidente = new NegocioResidente();
                FichaResidente fichaR = new FichaResidente();
                NegocioFichaResidente auxFichaResidente = new NegocioFichaResidente();
                InformacionPersonal infoP = new InformacionPersonal();
                NegocioInfoPersonal auxinfop = new NegocioInfoPersonal();

                residente = auxresidente.consultaResidenteporIDinfoP(int.Parse(cboRut.SelectedValue.ToString()));
                infoP = auxinfop.consultaporIdInfoPersonal(int.Parse(cboRut.SelectedValue.ToString()));
                fichaR = auxFichaResidente.consultarPorIdFichaR(residente.IdFicResidente);

                txtidfresidente.Text = fichaR.IdFichaResidente.ToString();
                dateFechaInsc.Value = fichaR.FechaInscripcion;
                rtxtSituacionM.Text = fichaR.SituacionMedica;
                rtxtComentarios.Text = fichaR.Comentarios;

                lblNombreR.Text = infoP.Nombre;
                lblApellidos.Text = infoP.ApellidoPat + " " + infoP.ApellidoMat;
                lblFechaNac.Text = infoP.FechaNac.ToShortDateString().ToString();
                lblidFicha.Text = fichaR.IdFichaResidente.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No contiene los datos de Ficha Residente");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FichaResidente fichaR = new FichaResidente();
                NegocioFichaResidente auxFichaR = new NegocioFichaResidente();

                InformacionPersonal infop = new InformacionPersonal();
                NegocioInfoPersonal auxinfop = new NegocioInfoPersonal();

                if (DateTime.Compare(DateTime.Today,dateFechaInsc.Value.Date)>= 0)
                {
                    if (rtxtComentarios.Text != "" || rtxtSituacionM.Text !="")
                    {
                        infop = auxinfop.consultaporIdInfoPersonal(int.Parse(cboRut.SelectedValue.ToString()));
                        DialogResult dialogResult = MessageBox.Show("Desea modificar la Ficha del Residente :" + infop.Nombre +" "+infop.ApellidoPat, "Información", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            fichaR.IdFichaResidente = int.Parse(txtidfresidente.Text);
                            fichaR.FechaInscripcion = dateFechaInsc.Value;
                            fichaR.SituacionMedica = rtxtSituacionM.Text.ToUpper().Trim();
                            fichaR.Comentarios = rtxtComentarios.Text.ToUpper().Trim();

                            DialogResult resultado = MessageBox.Show("Se Cambiaran los datos de la Ficha ¿Desea Continuar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            switch (resultado)
                            {
                                
                                case DialogResult.Yes:
                                    fichaR.IdFichaResidente = int.Parse(txtidfresidente.Text);
                                    fichaR.FechaInscripcion = dateFechaInsc.Value;
                                    fichaR.SituacionMedica = rtxtSituacionM.Text.ToUpper().Trim();
                                    fichaR.Comentarios = rtxtComentarios.Text.ToUpper().Trim();
                                    if (auxFichaR.actualizarFichaResidente(fichaR) > 0)
                                    {
                                        cargarDatos();
                                        dateFechaInsc.Value = DateTime.Now;
                                        rtxtComentarios.Text = "";
                                        rtxtSituacionM.Text = "";
                                        cboRut.SelectedIndex = -1;

                                        MessageBox.Show("Ficha Residente Modificada");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al Modificar Ficha Residente");
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe completar todos los Datos");
                    }
                }
                else
                {
                    MessageBox.Show("La Fecha de Inscripcion no puede ser inferior a la fecha de hoy");
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error " + ex);
            }
        }

        public void cargarDatos()
        {
            NegocioFichaResidente auxFichaR = new NegocioFichaResidente();
            try
            {
                if (auxFichaR.listarFichaResidente() != null)
                {
                    dataGridView1.DataSource = auxFichaR.listarFichaResidente();
                    dataGridView1.ReadOnly = true;
                    dataGridView1.Columns[0].HeaderText = "Comentarios";
                    dataGridView1.Columns[1].HeaderText = "Fecha Inscripcion";
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[3].HeaderText = "Id_Ficha";
                    
                    dataGridView1.Update();
                }
                else
                {
                    MessageBox.Show("No hay Datos");
                }
            }catch(Exception)
            {
                MessageBox.Show("No hay Datos");
                this.Close();
            }
        }

        private void AgregarNuevoHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                HistorialMedico histoM = new HistorialMedico();
                NegocioHistoMedico auxHistoM = new NegocioHistoMedico();
                InformacionPersonal infop = new InformacionPersonal();
                NegocioInfoPersonal auxInfoP = new NegocioInfoPersonal();

                if (rtxtEnfermedades.Text != null | rtxtAlergias.Text != null | rtxtTrataEspe.Text != null)
                {
                    
                    infop = auxInfoP.consultaporIdInfoPersonal(int.Parse(cboRut.SelectedValue.ToString()));
                    DialogResult dialogResult = MessageBox.Show("Desea Agregar un Nuevo Historial para el Residente: " + infop.Nombre + " " + infop.ApellidoPat, "Información", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DialogResult resultado = MessageBox.Show("Se Ingresara Historial Medico ¿Desea Continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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

                                histoM.Enfermedades = rtxtEnfermedades.Text.ToUpper().Trim();
                                histoM.Alergias = rtxtAlergias.Text.ToUpper().Trim();
                                histoM.TratamientoEspecial = rtxtTrataEspe.Text.ToUpper().Trim();
                                histoM.IdFicResidente = int.Parse(lblidFicha.Text);

                                if (auxHistoM.IngresarHistoMedico(histoM)>0)
                                {
                                    rtxtEnfermedades.Text = string.Empty;
                                    rtxtAlergias.Text = string.Empty;
                                    rtxtTrataEspe.Text = string.Empty;

                                    MessageBox.Show("Nuevo Historial Ingresado");
                                }
                                else
                                {
                                    MessageBox.Show("Error al Ingresar nuevo Historial");
                                }



                                break;
                            default:
                                break;
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Debe completar todos los datos del Historial para Ingresar uno nuevo");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error "+ ex);
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

        private void button2_Click(object sender, EventArgs e)
        {
            MenuEnfermera ME = new MenuEnfermera();
            //MenuSupervisor MS = new MenuSupervisor();
            //if (lblRol.Text.Equals("ENFERMERA"))
            //{
            //    MS.Show();
            //}
            //else
            //{
            //    ME.Show();
            //}
            ME.Show();
            this.Hide();
        }


        private void rtxtEnfermedades_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.rtxtEnfermedades.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (rtxtEnfermedades.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.rtxtEnfermedades.Focus();
                rtxtEnfermedades.Text = "";
            }
        }

        private void rtxtAlergias_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.rtxtAlergias.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (rtxtAlergias.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.rtxtAlergias.Focus();
                rtxtAlergias.Text = "";
            }
        }

        private void rtxtTrataEspe_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.rtxtTrataEspe.Text, @"^[A-Z0-9 a-z]*$")) && (rtxtTrataEspe.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.rtxtTrataEspe.Focus();
                rtxtTrataEspe.Text = "";
            }
        }

        private void rtxtSituacionM_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.rtxtSituacionM.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (rtxtSituacionM.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.rtxtSituacionM.Focus();
                rtxtSituacionM.Text = "";
            }
        }

        private void rtxtComentarios_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.rtxtComentarios.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (rtxtComentarios.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.rtxtComentarios.Focus();
                rtxtComentarios.Text = "";
            }
        }
    }
}
