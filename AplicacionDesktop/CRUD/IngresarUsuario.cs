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
                    

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error intentelo nuevamente");
            }
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
                    
                    
                    if ((seg.validarRut(txtrut.Text)))
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
                                                if (cmbxidrol.Text.Equals("APORTADOR") || cmbxidrol.Text.Equals("RECICLAR"))
                                                {
                                                    if (rol.consultaRolMO(cmbxidrol.Text.ToUpper().ToString()) > 0)
                                                    {
                                                        int ide = rol.consultaRolMO(cmbxidrol.Text.ToUpper().ToString());
                                                        auxUsuario.IdRol = ide;
                                                        if (usuario.usuarioMORut(txtrut.Text).IdRol == 0)
                                                        {
                                                            if (usuario.ingresarUsuarioMO(auxUsuario) > 0)
                                                            {
                                                                MessageBox.Show("Usuario ingresado al sistema WEB");
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Error al crear Usuario web");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("El usuario ya existe en Moda Outlet");
                                                        }

                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Error al buscar el Rol");
                                                    }
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

            if (txtContraseña.TextLength > 8)
            {
                txtContraseña.MaxLength = 8;
                MessageBox.Show("Debe ingresar  8 digitos");
                txtContraseña.Text = "";
            }

        }

        private void txtrut_TextChanged(object sender, EventArgs e)
        {
            
            
            if (txtrut.TextLength > 10)
            {
                txtrut.MaxLength = 10;
                MessageBox.Show("Debe ingresar  solo 10 digitos");
                txtrut.Text = "";
            }
            
        }

        private void txtrut_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtrut.Text, @"\b\d{7,8}\-[K|k|0-9]")) && (txtrut.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres válidos");
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
