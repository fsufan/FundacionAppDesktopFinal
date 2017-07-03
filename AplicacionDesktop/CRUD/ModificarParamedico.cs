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
using Capa_DTO.Medicamento;
using Capa_DTO.Farmacia;
using CapaNegocio.NegocioUsuario;
using CapaNegocio.NegocioResidente;
using CapaNegocio.NegocioFarmacia;
using System.Text.RegularExpressions;
using AplicacionDesktop.MENU;

namespace AplicacionDesktop.CRUD
{
    public partial class ModificarParamedico : Form
    {
        public ModificarParamedico()
        {
            InitializeComponent();
            lblidUsuario.Visible = false;
            lblidinfo.Visible = false;
            lblddireccion.Visible = false;
            lblidParamedico.Visible = false;
            DateFechIngreso.Enabled = false;
        }

        private void cargarComunas(String comuna)
        {
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

            if (comuna.ToUpper().ToString().Equals("Santiago"))
            {
                cboComuna.Text = "Santiago";
            }
            else if (comuna.ToUpper().ToString().Equals("Cerrillos"))
            {
                cboComuna.Text = "Cerrillos";

            }
            else if (comuna.ToUpper().ToString().Equals("Cerro Navia"))
            {
                cboComuna.Text = "Cerro Navia";
            }
            else if (comuna.ToUpper().ToString().Equals("Conchalí"))
            {
                cboComuna.Text = "Conchalí";
            }
            else if (comuna.ToUpper().ToString().Equals("El Bosque"))
            {
                cboComuna.Text = "El Bosque";
            }
            else if (comuna.ToUpper().ToString().Equals("Estación Central"))
            {
                cboComuna.Text = "Estación Central";
            }
            else if (comuna.ToUpper().ToString().Equals("Huechuraba"))
            {
                cboComuna.Text = "Huechuraba";
            }
            else if (comuna.ToUpper().ToString().Equals("Independencia"))
            {
                cboComuna.Text = "Independencia";
            }
            else if (comuna.ToUpper().ToString().Equals("La Cisterna"))
            {
                cboComuna.Text = "La Cisterna";
            }
            else if (comuna.ToUpper().ToString().Equals("La Florida"))
            {
                cboComuna.Text = "La Florida";
            }
            else if (comuna.ToUpper().ToString().Equals("La Granja"))
            {
                cboComuna.Text = "La Granja";
            }
            else if (comuna.ToUpper().ToString().Equals("La Pintana"))
            {
                cboComuna.Text = "La Pintana";
            }
            else if (comuna.ToUpper().ToString().Equals("La Reina"))
            {
                cboComuna.Text = "La Reina";
            }
            else if (comuna.ToUpper().ToString().Equals("Las Condes"))
            {
                cboComuna.Text = "Las Condes";
            }
            else if (comuna.ToUpper().ToString().Equals("Lo Barnechea"))
            {
                cboComuna.Text = "Lo Barnechea";
            }
            else if (comuna.ToUpper().ToString().Equals("Lo Espejo"))
            {
                cboComuna.Text = "Lo Espejo";
            }
            else if (comuna.ToUpper().ToString().Equals("Lo Prado"))
            {
                cboComuna.Text = "Lo Prado";
            }
            else if (comuna.ToUpper().ToString().Equals("Macul"))
            {
                cboComuna.Text = "Macul";
            }
            else if (comuna.ToUpper().ToString().Equals("Maipú"))
            {
                cboComuna.Text = "Maipú";
            }
            else if (comuna.ToUpper().ToString().Equals("Ñuñoa"))
            {
                cboComuna.Text = "Ñuñoa";
            }
            else if (comuna.ToUpper().ToString().Equals("Pedro Aguirre Cerda"))
            {
                cboComuna.Text = "Pedro Aguirre Cerda";
            }
            else if (comuna.ToUpper().ToString().Equals("Peñalolén"))
            {
                cboComuna.Text = "Peñalolén";
            }
            else if (comuna.ToUpper().ToString().Equals("Providencia"))
            {
                cboComuna.Text = "Providencia";
            }
            else if (comuna.ToUpper().ToString().Equals("Pudahuel"))
            {
                cboComuna.Text = "Pudahuel";
            }
            else if (comuna.ToUpper().ToString().Equals("Quilicura"))
            {
                cboComuna.Text = "Quilicura";
            }
            else if (comuna.ToUpper().ToString().Equals("Quinta Normal"))
            {
                cboComuna.Text = "Quinta Normal";
            }
            else if (comuna.ToUpper().ToString().Equals("Recoleta"))
            {
                cboComuna.Text = "Recoleta";
            }
            else if (comuna.ToUpper().ToString().Equals("Renca"))
            {
                cboComuna.Text = "Renca";
            }
            else if (comuna.ToUpper().ToString().Equals("San Joaquín"))
            {
                cboComuna.Text = "San Joaquín";
            }
            else if (comuna.ToUpper().ToString().Equals("San Miguel"))
            {
                cboComuna.Text = "San Miguel";
            }
            else if (comuna.ToUpper().ToString().Equals("San Ramón"))
            {
                cboComuna.Text = "San Ramón";
            }
            else if (comuna.ToUpper().ToString().Equals("Vitacura"))
            {
                cboComuna.Text = "Vitacura";
            }

        }

        private void cargarRegion(String region)
        {
            try
            {
                Dictionary<string, string> Dregion = new Dictionary<string, string>();
                Dregion.Add("13", "Metropolitana");
                cboRegion.DisplayMember = "Value";
                cboRegion.ValueMember = "Value";
                cboRegion.DataSource = Dregion.ToArray();

                if (region.ToUpper().ToString().Equals("Metropolitana"))
                {
                    cboRegion.Text = "Metropolitana";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Direccion direccion = new Direccion();
                NegocioDireccion auxDireccion = new NegocioDireccion();

                InformacionPersonal infoPersonal = new InformacionPersonal();
                NegocioInfoPersonal auxInfoPersonal = new NegocioInfoPersonal();

                Usuario usuario = new Usuario();
                NegocioUsuario auxUsuario = new NegocioUsuario();

                Paramedico paramedico = new Paramedico();
                NegocioParamedico auxParamedico = new NegocioParamedico();


                if (txtRut.Text != "" && txtNombre.Text != "" && txtNombre.Text != "" && txtApePaterno.Text != "" && txtApeMaterno.Text != "" && DateFechaNac.Text != "" && txtTelefono.Text != "" && txtEmail.Text != "" &&
                        txtCiudad.Text != "" && txtCalle.Text != "" && txtCodigoP.Text != "" && txtTurno.Text != "" && txtDescripcion.Text != "" && txtEspecialidad.Text != "")
                {

                    if (validarRut(txtRut.Text))
                    {
                        if (DateTime.Compare(DateTime.Today, DateFechaNac.Value.Date) > 0)
                        {


                            if (ComprobarFormatoEmail(txtEmail.Text) == true)
                            {
                                if (cboRegion.SelectedIndex != -1 && cboComuna.SelectedIndex != -1)
                                {
                                    DialogResult dialogResult = MessageBox.Show("Desea Modificar el Paramedico de nombre : " + txtNombre.Text + " " + txtApePaterno.Text, "Informacion", MessageBoxButtons.YesNo);
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        DialogResult resultado = MessageBox.Show("Se modificara el Paramedico ¿Desea Continuar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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


                                                direccion.Id_direccion = int.Parse(lblddireccion.Text);
                                                direccion.Calle = txtCalle.Text.ToUpper().Trim();
                                                direccion.Comuna = cboComuna.SelectedValue.ToString().ToUpper().Trim();
                                                direccion.Cuidad = txtCiudad.Text.ToUpper().Trim();
                                                direccion.Region = cboRegion.SelectedValue.ToString().ToUpper().Trim();
                                                direccion.CodigoPostal = int.Parse(txtCodigoP.Text.ToUpper().Trim());

                                                if (auxDireccion.actualizarDireccion(direccion) > 0)
                                                {
                                                    //Datos Informacion Personal
                                                    infoPersonal.Id_InfoPersonal = int.Parse(lblidinfo.Text);
                                                    infoPersonal.Nombre = txtNombre.Text.ToUpper().Trim();
                                                    infoPersonal.ApellidoPat = txtApePaterno.Text.ToUpper().Trim();
                                                    infoPersonal.ApellidoMat = txtApeMaterno.Text.ToUpper().Trim();
                                                    infoPersonal.Rut = txtRut.Text.ToUpper().Trim();
                                                    infoPersonal.FechaNac = DateFechaNac.Value;
                                                    infoPersonal.Telefono = int.Parse(txtTelefono.Text);
                                                    infoPersonal.Email = txtEmail.Text.ToUpper().Trim();
                                                    infoPersonal.IdDireccion = auxDireccion.consultarDireccion(direccion.Calle);

                                                    if (auxInfoPersonal.ActualizarInfoPersonal(infoPersonal) > 0)
                                                    {

                                                        //usuario.IdRol = 3;
                                                        //usuario.RutUsuario = txtRut.Text.ToUpper().Trim();
                                                        // usuario.Contrasena = txtContraseña.Text.ToUpper().Trim();


                                                        paramedico.Id_paramedico = int.Parse(lblidParamedico.Text);
                                                        paramedico.Turno = txtTurno.Text.ToUpper().Trim();
                                                        paramedico.Especialidad = txtEspecialidad.Text.ToUpper().Trim();
                                                        paramedico.Descripcion = txtDescripcion.Text.ToUpper().Trim();
                                                        paramedico.FechaIngreso = DateFechIngreso.Value;
                                                        paramedico.Id_infopersonal = int.Parse(lblidinfo.Text);
                                                        paramedico.Id_usuario = int.Parse(lblidUsuario.Text);

                                                        if (auxParamedico.ActualizarParamedico(paramedico) > 0)
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
                                                            lblidParamedico.Text = string.Empty;
                                                            lblidinfo.Text = string.Empty;
                                                            lblidUsuario.Text = string.Empty;
                                                            lblddireccion.Text = string.Empty;
                                                            

                                                            MessageBox.Show("Paramedico Modificado ");
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Error al modificar un Paramedico");
                                                        }

                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Informacion Personal no Modificada");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Direccion no Modificada");
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
                    MessageBox.Show("No deje ningún campo vacío");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar " + ex);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                InformacionPersonal infop = new InformacionPersonal();
                NegocioInfoPersonal AuxInfo = new NegocioInfoPersonal();
                Paramedico paramedico = new Paramedico();
                NegocioParamedico auxParamedico = new NegocioParamedico();
                NegocioDireccion auxDireccion = new NegocioDireccion();
                Direccion direccion = new Direccion();

                if (txtRut.Text != "")
                {


                    if (validarRut(txtRut.Text))
                    {

                        if (AuxInfo.consultarRut(txtRut.Text) == true)
                        {
                            infop = AuxInfo.BuscaridPorRut(txtRut.Text.ToUpper().Trim());
                            direccion = auxDireccion.consultarPorId(infop.IdDireccion);
                            paramedico = auxParamedico.consultarParamedicoporIDinfoP(infop.Id_InfoPersonal);

                            txtNombre.Text = infop.Nombre;
                            txtApePaterno.Text = infop.ApellidoPat;
                            txtApeMaterno.Text = infop.ApellidoMat;
                            DateFechaNac.Value = infop.FechaNac;
                            txtTelefono.Text = infop.Telefono.ToString();
                            txtEmail.Text = infop.Email;
                            lblidinfo.Text = infop.Id_InfoPersonal.ToString();

                            cargarComunas(direccion.Comuna);
                            cargarRegion(direccion.Region);
                            txtCiudad.Text = direccion.Cuidad;
                            txtCalle.Text = direccion.Calle;
                            txtCodigoP.Text = direccion.CodigoPostal.ToString();
                            lblddireccion.Text = direccion.Id_direccion.ToString();

                            txtTurno.Text = paramedico.Turno;
                            txtEspecialidad.Text = paramedico.Especialidad;
                            txtDescripcion.Text = paramedico.Descripcion;
                            DateFechIngreso.Value = paramedico.FechaIngreso;
                            lblidUsuario.Text = paramedico.Id_usuario.ToString();
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


                txtRut.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtApeMaterno.Text = string.Empty;
                txtApePaterno.Text = string.Empty;
                DateFechaNac.Value = DateTime.Now;
                txtTelefono.Text = string.Empty;
                txtEmail.Text = string.Empty;
                cboComuna.SelectedIndex = -1;
                cboRegion.SelectedIndex = -1;
                txtCalle.Text = string.Empty;
                txtCiudad.Text = string.Empty;
                txtCodigoP.Text = string.Empty;
                MessageBox.Show("El rut no pertenece  al de un Paramedico");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdminParamedico mAP = new MenuAdminParamedico();
            mAP.Show();
            this.Hide();
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
    }
}
