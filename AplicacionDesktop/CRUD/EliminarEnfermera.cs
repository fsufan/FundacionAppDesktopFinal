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
using Capa_DTO.Usuario;
using CapaNegocio.NegocioResidente;
using CapaNegocio.NegocioUsuario;
using AplicacionDesktop.MENU;
using System.Text.RegularExpressions;
using Capa_DTO.Seguridad;

namespace AplicacionDesktop.CRUD
{
    public partial class EliminarEnfermera : Form
    {
        public EliminarEnfermera()
        {
            InitializeComponent();
            lblidEnfermera.Visible = false;
        }

        private void EliminarEnfermera_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                InformacionPersonal infop = new InformacionPersonal();
                NegocioInfoPersonal AuxInfo = new NegocioInfoPersonal();
                Enfermera enfermera = new Enfermera();
                NegocioEnfermera auxEnfermera = new NegocioEnfermera();
                Seguridad seguridad = new Seguridad();
               
                if (txtRut.Text != "")
                {


                    if (seguridad.validarRut(txtRut.Text))
                    {

                        if (AuxInfo.consultarRut(txtRut.Text) == true)
                        {
                            infop = AuxInfo.BuscaridPorRut(txtRut.Text.ToUpper().Trim());
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
                txtRut.Text = string.Empty;
                lblApellidoEnfermera.Text = string.Empty;
                lblNombreEnfermera.Text = string.Empty;
                lblidEnfermera.Text = string.Empty;
                MessageBox.Show("Rut no es compatible con una Enfermera");
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

        private void txtRutP_TextChanged(object sender, EventArgs e)
        {
            if (txtRut.TextLength > 9)
            {
                txtRut.MaxLength = 9;
                MessageBox.Show("Debe ingresar sólo 9 números");
                txtRut.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuAdminEnfermera MAE = new MenuAdminEnfermera();
            MAE.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                Enfermera enfermera = new Enfermera();
                NegocioEnfermera auxEnfermera = new NegocioEnfermera();
                NegocioInfoPersonal auxinfo = new NegocioInfoPersonal();

                if (txtRut.Text != null)
                {

                    DialogResult resultado = MessageBox.Show("Esta intentando eliminar. Si continua el proceso, se eliminaran TODOS los datos asociados a este Rut. Desea Continuar?", "Atencion", MessageBoxButtons.YesNo);

                    switch (resultado)
                    {
                        case DialogResult.Yes:


                            if (auxEnfermera.EliminarEnfermera(int.Parse(lblidEnfermera.Text)) > 0)
                            {
                                txtRut.Text = string.Empty;
                                lblNombreEnfermera.Text = string.Empty;
                                lblApellidoEnfermera.Text = string.Empty;
                                lblidEnfermera.Text = string.Empty;
                                MessageBox.Show("Eliminado", "Informacion");

                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar");
                            }


                            break;
                        case DialogResult.No:
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("Debe Ingresar un Rut para Eliminar");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtRut_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtRut.Text, @"\b\d{7,8}\-[K|k|0-9]")) && (txtRut.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres válidos");
                this.txtRut.Focus();
                txtRut.Text = "";
            }
        }
    }
}
