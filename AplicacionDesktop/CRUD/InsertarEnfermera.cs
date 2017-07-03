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
using System.Text.RegularExpressions;
using CapaNegocio.NegocioUsuario;
using CapaNegocio.NegocioResidente;
using Capa_DTO.Residente;
using Capa_DTO.Usuario;
using Capa_DTO.Farmacia;
using CapaNegocio.NegocioFarmacia;
using Capa_DTO.Seguridad;

namespace AplicacionDesktop.CRUD
{
    public partial class InsertarEnfermera : Form
    {
        public InsertarEnfermera()
        {
            InitializeComponent();
            CargarRol();
            cboRol.Enabled = false;
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

        public void CargarRol()
        {
            try
            {
                NegocioRol auxRol = new NegocioRol();
                cboRol.DataSource = auxRol.listarRoles();
                cboRol.DisplayMember = "NOMBRE_ROL";
                cboRol.ValueMember = "ID_ROL";
                cboRol.SelectedIndex = -1;
                if (cboRol.SelectedIndex ==-1)
                {
                    cboRol.Text = "Enfermera";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No existen datos en Rol");
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

                Usuario usuario = new Usuario();
                NegocioUsuario auxUsuario = new NegocioUsuario();

                Enfermera enfermera = new Enfermera();
                NegocioEnfermera auxEnfermera = new NegocioEnfermera();
                Seguridad seguridad = new Seguridad();


                if (txtRut.Text != "" && txtNombre.Text != "" && txtNombre.Text != "" && txtApePaterno.Text != "" && txtApeMaterno.Text != "" && DateFechaNac.Text != "" && txtTelefono.Text != "" && txtEmail.Text != "" &&
                        txtCiudad.Text != "" && txtCalle.Text != "" && txtCodigoP.Text != "" && txtTurno.Text != "" && txtDescripcion.Text != "" && txtEspecialidad.Text != "" && txtContraseña.Text != "")
                {
                    if (auxInfoPersonal.consultarRut(txtRut.Text) == false)
                    {
                        if (validarRut(txtRut.Text))
                        {
                            if (DateTime.Compare(DateTime.Today, DateFechaNac.Value.Date) > 0)
                            {
                                if (DateTime.Compare(DateTime.Today, DateFechIngreso.Value.Date) <= 0)
                                {
                                    //usuario = auxUsuario.buscarUsuarioporRut(txtRut.Text);

                                    usuario.RutUsuario = txtRut.Text;
                                    if (auxUsuario.consultaUsuario(usuario.IdUsuario) == 0)
                                    {

                                        if (ComprobarFormatoEmail(txtEmail.Text) == true)
                                        {
                                            if (cboRegion.SelectedIndex != -1 && cboComuna.SelectedIndex != -1)
                                            {
                                                DialogResult dialogResult = MessageBox.Show("Desea Agregar una Nueva Enfermera de nombre : " + txtNombre.Text + " " + txtApePaterno.Text, "Informacion", MessageBoxButtons.YesNo);
                                                if (dialogResult == DialogResult.Yes)
                                                {
                                                    DialogResult resultado = MessageBox.Show("Si Ingresara la Enfermera ¿Desea Continuar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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
                                                                infoPersonal.Nombre = txtNombre.Text.ToUpper().Trim();
                                                                infoPersonal.ApellidoPat = txtApePaterno.Text.ToUpper().Trim();
                                                                infoPersonal.ApellidoMat = txtApeMaterno.Text.ToUpper().Trim();
                                                                infoPersonal.Rut = txtRut.Text.ToUpper().Trim();
                                                                infoPersonal.FechaNac = DateFechaNac.Value;
                                                                infoPersonal.Telefono = int.Parse(txtTelefono.Text);
                                                                infoPersonal.Email = txtEmail.Text.ToUpper().Trim();
                                                                infoPersonal.IdDireccion = auxDireccion.consultarDireccion(direccion.Calle);

                                                                if (auxInfoPersonal.IngresarInfoPersonal(infoPersonal) > 0)
                                                                {

                                                                    NegocioRol auxrol = new NegocioRol();
                                                                    Rol BuscaRol = new Rol();
                                                                    BuscaRol= auxrol.rolPorNombre("ENFERMERA");

                                                                    usuario.RutUsuario = txtRut.Text.ToUpper().Trim();
                                                                    usuario.Contrasena = seguridad.SHA256Encrypt(txtContraseña.Text.ToUpper().Trim());
                                                                    usuario.IdRol = BuscaRol.IdRol;


                                                                    if (auxUsuario.ingresarUsuario(usuario) > 0)
                                                                    {
                                                                        InformacionPersonal buscarinfo = new InformacionPersonal();
                                                                        Usuario buscarUsuario = new Usuario();
                                                                        buscarinfo = auxInfoPersonal.BuscaridPorRut(txtRut.Text.ToUpper().Trim());
                                                                        buscarUsuario = auxUsuario.buscarUsuarioporRut(txtRut.Text.ToUpper().Trim());

                                                                        enfermera.Turno = txtTurno.Text.ToUpper().Trim();
                                                                        enfermera.Especialidad = txtEspecialidad.Text.ToUpper().Trim();
                                                                        enfermera.Descripcion = txtDescripcion.Text.ToUpper().Trim();
                                                                        enfermera.FechaIngreso = DateFechIngreso.Value;
                                                                        enfermera.Id_infopersonal = buscarinfo.Id_InfoPersonal;
                                                                        enfermera.Id_usuario = buscarUsuario.IdUsuario;

                                                                        if (auxEnfermera.IngresarEnfermera(enfermera) > 0)
                                                                        {

                                                                            txtRut.Text = string.Empty;
                                                                            txtNombre.Text = string.Empty;
                                                                            txtApePaterno.Text = string.Empty;
                                                                            txtApeMaterno.Text = string.Empty;
                                                                            DateFechaNac.Value = DateTime.Now;
                                                                            txtTelefono.Text = string.Empty;
                                                                            txtEmail.Text = string.Empty;
                                                                            cboComuna.SelectedIndex = -1;
                                                                            cboRegion.SelectedIndex = -1;
                                                                            txtCiudad.Text = string.Empty;
                                                                            txtCalle.Text = string.Empty;
                                                                            txtCodigoP.Text = string.Empty;
                                                                            txtTurno.Text = string.Empty;
                                                                            txtEspecialidad.Text = string.Empty;
                                                                            txtDescripcion.Text = string.Empty;
                                                                            DateFechIngreso.Value = DateTime.Now;
                                                                            cboRol.SelectedIndex = -1;
                                                                            txtContraseña.Text = string.Empty;


                                                                            MessageBox.Show("Enfermera Ingresada Ingresada");
                                                                        }
                                                                        else
                                                                        {
                                                                            MessageBox.Show("Error al Ingresar una Enfermera");
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("Usuario no Ingresado");
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Informacion Personal no Ingresada");
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
                                        MessageBox.Show("Rut ya existe como Usuario");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La fecha de Ingreso no puede ser menor a la fecha actual");
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdminEnfermera MAE = new MenuAdminEnfermera();
            MAE.Show();
            this.Hide();
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

        private void txtRut_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtRut.Text, @"^\d+$")) && (txtRut.Text != ""))
            {
                MessageBox.Show("Si su Rut termina en K reemplace a un cero");
                this.txtRut.Focus();
                txtRut.Text = "";
            }
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Si su rut termina en K reemplace por un cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtNombre.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (txtNombre.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtNombre.Focus();
                txtNombre.Text = "";
            }
        }

        private void txtApePaterno_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtApePaterno.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (txtApePaterno.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtApePaterno.Focus();
                txtApePaterno.Text = "";
            }
        }

        private void txtApeMaterno_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtApeMaterno.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (txtApeMaterno.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtApeMaterno.Focus();
                txtApeMaterno.Text = "";
            }
        }

        private void txtTurno_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtTurno.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (txtTurno.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtTurno.Focus();
                txtTurno.Text = "";
            }
        }

        private void txtEspecialidad_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtEspecialidad.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (txtEspecialidad.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtEspecialidad.Focus();
                txtEspecialidad.Text = "";
            }
        }

        private void txtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtDescripcion.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (txtDescripcion.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtDescripcion.Focus();
                txtDescripcion.Text = "";
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

        private void txtCalle_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtCalle.Text, @"^[A-Z0-9 a-z]*$")) && (txtCalle.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtCalle.Focus();
                txtCalle.Text = "";
            }
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtContraseña.Text, @"^[A-Z0-9 a-z]*$")) && (txtContraseña.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtContraseña.Focus();
                txtContraseña.Text = "";
            }
        }
    }
}
