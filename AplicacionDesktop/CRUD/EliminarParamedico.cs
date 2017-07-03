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

namespace AplicacionDesktop.CRUD
{
    public partial class EliminarParamedico : Form
    {
        public EliminarParamedico()
        {
            InitializeComponent();
            lblidParamedico.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                InformacionPersonal infop = new InformacionPersonal();
                NegocioInfoPersonal AuxInfo = new NegocioInfoPersonal();
                Paramedico paramedico = new Paramedico();
                NegocioParamedico auxparamedico = new NegocioParamedico();

                if (txtRut.Text != "")
                {


                    if (validarRut(txtRut.Text))
                    {

                        if (AuxInfo.consultarRut(txtRut.Text) == true)
                        {
                            infop = AuxInfo.BuscaridPorRut(txtRut.Text.ToUpper().Trim());
                            paramedico = auxparamedico.consultarParamedicoporIDinfoP(infop.Id_InfoPersonal);


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
                txtRut.Text = string.Empty;
                lblApellidoParamedico.Text = string.Empty;
                lblidParamedico.Text = string.Empty;
                lblNombreParamedico.Text = string.Empty;
                MessageBox.Show("Rut no es compatible con un Paramedico");
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Paramedico paramedico = new Paramedico();
                NegocioParamedico auxParamedico = new NegocioParamedico();
                NegocioInfoPersonal auxinfo = new NegocioInfoPersonal();

                if (txtRut.Text != null)
                {

                    DialogResult resultado = MessageBox.Show("Esta intentando eliminar. Si continua el proceso, se eliminaran TODOS los datos asociados a este Rut. Desea Continuar?", "Atencion", MessageBoxButtons.YesNo);

                    switch (resultado)
                    {
                        case DialogResult.Yes:


                            if (auxParamedico.EliminarParamedico(int.Parse(lblidParamedico.Text)) > 0)
                            {
                                txtRut.Text = string.Empty;
                                lblApellidoParamedico.Text = string.Empty;
                                lblNombreParamedico.Text = string.Empty;
                                lblidParamedico.Text = string.Empty;
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
            catch (Exception)
            {
                MessageBox.Show("Debe Ingresar un Rut para Eliminar");
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

        private void txtRut_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtRut.Text, @"^\d+$")) && (txtRut.Text != ""))
            {
                MessageBox.Show("Si su Rut termina en K reemplace a un cero");
                this.txtRut.Focus();
                txtRut.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuAdminParamedico MAP = new MenuAdminParamedico();
            MAP.Show();
            this.Hide();
        }
    }
}
