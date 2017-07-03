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
using Capa_DTO.Residente;
using Capa_DTO.Farmacia;
using CapaNegocio.NegocioFarmacia;
using System.Text.RegularExpressions;
using AplicacionDesktop.CRUD;
using AplicacionDesktop.CRUDUsuario;

namespace AplicacionDesktop.CRUD
{
    public partial class ModificarFamiliar : Form
    {
        public ModificarFamiliar()
        {
            InitializeComponent();
            txtCostoTotal.Enabled = false;
            
            // Region
            #region cboregion
            //Dictionary<string, string> Dregion = new Dictionary<string, string>();
            //Dregion.Add("13", "Metropolitana");
            //cboRegion.DisplayMember = "Value";
            //cboRegion.ValueMember = "Value";
            //cboRegion.DataSource = Dregion.ToArray();
            //cboRegion.SelectedIndex = -1;
            //if (cboRegion.SelectedIndex == -1)
            //{
            //    cboRegion.Text = "Seleccione Region";
            //}

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

            NegocioInfoPersonal InfoRF = new NegocioInfoPersonal();
            cborut.DataSource = InfoRF.listarInfoPersonal();
            cborut.DisplayMember = "Rut";
            cborut.ValueMember = "id_infopersonal";
            cborut.SelectedIndex = -1;
            if (cborut.SelectedIndex == -1)
            {
                cborut.Text = "Seleccione un Familiar";
            }

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

        private void cargarParentezco(String parentezco)
        {
            try
            {
                Dictionary<string, string> parentesco = new Dictionary<string, string>();
                parentesco.Add("1", "Hijo");
                parentesco.Add("2", "Hija");
                parentesco.Add("3", "Padre");
                parentesco.Add("4", "Madre");
                cboParentesco.DisplayMember = "Value";
                cboParentesco.ValueMember = "Value";
                cboParentesco.DataSource = parentesco.ToArray();

                if (parentezco.ToUpper().ToString().Equals("Hijo"))
                {
                    cboParentesco.Text = "Hijo";
                }
                else if (parentezco.ToUpper().ToString().Equals("Hija"))
                {
                    cboParentesco.Text = "Hija";
                }
                else if (parentezco.ToUpper().ToString().Equals("Padre"))
                {
                    cboParentesco.Text = "Padre";
                }
                else if (parentezco.ToUpper().ToString().Equals("Madre"))
                {
                    cboParentesco.Text = "Madre";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El Rut seleccionado no es de un familiar");
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

                Familiar familiar = new Familiar();
                NegocioFamiliar auxFamiliar = new NegocioFamiliar();

                Contrato contrato = new Contrato();
                NegocioContrato auxContrato = new NegocioContrato();

                DetaContrato detContrato = new DetaContrato();
                NegocioDetContrato auxDetContrato = new NegocioDetContrato();

                Servicio servicio = new Servicio();
                NegocioServicio auxServicio = new NegocioServicio();


                if ( txtNombreP.Text != "" || txtNombreP.Text != "" || txtApePaternoP.Text != "" || txtApeMaternoP.Text != "" || DateFechaNacP.Text != "" || txtTelefonoP.Text != "" || txtEmailP.Text != "" ||
                        txtCiudad.Text != "" || txtCalle.Text != "" || txtCodigoP.Text != "")
                {
                                            
                            if (DateTime.Compare(DateTime.Today, DateFechaNacP.Value.Date) > 0)
                            {
                                if (ComprobarFormatoEmail(txtEmailP.Text) == true)
                                {
                                    if (cborut.SelectedIndex!=-1| cboRegion.SelectedIndex != -1 | cboComuna.SelectedIndex != -1 | cboServicio.SelectedIndex != -1| cboCondicionesC.SelectedIndex !=-1| cboParentesco.SelectedIndex != -1)
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

                                                    direccion.Id_direccion = int.Parse(txtiddireccion.Text.ToUpper().Trim());
                                                    direccion.Calle = txtCalle.Text.ToUpper().Trim();
                                                    direccion.Comuna = cboComuna.SelectedValue.ToString().ToUpper().Trim();
                                                    direccion.Cuidad = txtCiudad.Text.ToUpper().Trim();
                                                    direccion.Region = cboRegion.SelectedValue.ToString().ToUpper().Trim();
                                                    direccion.CodigoPostal = int.Parse(txtCodigoP.Text.ToUpper().Trim());

                                                    if (auxDireccion.actualizarDireccion(direccion) > 0)
                                                    {
                                                        infoPersonal = auxInfoPersonal.consultaporIdInfoPersonal(int.Parse(cborut.SelectedValue.ToString()));
                                                        //Datos Informacion Personal
                                                        infoPersonal.Id_InfoPersonal = int.Parse(cborut.SelectedValue.ToString());
                                                        infoPersonal.Nombre = txtNombreP.Text.ToUpper().Trim();
                                                        infoPersonal.ApellidoPat = txtApePaternoP.Text.ToUpper().Trim();
                                                        infoPersonal.ApellidoMat = txtApeMaternoP.Text.ToUpper().Trim();
                                                        infoPersonal.Rut = infoPersonal.Rut;
                                                        infoPersonal.FechaNac = DateFechaNacP.Value;
                                                        infoPersonal.Telefono = int.Parse(txtTelefonoP.Text);
                                                        infoPersonal.Email = txtEmailP.Text.ToUpper().Trim();
                                                        infoPersonal.IdDireccion = auxDireccion.consultarDireccion(direccion.Calle);

                                                        if (auxInfoPersonal.ActualizarInfoPersonal(infoPersonal) > 0)
                                                        {
                                                            InformacionPersonal idinfo = new InformacionPersonal();
                                                            idinfo = auxInfoPersonal.BuscaridPorRut(infoPersonal.Rut);

                                                            familiar.IdFamiliar = int.Parse(txtidFamiliar.Text);
                                                            familiar.IdInfoPersonal = idinfo.Id_InfoPersonal;
                                                            familiar.IdContrato = int.Parse(cboCondicionesC.SelectedValue.ToString());
                                                            familiar.Parentezco = cboParentesco.SelectedValue.ToString().ToUpper().Trim();

                                                            if (auxFamiliar.ActualizarFamiliar(familiar) > 0)
                                                            {
                                                                cborut.SelectedIndex = -1;
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

                                                                MessageBox.Show("Familiar Modificado");
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Error al Modificar el Familiar");
                                                            }

                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Informacion Personal no Mofificada");
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
                    MessageBox.Show("No deje ningún campo vacío");
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al Modificar" + ex);
            }
        }

        private void cborut_SelectionChangeCommitted(object sender, EventArgs e)
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
            NegocioInfoPersonal auxinfo = new NegocioInfoPersonal();
            NegocioDireccion auxDireccion = new NegocioDireccion();
            Direccion direc = new Direccion();
            


            infoP = auxinfo.consultaporIdInfoPersonal(int.Parse(cborut.SelectedValue.ToString()));
            txtNombreP.Text = infoP.Nombre;
            txtApePaternoP.Text = infoP.ApellidoPat;
            txtApeMaternoP.Text = infoP.ApellidoMat;
            DateFechaNacP.Value = infoP.FechaNac;
            txtTelefonoP.Text = infoP.Telefono.ToString();
            txtEmailP.Text = infoP.Email;
            

            fami = auxfailiar.consultaridFamiliarporidInfo(int.Parse(cborut.SelectedValue.ToString()));
            Contra = auxContrat.consultaporIdContrato(fami.IdContrato);
            detc = auxdtC.consultaporIdDetContrato(Contra.IddetalleContrato);
            servi = auxServ.consultaporIdServicio(detc.IdServicio);

            txtiddetacontrato.Text = detc.IdDetContrato.ToString();
            txtidFamiliar.Text = fami.IdFamiliar.ToString();
            cboParentesco.SelectedItem = fami.Parentezco;
            cboCondicionesC.SelectedValue = Contra.IdContrato;
            //txtiddetacontrato.Text = Contra.IddetalleContrato.ToString();
            txtCostoTotal.Text = detc.CostoTotal.ToString();
            cboServicio.SelectedValue = servi.IdServicio;
            lblDesServtex.Text = servi.Descripcion;

            direc = auxDireccion.consultarPorId(infoP.IdDireccion);
            cargarRegion(direc.Region);
            cargarComunas(direc.Comuna);
            cargarParentezco(fami.Parentezco);
            txtCalle.Text = direc.Calle;
            txtCiudad.Text = direc.Cuidad;
            txtCodigoP.Text = direc.CodigoPostal.ToString();
            txtiddireccion.Text = direc.Id_direccion.ToString();

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ModificarResidente MR = new ModificarResidente();
            MR.Show();
            this.Hide();
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

        private void txtTelefonoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
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

    }
}
