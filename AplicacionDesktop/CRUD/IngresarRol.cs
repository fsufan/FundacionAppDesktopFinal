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



namespace AplicacionDesktop.CRUD
{
    public partial class IngresarRol : Form
    {
        
        
        public IngresarRol()
        {
            InitializeComponent();
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
        private void btnIngresoR_Click(object sender, EventArgs e)
        {
            try
            {


                Rol auxRol = new Rol();
                NegocioRol rol = new NegocioRol();

                if (txtRol.Text != "" & txtDescRol.Text != "")
                {
                    if (!validaCampoVacio(txtRol)&!validaCampoVacio(txtDescRol))
                    {
                        auxRol.NombreRol = txtRol.Text.ToUpper().Trim();
                        

                        if (!validaCampoVacio(txtDescRol))
                        {
                            auxRol.DescripcionRol= txtDescRol.Text.ToUpper().Trim();

                            if (rol.consultaRol(auxRol.NombreRol)== 0)
                            {
                                DialogResult dialogResult = MessageBox.Show("¿Desea agregar el rol? " + txtRol.Text, "Información", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    DialogResult result = MessageBox.Show("Se ingresará el rol ¿Desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                    auxRol.DescripcionRol = txtDescRol.Text.ToUpper().Trim();
                                    switch (result)
                                    {
                                        case DialogResult.Yes:
                                            if(rol.ingresarRol(auxRol) != 0)  
                                            {
                                                if (auxRol.NombreRol.Equals("RECICLAR") || auxRol.NombreRol.Equals("APORTADOR"))
                                                {
                                                    if (rol.ingresarRolMO(auxRol) != 0)
                                                    {
                                                        MessageBox.Show("Rol Web ingresado", "Información");
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Error al crea Usuario web");
                                                    }
                                                }
                                               
                                                MessageBox.Show("Rol ingresado", "Información");
                                                dttingrol.DataSource = rol.listarRoles();
                                                dttingrol.Update();
                                                dttingrol.ReadOnly = true;

                                                txtRol.Text = "";
                                                txtDescRol.Text = "";
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error al ingresar Rol, intente de nuevo");
                                            }
                                            break;
                                        case DialogResult.No:
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Este rol ya está registrado");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No dejar el campo vacío");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese todos los campos");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese todos los campos");
                }

            }
                
            catch (Exception )
            {
                MessageBox.Show("ERROR, vuelva a intentarlo ");
            }

      
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            MenuRol madim = new MenuRol();
            madim.Show();
            Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
          
        }

       

        private void dttingrol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {
             txtRol.MaxLength = 20;
        }

        private void txtDescRol_TextChanged(object sender, EventArgs e)
        {
             txtDescRol.MaxLength = 50;
        }

        private void txtRol_Validating(object sender, CancelEventArgs e)
        {
          if ((!Regex.IsMatch(this.txtRol.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (txtRol.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo letras");
                this.txtRol.Focus();
                txtRol.Text = "";
            }
        }

        private void txtDescRol_Validating_1(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtDescRol.Text, @"^[A-Z0-9 a-z]*$")) && (txtDescRol.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres válidos");
                this.txtDescRol.Focus();
                txtDescRol.Text = "";
            }
        }

        
    }
}
         