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
using AplicacionDesktop.MENU;
using System.Text.RegularExpressions;
using CapaNegocio.webServiceFundacion;
using System.Web.Services;
using CapaNegocio.NegocioUsuario;
namespace AplicacionDesktop.CRUD
{
    public partial class ModificarRol : Form
    {
        
        public ModificarRol()
        {
            InitializeComponent();
            cmbnrol.Focus();
            NegocioRol rol = new NegocioRol();
            if (rol.listarRoles()!=null)
            {
                cmbnrol.DataSource = rol.listarRoles();
                cmbnrol.DisplayMember = "nombre_rol";
                cmbnrol.ValueMember = "id_rol";
                cmbnrol.SelectedIndex = -1;
                if (cmbnrol.SelectedIndex==-1)
                {
                    cmbnrol.Text = "Seleccione un Rol";
                }

            }
            else
            {
                MessageBox.Show("ERROR no hay datos ingresados");
                this.Close();
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

        private void btnModRol_Click(object sender, EventArgs e)
        {
            try
            {
                Rol auxRol = new Rol();
                NegocioRol rol = new NegocioRol();

                DialogResult dialogResult = MessageBox.Show("¿Desea modificar el rol? " + cmbnrol.Text.ToString(), "Información", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult result = MessageBox.Show("Se modifcará el rol ¿Desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            if (cmbnrol.SelectedIndex!=-1&txtdesc.Text != ""&!validaCampoVacio(txtdesc))
                            {
                                auxRol.IdRol = int.Parse(cmbnrol.SelectedValue.ToString());
                                auxRol.NombreRol = cmbnrol.Text;
                                auxRol.DescripcionRol = txtdesc.Text;
                                
                                    if (rol.actualizarRol(auxRol)>0)
                                    {
                                        MessageBox.Show("Rol modificado");
                                        cmbnrol.SelectedIndex = -1;
                                        txtdesc.Text = "";

                                        cmbnrol.DataSource = rol.listarRoles();
                                        dtmodrol.DataSource = rol.rolPorId(auxRol.IdRol);
                                        dtmodrol.ReadOnly = true;
                                        dtmodrol.Update();
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al modificar, vuelva a intentarlo");
                                    }
                                    if (auxRol.NombreRol.Equals("APORTADOR")||auxRol.NombreRol.Equals("RECICLAR"))
                                    {
                                        auxRol = rol.rolPorNombreMO(cmbnrol.Text);
                                        if (rol.modificarRolMO(auxRol) > 0)
                                        {
                                            MessageBox.Show("Usuario modificado en el sistema WEB");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al modificar en el sistema WEB");
                                        }
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
            MenuRol mr = new MenuRol();
            mr.Show();
            Hide();
        }


        private void cmbnrol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                NegocioRol rol = new NegocioRol();
            Rol auxRol = new Rol();

            auxRol = rol.consultaRolporId(int.Parse(cmbnrol.SelectedValue.ToString()));
            txtdesc.Text = auxRol.DescripcionRol;
            dtmodrol.DataSource = rol.rolPorId(auxRol.IdRol);
            }
            catch (Exception)
            {
                
              MessageBox.Show("Error, intentelo de nuevo");
            }
            
            
            
           
        }

        private void txtdesc_TextChanged(object sender, EventArgs e)
        {
            txtdesc.MaxLength = 50;
        }

        private void txtdesc_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtdesc.Text, @"^[A-Z0-9 a-z]*$")) && (txtdesc.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo letras");
                this.txtdesc.Focus();
                txtdesc.Text = "";
            }
        }

        private void cmbnrol_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.cmbnrol.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (cmbnrol.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo letras");
                this.cmbnrol.Focus();
                cmbnrol.Text = "";
            }
        }
    }
}
