using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionDesktop.CRUD;
using Capa_DTO.Usuario;
using CapaNegocio.NegocioUsuario;
using AplicacionDesktop.MENU;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using Capa_DTO.Seguridad;

namespace AplicacionDesktop.CRUDUsuario
{
    public partial class IngresarUsuario : Form
    {
        public IngresarUsuario()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '*';
            txtrpass.PasswordChar = '*';
            cargarCombox();

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

        public void cargarCombox()
        {
            NegocioRol rol = new NegocioRol();
            try
            {
                if (rol.listarRoles() != null)
                {
                    cmbxidrol.DataSource = rol.listarRoles();
                    cmbxidrol.DisplayMember = "nombre_rol";
                    cmbxidrol.ValueMember = "id_rol";

                    cmbxidrol.SelectedIndex = -1;
                    if (cmbxidrol.SelectedIndex == -1)
                    {
                        cmbxidrol.Text = "--------Seleccione--------";
                    }


                }
                else
                {
                    MessageBox.Show("No hay roles registrados");
                    IngresarRol IR = new IngresarRol();
                    IR.Show();
                    this.Close();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error intentelo nuevamente");
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
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                String seleccion = "";
                Usuario auxUsuario = new Usuario();
                NegocioUsuario usuario = new NegocioUsuario();
                NegocioRol rol = new NegocioRol();
                Seguridad seg = new Seguridad();  
                
                if (txtrut.Text != ""& txtContraseña.Text != "" & cmbxidrol.SelectedIndex != -1&txtrpass.Text!="")
                {
                    
                    
                    if ((validarRut(txtrut.Text)))
                    {
                                                
                            seleccion = cmbxidrol.SelectedValue.ToString();
                            

                            if (!validaCampoVacio(txtContraseña)&!validaCampoVacio(txtrpass))
                            {
                                
                                    
                                
                                if (txtContraseña.Text.Equals(txtrpass.Text))
                                {
                                    
                                
                                if (usuario.buscarUsuarioporRut(txtrut.Text).IdRol==0)
                                {
                                    DialogResult dialogResult = MessageBox.Show("¿Desea agregar al usuario?  " + txtrut.Text, "Información", MessageBoxButtons.YesNo);
                                    
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        DialogResult result = MessageBox.Show("Se ingresará al usuario ¿Desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                        txtContraseña.Text = txtContraseña.Text;
                                        auxUsuario.RutUsuario = txtrut.Text;
                                        //seg.SHA256Encrypt(txtContraseña.Text);
                                        auxUsuario.Contrasena = seg.SHA256Encrypt(txtContraseña.Text);
                                        auxUsuario.IdRol = int.Parse(cmbxidrol.SelectedValue.ToString());


                                        switch (result)
                                        {
                                            case DialogResult.Yes:
                                                
                                                if (usuario.ingresarUsuario(auxUsuario) > 0)
                                                {
                                                    if (cmbxidrol.Text.Equals("APORTADOR") || cmbxidrol.Text.Equals("RECICLAR"))
                                                    {
                                                        if (rol.consultaRolMO(cmbxidrol.Text.ToUpper().ToString())>0)
                                                        {
                                                            int ide = rol.consultaRolMO(cmbxidrol.Text.ToUpper().ToString());
                                                            auxUsuario.IdRol = ide;
                                                            if (usuario.ingresarUsuarioMO(auxUsuario) > 0)
                                                            {
                                                                MessageBox.Show("Usuario web ingresado");
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Error al crear Usuario web");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Error al buscar e Rol");
                                                        }
                                                    }
                                                    MessageBox.Show("Usuario ingresado", "Información");
                                                    dtingresou.DataSource = usuario.listarUsuarios();
                                                    dtingresou.Update();
                                                    dtingresou.ReadOnly = true;
                                                    txtrut.Text = "";
                                                    txtrpass.Text = "";
                                                    txtContraseña.Text = "";
                                                    cmbxidrol.SelectedIndex = -1;

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Error al ingresar usuario");
                                                }
                                                break;
                                            case DialogResult.No:
                                                break;
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El usuario ya esta registrado");
                                }



                                }
                                else
                                {
                                    //El rut debe ser distinto a la contraseña
                                    MessageBox.Show("Las contraseñas ingresadas no coinciden");
                                }
                            }
                            else
                            {
                                
                                MessageBox.Show("Ingrese datos válidos");
                            }
                            
                           
                        }
                    else
                    {

                        MessageBox.Show("Ingrese un rut válido");
                    }
                }
                else
                {
                    MessageBox.Show("No deja el campos vacíos");
                }

                    
                
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR, intentelo nuevamente");
            }
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuUsuario mu = new MenuUsuario();
            mu.Show();
            Hide();
        }


        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

            if (txtContraseña.TextLength > 8 & txtContraseña.TextLength < 8)
            {
                txtContraseña.MaxLength = 8;
                MessageBox.Show("Debe ingresar  8 digitos");
                txtContraseña.Text = "";
            }

        }

        private void txtrut_TextChanged(object sender, EventArgs e)
        {
            
            
            if (txtrut.TextLength > 12)
            {
                txtrut.MaxLength = 12;
                MessageBox.Show("Debe ingresar  solo 9 números");
                txtrut.Text = "";
            }
            
        }

        private void txtrut_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtrut.Text, @"^\d+$")) && (txtrut.Text != ""))
            {
                MessageBox.Show("Si su Rut termina en K reemplace a un cero");
                this.txtrut.Focus();
                txtrut.Text = "";
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
