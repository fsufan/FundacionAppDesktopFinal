using AplicacionDesktop.MENU;
using Capa_DTO.Farmacia;
using Capa_DTO.Seguridad;
using CapaNegocio.NegocioFarmacia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDesktop.CRUD
{
    public partial class IngresarProveedor : Form
    {
        public IngresarProveedor()
        {
            InitializeComponent();
            cargarcombobox();

            
        }
        public IngresarProveedor(string rol)
        {
            InitializeComponent();
            cargarcombobox();
            lblRol.Text = rol;
            lblRol.Visible = false;
        }
        private void cargarcombobox()
        {
            Dictionary<string, string> region = new Dictionary<string, string>();
            region.Add("13", "METROPOLITANA");
            
            cbxRegion.DisplayMember = "Value";
            cbxRegion.ValueMember = "Key";
            cbxRegion.DataSource = region.ToArray();
            cbxRegion.SelectedIndex = -1;
            if (cbxRegion.SelectedIndex == -1)
            {
                cbxRegion.Text = "Seleccione Region";
            }
        
        }
        private void cargarGrilla()
        {
            NegocioProveedor proveedor = new NegocioProveedor();
            if (proveedor.listarProveedor() != null)
            {
                

                dataGridView1.DataSource = proveedor.listarProveedor();
                dataGridView1.ReadOnly = true;
                dataGridView1.Columns[0].HeaderText = "ID DIRECCION";
                dataGridView1.Columns[1].HeaderText = "ID PROVEEDOR";
                dataGridView1.Columns[2].HeaderText = "RAZON SOCIAL";
                dataGridView1.Columns[3].HeaderText = "RUT EMPRESA";

                //dataGridView1.Columns[2].Visible = false;
                dataGridView1.Update();

            }
            else
            {
                MessageBox.Show("No hay datos ingresados");
            }
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //proveedor
                NegocioProveedor proveedor = new NegocioProveedor();
                Proveedor auxProv = new Proveedor();
                //direccion
                NegocioDireccion direccion = new NegocioDireccion();
                Direccion auxDir = new Direccion();
                //seguridad
                Seguridad seg = new Seguridad();
                if (txtCiudad.Text!=""&txtComuna.Text!=""&txtCPostal.Text!=""&txtDireccion.Text!=""&txtRazonS.Text!="" &txtRut.Text!="")
                {
                    if (cbxRegion.SelectedIndex!=-1)
                    {
                        if (!validaCampoVacio(txtDireccion) & !validaCampoVacio(txtCiudad) & !validaCampoVacio(txtRazonS) & !validaCampoVacio(txtComuna)&int.Parse(txtCPostal.Text)>0)
                        {
                            //crear metodo consultar por razon social
                            if (seg.validarRut(txtRut.Text))
                            {
                                DialogResult dialogResult = MessageBox.Show("Desea agregar Proveedor: " +txtRazonS.Text , "Información", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    
                                    DialogResult result = MessageBox.Show("Se ingresara Proveedor ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                    switch (result)
	                                {
		
                                        case DialogResult.No:
                                         break;

                                        case DialogResult.Yes:

                                         auxDir.Calle = txtDireccion.Text;
                                             auxDir.Cuidad = txtCiudad.Text;
                                             auxDir.Comuna = txtComuna.Text;
                                             auxDir.CodigoPostal = int.Parse(txtCPostal.Text);
                                             auxDir.Region = cbxRegion.SelectedValue.ToString();
                                             if (proveedor.consultarProveedor(txtRut.Text) == 0)
                                             {
                                                 //insertar direccion
                                                 if (direccion.ingresarDireccion(auxDir) > 0)
                                                 {
                                                     //consultar id direccion
                                                     auxProv.Id_direccion = direccion.consultarDireccion(auxDir.Calle);

                                                     auxProv.Razon_social = txtRazonS.Text;
                                                     auxProv.Rut_empresa = txtRut.Text;



                                                     if (proveedor.ingresarProveedor(auxProv, auxProv.Id_direccion) > 0)
                                                     {
                                                         txtRut.Text = "";
                                                         txtRazonS.Text = "";
                                                         txtDireccion.Text = "";
                                                         txtCPostal.Text = "";
                                                         txtComuna.Text = "";
                                                         txtCiudad.Text = "";
                                                         cargarcombobox();
                                                         cargarGrilla();
                                                     }
                                                     else
                                                     {
                                                         MessageBox.Show("Error al ingresar Proveedor");
                                                     }
                                                 }
                                                 else
                                                 {
                                                     MessageBox.Show("Error al ingresar Direccion");
                                                 }
                                             }
                                             else
                                             {
                                                 MessageBox.Show("El proveedor ya existe");
                                             }
                                           
                                         break;
	                                }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese un rut válido");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese datos válidos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione la Region");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese todos los campos");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR, intentelo nuevamente");
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
        private void btnVolverr_Click(object sender, EventArgs e)
        {
            MenuAdminProveedor men = new MenuAdminProveedor(lblRol.Text);
            men.Show();
            Hide();
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Si su rut termina en K reemplzace por un cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
            txtRut.MaxLength = 10;
        }

        private void txtRazonS_TextChanged(object sender, EventArgs e)
        {
            txtRazonS.MaxLength = 25;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            txtDireccion.MaxLength = 100;
        }

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {
            txtCiudad.MaxLength = 100;
        }

        private void txtComuna_TextChanged(object sender, EventArgs e)
        {
            txtComuna.MaxLength = 100;
        }

        private void txtCPostal_TextChanged(object sender, EventArgs e)
        {
            txtCPostal.MaxLength = 38;
        }

        private void cbxRegion_TextChanged(object sender, EventArgs e)
        {
            cbxRegion.MaxLength = 100;
        }

       
        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtCiudad.Text, @"^[A-Z0-9 a-z]*$")) && (txtCiudad.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtCiudad.Focus();
                txtCiudad.Text = "";
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

        private void txtRazonS_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtRazonS.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (txtRazonS.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtRazonS.Focus();
                txtRazonS.Text = "";
            }
        }

        private void txtComuna_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtComuna.Text, @"^[a-zA-Z_áéíóúñ\s]*$")) && (txtComuna.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtComuna.Focus();
                txtComuna.Text = "";
            }
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

        private void txtCPostal_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtCPostal.Text, @"^\d+$")) && (txtCPostal.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo números");
                this.txtRut.Focus();
                txtRut.Text = "";
            }
        }

      
    }
}
