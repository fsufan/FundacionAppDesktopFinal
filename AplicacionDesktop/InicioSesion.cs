using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Security.Cryptography;
using CapaNegocio.NegocioUsuario;
using Capa_DTO.Usuario;
using AplicacionDesktop.MENU;
using System.Text.RegularExpressions;
using Capa_DTO.Seguridad;



namespace AplicacionDesktop
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
      

        }
       
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsu.Text))
            {
                MessageBox.Show("No dejar usuario vacío", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (string.IsNullOrEmpty(txtPass.Text))
                    {
                        MessageBox.Show("No dejar contraseña vacía", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        NegocioUsuario usuario = new NegocioUsuario();
                        Usuario auxUsuario = new Usuario();

                        NegocioRol rol = new NegocioRol();
                        Rol auxrol = new Rol();

                        Seguridad seg = new Seguridad();

                        //auxUsuario =  (usu.buscarUsuarioporRut=  int.Parse((txtUsu.Text));
                        auxUsuario = usuario.buscarUsuarioporRut(txtUsu.Text);

                        if (auxUsuario.Contrasena != null)
                        {
                            string pass;
                            pass = seg.SHA256Encrypt(txtPass.Text);
                            //if (auxUsuario.Contrasena.Equals(txtPass.Text))
                            if (auxUsuario.Contrasena.Equals(pass))
                            {
                                auxrol = rol.consultaRolporId(auxUsuario.IdRol);
                                if (auxrol.NombreRol.Equals("ADMINISTRADOR"))
                                {
                                    MenuAdmin menuA = new MenuAdmin();
                                    menuA.Show();
                                    Hide();
                                    //this.Close();
                                    txtUsu.Text = "";
                                    txtPass.Text = "";


                                }
                                else if (auxrol.NombreRol.Equals("SUPERVISOR"))
                                {
                                    MenuSupervisor menu = new MenuSupervisor(auxrol.NombreRol);
                                    menu.Show();
                                    Hide();
                                    txtUsu.Text = "";
                                    txtPass.Text = "";
                                }
                                else if (auxrol.NombreRol.Equals("ENFERMERA") | auxrol.NombreRol.Equals("PARAMEDICO"))
                                {
                                    //menuEnfermera
                                    MenuEnfermera menu = new MenuEnfermera(auxrol.NombreRol);
                                    menu.Show();
                                    Hide();
                                    txtUsu.Text = "";
                                    txtPass.Text = "";
                                }

                                //Menu encargado farmacia
                                else if (auxrol.NombreRol.Equals("ENCARGADO FARMACIA"))
                                {
                                    string rut = txtUsu.Text;
                                    MenuAdministrarInventario menu = new MenuAdministrarInventario(auxrol.NombreRol);
                                    menu.Show();
                                    Hide();
                                    txtUsu.Text = "";
                                    txtPass.Text = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show("contraseña incorrecta");
                                txtUsu.Text = "";
                                txtPass.Text = "";
                            }
                        }
                        else
                        {
                            txtUsu.Text = "";
                            txtPass.Text = "";
                            MessageBox.Show("el usuario no existe");
                        }
                    }
                }
                catch (Exception)
                {
                    txtUsu.Text = "";
                    txtPass.Text = "";
                    MessageBox.Show("Error, intente de nuevo");
                }
                
                
            }
       }
         

        private void limpiar()
        {
            txtUsu.Clear();
            txtPass.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo);

            switch (result)
            {
                case DialogResult.Yes:
                    this.Close();
                    Application.Exit();

                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void txtUsu_TextChanged(object sender, EventArgs e)
        {
            txtUsu.MaxLength = 10;
        }

        private void txtUsu_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtUsu.Text, @"\b\d{7,8}\-[K|k|0-9]")) && (txtUsu.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres válidos");
                this.txtUsu.Focus();
                txtUsu.Text = "";
            }
        }


        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.MaxLength = 8;
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtPass.Text, @"^[A-Z0-9 a-z]*$")) && (txtPass.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres válidos");
                this.txtPass.Focus();
                txtPass.Text = "";
            }
           }
    }
 }