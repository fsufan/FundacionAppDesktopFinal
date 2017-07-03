using Capa_DTO.Farmacia;
using Capa_DTO.Residente;
using CapaNegocio.NegocioFarmacia;
using CapaNegocio.NegocioResidente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using AplicacionDesktop.MENU;
using AplicacionDesktop.CRUD;
using System.Text.RegularExpressions;
using System.Globalization;


namespace AplicacionDesktop.CRUDUsuario
{
    public partial class IngresarResidente : Form
    {
        public IngresarResidente()
        {
            
            InitializeComponent();

            cboRutFamiliar.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRutResidente.DropDownStyle = ComboBoxStyle.DropDownList;
            
                                    
            txtdescripcion.Enabled = false;
            txtCostoTotal.Enabled = false;
            txtCondiciones.Enabled = false;
            txtNombreServicio.Enabled = false;

           
            CargarResidente();
            CargarFamiliar();
               
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

        public void CargarResidente()
        {
            try
            {
                NegocioInfoPersonal infoPR = new NegocioInfoPersonal();
                cboRutResidente.DataSource = infoPR.listarInfoPersonal();
                cboRutResidente.DisplayMember = "Rut";
                cboRutResidente.ValueMember = "id_infopersonal";

                cboRutResidente.SelectedIndex = -1;
                if (cboRutResidente.SelectedIndex == -1)
                {
                    cboRutResidente.Text = "Seleccione un Residente";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No existen datos en Informacion Personal");
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
            catch (Exception)
            {
            }
            return validacion;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtApePaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
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

                

                if (txtCostoTotal.Text !=""||txtSituacionM.Text !="")
                {
                   
                  if (DateTime.Compare(DateTime.Today, DatePFechaInscripcion.Value.Date) <= 0)
                    {
                                                 
                        

                      if (cboRutResidente.SelectedIndex != -1 )
                         {
                             if (cboRutResidente.SelectedIndex != cboRutFamiliar.SelectedIndex)
                             {
                                 

                                     infoP = auxInfoP.consultaporIdInfoPersonal(int.Parse(cboRutResidente.SelectedValue.ToString()));
                                     familiar = auxFamiliar.consultaridFamiliarporidInfo(int.Parse(cboRutFamiliar.SelectedValue.ToString()));
                                     DialogResult dialogResult = MessageBox.Show("Desea agregar un Residente :" + infoP.Nombre + " " + infoP.ApellidoPat, "Informacion", MessageBoxButtons.YesNo);
                                     if (dialogResult == DialogResult.Yes)
                                     {
                                         DialogResult resultado = MessageBox.Show("Se Ingresara el Residente ¿Desea Continuar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                         switch (resultado)
                                         {
                                             case DialogResult.Yes:

                                                 //Datos ficha residente
                                                 fichaResidente.FechaInscripcion = DatePFechaInscripcion.Value;
                                                 fichaResidente.SituacionMedica = txtSituacionM.Text.ToUpper().Trim();
                                                 fichaResidente.Comentarios = RtxtComentarios.Text.ToUpper().Trim();


                                                 if (auxFichaResidente.ingresarFicResidente(fichaResidente) > 0)
                                                 {
                                                     FichaResidente buscafic = new FichaResidente();
                                                     NegocioFichaResidente auxbuscaf = new NegocioFichaResidente();
                                                     buscafic = auxbuscaf.consultarPorComentariosSituacion(fichaResidente.Comentarios, fichaResidente.SituacionMedica);


                                                     //datos de Historial Medico
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

                                                             MessageBox.Show("Nuevo residente Ingresado");
                                                         }
                                                         else
                                                         {
                                                             MessageBox.Show("Error al Ingresar el Residente");
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
                MessageBox.Show("Error al Ingresar un Residente"+ ex);
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

        private void IngresarResidente_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdminResidentes MAR = new MenuAdminResidentes();
            MAR.Show();
            Hide();
        }

              
        


        //Metodo para darle formato al Rut
        public string formatearRut(string rut)
        {
           int cont = 0;
           string format;
           if (rut.Length == 0)
           {
              return "";
           }
           else
           {
              rut = rut.Replace(".", "");
              rut = rut.Replace("-", "");
              format = "-" + rut.Substring(rut.Length - 1);
              for (int i = rut.Length - 2; i >= 0; i--)
              {
                  format = rut.Substring(i, 1) + format;
                  cont++;
                  if (cont == 3 && i != 0)
                  {
                     format = "." + format;
                     cont = 0;
                  }
              }
              return format;
        }
}

        //validador de formato Rut
        private void txtRutP_Validated(object sender, EventArgs e)
        {
            //txtRutP.Text = formatearRut(txtRutP.Text);
        }

        private void btnDatosResidente_Click(object sender, EventArgs e)
        {
            InsertarDatosResidente DR = new InsertarDatosResidente();
            DR.Show();
            this.Hide();
        }

        private void btnDatosFamiliar_Click(object sender, EventArgs e)
        {
            InsertarDatosFamiliar DF = new InsertarDatosFamiliar();
            DF.Show();
            this.Hide();
        }

        private void cboParentesco_SelectionChangeCommitted(object sender, EventArgs e)
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


                infoP = auxInfoP.consultaporIdInfoPersonal(int.Parse(cboRutFamiliar.SelectedValue.ToString()));

                lblNombreF.Text = infoP.Nombre;
                lblApellidoF.Text = infoP.ApellidoPat;


                fami = auxfailiar.consultaridFamiliarporidInfo(int.Parse(cboRutFamiliar.SelectedValue.ToString()));
                Contra = auxContrat.consultaporIdContrato(fami.IdContrato);
                detc = auxdtC.consultaporIdDetContrato(Contra.IddetalleContrato);
                servi = auxServ.consultaporIdServicio(detc.IdServicio);

                txtCondiciones.Text = Contra.CondicionesPerm;
                //txtiddetalle.Text = Contra.IddetalleContrato.ToString();
                txtCostoTotal.Text = detc.CostoTotal.ToString();
                txtNombreServicio.Text = servi.NombreServicio;
                txtdescripcion.Text = servi.Descripcion;
            

        }

        private void cboRutResidente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
                InformacionPersonal infoP = new InformacionPersonal();
                NegocioInfoPersonal auxInfoP = new NegocioInfoPersonal();


                infoP = auxInfoP.consultaporIdInfoPersonal(int.Parse(cboRutResidente.SelectedValue.ToString()));

                lblNombreR.Text = infoP.Nombre;
                lblApellidoR.Text = infoP.ApellidoPat;
            
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
