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
using Capa_DTO.Farmacia;
using CapaNegocio.NegocioResidente;
using CapaNegocio.NegocioFarmacia;
using System.Text.RegularExpressions;
using System.Globalization;
using AplicacionDesktop.CRUD;
using AplicacionDesktop.CRUDUsuario;
using Capa_DTO.Seguridad;

namespace AplicacionDesktop.CRUD
{
    public partial class InsertarDatosResidente : Form
    {
        public InsertarDatosResidente()
        {
            InitializeComponent();

            cboRegion.DropDownStyle = ComboBoxStyle.DropDownList;
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
            DComuna.Add("5", "Cerro Navia");
            DComuna.Add("6", "Estación Central");
            DComuna.Add("7", "Huechuraba");
            DComuna.Add("8", "Independencia");
            DComuna.Add("9", "La Cisterna");
            DComuna.Add("10", "Independencia");
            DComuna.Add("11", "La Florida");
            DComuna.Add("12", "La Granja");
            DComuna.Add("13", "La Pintana");
            DComuna.Add("14", "La Reina");
            DComuna.Add("15", "Las Condes");
            DComuna.Add("16", "Lo Barnechea");
            DComuna.Add("17", "Lo Espejo");
            DComuna.Add("18", "Lo Prado");
            DComuna.Add("19", "Macul");
            DComuna.Add("20", "Maipú");
            DComuna.Add("21", "Ñuñoa");
            DComuna.Add("22", "Pedro Aguirre Cerda");
            DComuna.Add("23", "Peñalolén");
            DComuna.Add("24", "Providencia");
            DComuna.Add("25", "Pudahuel");
            DComuna.Add("26", "Quilicura");
            DComuna.Add("27", "Quinta Normal");
            DComuna.Add("28", "Recoleta");
            DComuna.Add("29", "Renca");
            DComuna.Add("30", "San Joaquín");
            DComuna.Add("31", "San Miguel");
            DComuna.Add("32", "San Ramón");
            DComuna.Add("33", "Vitacura");
            cboComuna.DisplayMember = "Value";
            cboComuna.ValueMember = "Value";
            cboComuna.DataSource = DComuna.ToArray();
            cboComuna.SelectedIndex = -1;
            if (cboComuna.SelectedIndex == -1)
            {
                cboComuna.Text = "Seleccione Comuna";
            }
            #endregion
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Direccion direccion = new Direccion();
                NegocioDireccion auxDireccion = new NegocioDireccion();

                InformacionPersonal infoPersonal = new InformacionPersonal();
                NegocioInfoPersonal auxInfoPersonal = new NegocioInfoPersonal();
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
                                    if (cboRegion.SelectedIndex != -1 | cboComuna.SelectedIndex != -1)
                                    {
                                        DialogResult dialogResult = MessageBox.Show("Desea Agregar la Informacion Personal del Residente " + txtNombreP.Text + " " + txtApePaternoP.Text, "Informacion", MessageBoxButtons.YesNo);
                                        if (dialogResult == DialogResult.Yes)
                                        {
                                            DialogResult resultado = MessageBox.Show("Si Ingresara la Informacion Personal ¿Desea Continuar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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

                                                            MessageBox.Show("Informacion Personal del Residente Ingresada");
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Error");
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
                MessageBox.Show("Error al Ingresar " +ex );
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

        private void txtTelefonoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        

        private void btnVolver_Click(object sender, EventArgs e)
        {
            IngresarResidente IR = new IngresarResidente();
            IR.Show();
            this.Hide();
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
