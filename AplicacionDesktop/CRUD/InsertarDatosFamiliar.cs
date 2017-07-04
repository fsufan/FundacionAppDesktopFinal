using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.NegocioResidente;
using CapaNegocio.NegocioFarmacia;
using Capa_DTO.Residente;
using Capa_DTO.Farmacia;
using System.Text.RegularExpressions;
using AplicacionDesktop.CRUDUsuario;
using Capa_DTO.Seguridad;


namespace AplicacionDesktop.CRUD
{
    public partial class InsertarDatosFamiliar : Form
    {
        public InsertarDatosFamiliar()
        {
            InitializeComponent();
            cboServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboParentesco.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCondicionesC.DropDownStyle = ComboBoxStyle.DropDownList;
            cboComuna.DropDownStyle = ComboBoxStyle.DropDownList;

            // Region
            #region cboregion
            Dictionary<string, string> Dregion = new Dictionary<string, string>();
            Dregion.Add("13", "Metropolitana");
            cboRegion.DisplayMember = "Value";
            cboRegion.ValueMember = "Value";
            cboRegion.DataSource = Dregion.ToArray();
            cboRegion.SelectedIndex = -1;
            if (cboRegion.SelectedIndex == -1)
            {
                cboRegion.Text = "Seleccione Region";
            }

            #endregion
            //comunas RM
            #region cboComuna
            Dictionary<string, string> DComuna = new Dictionary<string, string>();

            DComuna.Add("0", "Santiago");
            DComuna.Add("1", "Cerrillos");
            DComuna.Add("2", "Cerro Navia");
            DComuna.Add("3", "Conchalí");
            DComuna.Add("4", "El Bosque");
            DComuna.Add("5", "Estación Central");
            DComuna.Add("6", "Huechuraba");
            DComuna.Add("7", "Independencia");
            DComuna.Add("8", "La Cisterna");            
            DComuna.Add("9", "La Florida");
            DComuna.Add("10", "La Granja");
            DComuna.Add("11", "La Pintana");
            DComuna.Add("12", "La Reina");
            DComuna.Add("13", "Las Condes");
            DComuna.Add("14", "Lo Barnechea");
            DComuna.Add("15", "Lo Espejo");
            DComuna.Add("16", "Lo Prado");
            DComuna.Add("17", "Macul");
            DComuna.Add("18", "Maipú");
            DComuna.Add("19", "Ñuñoa");
            DComuna.Add("20", "Pedro Aguirre Cerda");
            DComuna.Add("21", "Peñalolén");
            DComuna.Add("22", "Providencia");
            DComuna.Add("23", "Pudahuel");
            DComuna.Add("24", "Quilicura");
            DComuna.Add("25", "Quinta Normal");
            DComuna.Add("26", "Recoleta");
            DComuna.Add("27", "Renca");
            DComuna.Add("28", "San Joaquín");
            DComuna.Add("29", "San Miguel");
            DComuna.Add("30", "San Ramón");
            DComuna.Add("31", "Vitacura");
            cboComuna.DisplayMember = "Value";
            cboComuna.ValueMember = "Value";
            cboComuna.DataSource = DComuna.ToArray();
            cboComuna.SelectedIndex = -1;
            if (cboComuna.SelectedIndex == -1)
            {
                cboComuna.Text = "Seleccione Comuna";
            }
            #endregion
            //parentesco
            #region cboparentezco
            //Parentesco
            Dictionary<string, string> parentesco = new Dictionary<string, string>();
            parentesco.Add("1", "Hijo");
            parentesco.Add("2", "Hija");
            parentesco.Add("3", "Padre");
            parentesco.Add("4", "Madre");
            cboParentesco.DisplayMember = "Value";
            cboParentesco.ValueMember = "Value";
            cboParentesco.DataSource = parentesco.ToArray();
            cboParentesco.SelectedIndex = -1;
            if (cboParentesco.SelectedIndex == -1)
            {
                cboParentesco.Text = "Seleccione Parentezco";
            }
            #endregion

            txtCostoTotal.Enabled = false;

            NegocioServicio Serv = new NegocioServicio();

            cboServicio.DataSource = Serv.listarServicio();
            cboServicio.DisplayMember = "NOMBRE_SERV";
            cboServicio.ValueMember = "ID_SERVICIO";

            cboServicio.SelectedIndex = -1;
            if (cboServicio.SelectedIndex == -1)
            {
                cboServicio.Text = "Seleccione un Servicio";
            }

            NegocioContrato Contra = new NegocioContrato();
            cboCondicionesC.DataSource = Contra.listarContrato();
            cboCondicionesC.DisplayMember = "CONDICIONES_PERM";
            cboCondicionesC.ValueMember = "ID_CONTRATO";

            cboCondicionesC.SelectedIndex = -1;
            if (cboCondicionesC.SelectedIndex == -1)
            {
                cboCondicionesC.Text = "Seleccion una Condicion";
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Direccion direccion = new Direccion();
                NegocioDireccion auxDireccion = new NegocioDireccion();

                InformacionPersonal infoPersonal = new InformacionPersonal();
                NegocioInfoPersonal auxInfoPersonal = new NegocioInfoPersonal();

                Familiar familiar = new Familiar();
                NegocioFamiliar auxFamiliar = new NegocioFamiliar();

                Contrato contrato = new Contrato();
                NegocioContrato auxContrato = new NegocioContrato();

                DetaContrato detContrato = new DetaContrato();
                NegocioDetContrato auxDetContrato = new NegocioDetContrato();

                Servicio servicio = new Servicio();
                NegocioServicio auxServicio = new NegocioServicio();
                Seguridad seguridad = new Seguridad();


                if (txtRutP.Text != "" || txtNombreP.Text != "" || txtNombreP.Text != "" || txtApePaternoP.Text != "" || txtApeMaternoP.Text != "" || DateFechaNacP.Text != "" || txtTelefonoP.Text != "" || txtEmailP.Text != "" ||
                        txtCiudad.Text != "" || txtCalle.Text != "" || txtCodigoP.Text != "")
                {
                    if (auxInfoPersonal.consultarRut(txtRutP.Text) == false)
                    {
                        if (seguridad.validarRut(txtRutP.Text))
                        {
                            if (DateTime.Compare(DateTime.Today, DateFechaNacP.Value.Date) > 0)
                            {
                                if (ComprobarFormatoEmail(txtEmailP.Text) == true)
                                {
                                    if (cboRegion.SelectedIndex != -1 | cboComuna.SelectedIndex != -1 | cboServicio.SelectedIndex != -1| cboCondicionesC.SelectedIndex !=-1| cboParentesco.SelectedIndex != -1)
                                    {
                                        DialogResult dialogResult = MessageBox.Show("Desea Agregar la Informacion Personal del Familiar " + txtNombreP.Text + " " + txtApePaternoP.Text, "Informacion", MessageBoxButtons.YesNo);
                                        if (dialogResult == DialogResult.Yes)
                                        {
                                            DialogResult resultado = MessageBox.Show("Si Ingresara la Informacion Personal del Familiar ¿Desea Continuar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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


                                                    direccion.Calle = txtCalle.Text.ToUpper().Trim();
                                                    direccion.Comuna = cboComuna.SelectedValue.ToString().ToUpper().Trim();
                                                    direccion.Cuidad = txtCiudad.Text.ToUpper().Trim();
                                                    direccion.Region = cboRegion.SelectedValue.ToString().ToUpper().Trim();
                                                    direccion.CodigoPostal = int.Parse(txtCodigoP.Text.ToUpper().Trim());

                                                    if (auxDireccion.ingresarDireccion(direccion) > 0)
                                                    {
                                                        //Datos Informacion Personal
                                                        infoPersonal.Nombre = txtNombreP.Text.ToUpper().Trim();
                                                        infoPersonal.ApellidoPat = txtApePaternoP.Text.ToUpper().Trim();
                                                        infoPersonal.ApellidoMat = txtApeMaternoP.Text.ToUpper().Trim();
                                                        infoPersonal.Rut = txtRutP.Text.ToUpper().Trim();
                                                        infoPersonal.FechaNac = DateFechaNacP.Value;
                                                        infoPersonal.Telefono = int.Parse(txtTelefonoP.Text);
                                                        infoPersonal.Email = txtEmailP.Text.ToUpper().Trim();
                                                        infoPersonal.IdDireccion = auxDireccion.consultarDireccion(direccion.Calle);

                                                        if (auxInfoPersonal.IngresarInfoPersonal(infoPersonal) > 0)
                                                        {
                                                            InformacionPersonal idinfo = new InformacionPersonal();
                                                            idinfo = auxInfoPersonal.BuscaridPorRut(infoPersonal.Rut);

                                                            familiar.IdInfoPersonal = idinfo.Id_InfoPersonal;
                                                            familiar.IdContrato = int.Parse(cboCondicionesC.SelectedValue.ToString());
                                                            familiar.Parentezco = cboParentesco.SelectedValue.ToString().ToUpper().Trim();

                                                            if (auxFamiliar.IngresarFamiliar(familiar) > 0)
                                                            {
                                                                txtRutP.Text = string.Empty;
                                                                txtNombreP.Text = string.Empty;
                                                                txtApePaternoP.Text = string.Empty;
                                                                txtApeMaternoP.Text = string.Empty;
                                                                
                                                                DateFechaNacP.Value = DateTime.Now;
                                                                txtTelefonoP.Text = string.Empty;
                                                                txtEmailP.Text = string.Empty;
                                                                cboComuna.SelectedIndex = -1;
                                                                cboRegion.SelectedIndex = -1;
                                                                txtCiudad.Text = string.Empty;
                                                                txtCalle.Text = string.Empty;
                                                                txtCodigoP.Text = string.Empty;
                                                                cboParentesco.SelectedIndex = -1;
                                                                cboServicio.SelectedIndex = -1;
                                                                cboCondicionesC.SelectedIndex = -1;
                                                                txtCostoTotal.Text = string.Empty;
                                                                
                                                                MessageBox.Show("Familiar Ingresado");
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Error al Ingresar Familiar");
                                                            }
                                                                                                                              
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Informacion Personal no Ingresa");
                                                        }
                                                        
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Direccion no Ingresada");
                                                    }
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }


                                    }
                                    else
                                    {
                                        MessageBox.Show("Seleccione todos las listas.", "Información");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("El formato del email no es valido");
                                }
                            }
                            else
                            {
                                MessageBox.Show("La fecha de Nacimiento no puede ser mayor a la fecha de hoy");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Rut no es Valido");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rut ya existente ingrese otro");
                    }

                }
                else
                {
                    MessageBox.Show("No deje ningún campo vacío");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar " + ex);
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

        //Metodo que valida el formato del Email
        public static bool ComprobarFormatoEmail(string seMailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato))
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        
        private void cboServicio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Servicio servicio = new Servicio();
                NegocioServicio auxServicio = new NegocioServicio();
                DetaContrato deta = new DetaContrato();
                NegocioDetContrato auxdetc = new NegocioDetContrato();
                Contrato contrato = new Contrato();



                servicio = auxServicio.consultaporIdServicio(int.Parse(cboServicio.SelectedValue.ToString()));
                
                
                txtCostoTotal.Text = servicio.CostoServicio.ToString(); ;
                lblDesServtex.Text = servicio.Descripcion.ToString();
            }catch(Exception){
                MessageBox.Show("Error");
            }
        }

        private void txtRutP_TextChanged(object sender, EventArgs e)
        {
            if (txtRutP.TextLength > 9)
            {
                txtRutP.MaxLength = 9;
                MessageBox.Show("Debe ingresar sólo 9 números");
                txtRutP.Text = "";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            IngresarResidente IR = new IngresarResidente();
            IR.Show();
            this.Hide();
        }

        private void txtTelefonoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtRutP_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtRutP.Text, @"\b\d{7,8}\-[K|k|0-9]")) && (txtRutP.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres válidos");
                this.txtRutP.Focus();
                txtRutP.Text = "";
            }
        }

        

        private void txtNombreP_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtNombreP.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (txtNombreP.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtNombreP.Focus();
                txtNombreP.Text = "";
            }
        }

        private void txtApePaternoP_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtApePaternoP.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (txtApePaternoP.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtApePaternoP.Focus();
                txtApePaternoP.Text = "";
            }
        }

        private void txtApeMaternoP_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtApeMaternoP.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (txtApeMaternoP.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtApeMaternoP.Focus();
                txtApeMaternoP.Text = "";
            }
        }

        private void txtCiudad_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtCiudad.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (txtCiudad.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtCiudad.Focus();
                txtCiudad.Text = "";
            }
        }

        private void txtRutP_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCalle_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtCalle.Text, @"^[A-Z0-9 a-z]*$")) && (txtCalle.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtCalle.Focus();
                txtCalle.Text = "";
            }
        }
    }
}