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
using CapaNegocio.NegocioUsuario;
using Capa_DTO.Usuario;
using AplicacionDesktop.MENU;
using Capa_DTO.Seguridad;
using System.Text.RegularExpressions;

namespace AplicacionDesktop.CRUDUsuario
{
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '*';
            txtrpass.PasswordChar = '*';
            NegocioUsuario usuario = new NegocioUsuario();
            if (usuario.listarUsuarios()!=null)
            {
                cmboxRut.DataSource = usuario.listarUsuarios();
                cmboxRut.DisplayMember = "rut_usuario";
                cmboxRut.ValueMember = "id_usuario";
                cmboxRut.SelectedIndex = -1;
                if (cmboxRut.SelectedIndex == -1)
                {
                    cmboxRut.Text = "--Seleccione--";
                }
            }
            else
            {
                MessageBox.Show("ERROR no hay datos");
                
            }
            
        }
        private void cargarRol()
        {
            NegocioRol rol = new NegocioRol();
            if (rol.listarRoles()!=null)
            {
                cbxRol.DataSource = rol.listarRoles();
                cbxRol.DisplayMember = "nombre_rol";
                cbxRol.ValueMember = "id_rol";
                //cbxRol.SelectedIndex = -1;
                if (cbxRol.SelectedIndex == -1)
                {
                    cmboxRut.Text = "Seleccione Rol";
                }
        
            }else
	            {
                    MessageBox.Show("ERROR no hay datos");
	            }
           
        }




       


        private Boolean validaCampoVacio(TextBox campo)
        {
            if (String.IsNullOrEmpty(campo.Text.Trim()))
            {
                return true;
            }
            else
            {
                //focusComponente(campo);
                return false;
            }
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario auxUsuario = new Usuario();
                NegocioUsuario usuario = new NegocioUsuario();
                Seguridad seg = new Seguridad();
                NegocioRol rol = new NegocioRol();
                DialogResult dialogResult = MessageBox.Show("¿Desea modificar al usuario? " + cmboxRut.Text.ToString(), "Información", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult result = MessageBox.Show("Se modificará al usuario ¿Desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            if (cbxRol.SelectedIndex!=-1&cmboxRut.SelectedIndex!=-1&txtContraseña.Text != ""&txtrpass.Text!="")
                            {
                                
                                if (seg.validarRut(cmboxRut.Text))
                                {
                                    if (txtContraseña.Text.Equals(txtrpass.Text))
                                    {
                                        
                                    
                                    auxUsuario.RutUsuario = cmboxRut.Text;
                                    auxUsuario.Contrasena = seg.SHA256Encrypt(txtContraseña.Text);
                                    auxUsuario.IdUsuario = int.Parse(cmboxRut.SelectedValue.ToString());
                                    auxUsuario.IdRol = int.Parse(cbxRol.SelectedValue.ToString());
                                    

                                    if (usuario.actualizarUsuario(auxUsuario) > 0)
                                    {
                                        if (cbxRol.Text.Equals("APORTADOR") || cbxRol.Text.Equals("RECICLAR"))
                                        {
                                            if (rol.consultaRolMO(cbxRol.Text.ToUpper().ToString()) > 0)
                                            {
                                                auxUsuario = usuario.usuarioMORut(cmboxRut.Text);
                                                int ide = rol.consultaRolMO(cbxRol.Text.ToUpper().ToString());
                                                auxUsuario.IdRol = ide;
                                                
                                                
                                                    if (usuario.modificarUsuarioMO(auxUsuario) > 0)
                                                    {
                                                        MessageBox.Show("Usuario web modificado");
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Error al modificar Usuario web");
                                                    }
                                                
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error al buscar el Rol");
                                            }
                                        }
                                        MessageBox.Show("Usuario Modificado");
                                        cmboxRut.DataSource = usuario.listarUsuarios();
                                        txtContraseña.Text = "";
                                        txtrpass.Text = "";
                                        dtMoDU.DataSource = usuario.usuarioPorId(auxUsuario.IdUsuario);
                                        cmboxRut.SelectedIndex = -1;
                                        dtMoDU.ReadOnly = true;
                                        dtMoDU.Update();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al modificar");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Las contraseñas no coinciden");
                                    
                                }
                            }
                            else
                                {
                                    MessageBox.Show("El rut debe ser valido");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese todos los campos");
                            }
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR, vuelva a intentarlo");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuUsuario mu = new MenuUsuario();
            mu.Show();
            Hide();
        }


        private void cmboxRut_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                NegocioUsuario usuario = new NegocioUsuario();
                Usuario auxusu = new Usuario();

                NegocioRol rol = new NegocioRol();
                Rol auxrol = new Rol();



                auxusu.IdUsuario = int.Parse(cmboxRut.SelectedValue.ToString());
                auxusu = usuario.consultaUsuariporId(auxusu.IdUsuario);

                //txtContraseña.Text = auxusu.Contrasena;

                cmboxRut.Text = auxusu.RutUsuario;
                auxrol = rol.consultaRolporId(auxusu.IdRol);
                cargarRol();
                cbxRol.Text = auxrol.NombreRol;
            }
            catch (Exception)
            {
                
                MessageBox.Show("ERROR, vuelva a intentarlo");
            }
            

            
        }

        private void cmboxRut_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.cmboxRut.Text, @"\b\d{7,8}\[K|k|0-9]")) && (cmboxRut.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres válidos");
                this.cmboxRut.Focus();
                cmboxRut.Text = "";
            }
        }

        private void cbxRol_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.cbxRol.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (cbxRol.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo letras");
                this.cbxRol.Focus();
                cbxRol.Text = "";
            }
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtContraseña.Text, @"^[A-Z0-9 a-z]*$")) && (txtContraseña.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo letras");
                this.txtContraseña.Focus();
                txtContraseña.Text = "";
            }
        }

        private void txtrpass_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtrpass.Text, @"^[A-Z0-9 a-z]*$")) && (txtrpass.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo letras");
                this.txtrpass.Focus();
                txtrpass.Text = "";
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.TextLength > 8 & txtContraseña.TextLength < 8)
            {
                txtContraseña.MaxLength = 8;
                MessageBox.Show("Debe ingresar  8 digitos");
            }
        }


    }
}
