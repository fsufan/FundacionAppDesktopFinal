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
    public partial class ModificarProveedor : Form
    {
        public ModificarProveedor()
        {
            InitializeComponent();
            cargarcbxRut();
            cargarcomboboxRegion();
            Focus();
        }
        public ModificarProveedor(string rol)
        {
            InitializeComponent();
            lblRol.Text = rol;
            lblRol.Visible = false;
            cargarcbxRut();
            cargarcomboboxRegion();
            Focus();

        }
        private void cargarcomboboxRegion()
        {
            Dictionary<string, string> region = new Dictionary<string, string>();
            region.Add("13", "METROPOLITANA");

            cbxRegion.DisplayMember = "Value";
            cbxRegion.ValueMember = "Key";
            cbxRegion.DataSource = region.ToArray();
            cbxRegion.Text = "METROPOLITANA";
            if (cbxRegion.SelectedIndex == -1)
            {
                cbxRegion.Text = "Seleccione Region";
            }

        }
        private void cargarcbxRut()
        { 
             NegocioProveedor proveedor = new NegocioProveedor();
             cbxRut.DataSource = proveedor.listarProveedor();
             cbxRut.DisplayMember = "rut_empresa";
             cbxRut.ValueMember = "id_proveedor";
             cbxRut.SelectedIndex = -1;
             if (cbxRut.SelectedIndex == -1)
             {
                 cbxRut.Text = "Seleccione Proveedor";
             }
             Focus();
        }
        
        private void btnVolverr_Click(object sender, EventArgs e)
        {
            MenuAdminProveedor menu = new MenuAdminProveedor();
            menu.Show();
            Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //proveedor
                NegocioProveedor proveedor = new NegocioProveedor();
                Proveedor auxProv = new Proveedor();
                //direccion
                NegocioDireccion direccion = new NegocioDireccion();
                Direccion auxDir = new Direccion();
                //Seguridad
                Seguridad seg = new Seguridad();
                if (txtCiudad.Text != "" & txtComuna.Text != "" & txtCPostal.Text != "" & txtDireccion.Text != "" & txtRazonS.Text != "")
                {
                    if (cbxRegion.SelectedIndex != -1&cbxRut.SelectedIndex!=-1)
                    {
                        if (!validaCampoVacio(txtDireccion) & !validaCampoVacio(txtCiudad) & !validaCampoVacio(txtRazonS) & !validaCampoVacio(txtComuna) & int.Parse(txtCPostal.Text) > 0)
                        {
                            
                            if (seg.validarRut(cbxRut.Text))
                            {
                                DialogResult dialogResult = MessageBox.Show("Desea Modificar Proveedor: " + txtRazonS.Text, "Información", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {


                                    DialogResult result = MessageBox.Show("Se modificara Proveedor ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                    switch (result)
                                    {

                                        case DialogResult.No:
                                            break;

                                        case DialogResult.Yes:
                                            auxProv = proveedor.consultarPorId(int.Parse(cbxRut.SelectedValue.ToString()));
                                            auxDir.Calle = txtDireccion.Text;
                                            auxDir.Cuidad = txtCiudad.Text;
                                            auxDir.Comuna = txtComuna.Text;
                                            auxDir.CodigoPostal = int.Parse(txtCPostal.Text);
                                            auxDir.Region = cbxRegion.SelectedValue.ToString();
                                            auxDir.Id_direccion =auxProv.Id_direccion;
                                            //insertar direccion
                                            if (direccion.actualizarDireccion(auxDir) > 0)
                                            {
                                                //Llenar datos a modificar
                                                auxProv.Razon_social = txtRazonS.Text;
                                                auxProv.Rut_empresa = cbxRut.Text;
                                                
                                                
                                                    if (proveedor.actualizarProveedor(auxProv)>0)
                                                    {
                                                        cbxRut.SelectedIndex = -1;
                                                        txtRazonS.Text = "";
                                                        txtDireccion.Text = "";
                                                        txtCPostal.Text = "";
                                                        txtComuna.Text = "";
                                                        txtCiudad.Text = "";
                                                        cbxRegion.SelectedIndex = -1;
                                                        dataGridView1.DataSource = proveedor.proveedorPorId(auxProv.Id_proveedor);
                                                        dataGridView1.ReadOnly = true;
                                                        dataGridView1.Columns[0].HeaderText = "ID DIRECCION";
                                                        dataGridView1.Columns[1].HeaderText = "ID PROVEEDOR";
                                                        dataGridView1.Columns[2].HeaderText = "RAZON SOCIAL";
                                                        dataGridView1.Columns[3].HeaderText = "RUT EMPRESA";

                                                        //dataGridView1.Columns[2].Visible = false;
                                                        dataGridView1.Update();
                                                        MessageBox.Show("Proveedor Modificado");
                                                    }
                                                    

                                                    
                                                

                                            }
                                            else
                                            {
                                                MessageBox.Show("Error al modificar Direccion");
                                            }

                                            break;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese un rut valido");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese datos válidos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione las litas");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese todos los campos");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR vuelva a intentarlo");
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

        private void cbxRut_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                NegocioProveedor prov = new NegocioProveedor();
                Proveedor auxProv = new Proveedor();

                NegocioDireccion direc = new NegocioDireccion();
                Direccion auxDir = new Direccion();

                auxProv = prov.consultarPorId(int.Parse(cbxRut.SelectedValue.ToString()));
                auxDir = direc.consultarPorId(auxProv.Id_direccion);

                txtRazonS.Text = auxProv.Razon_social;

                txtDireccion.Text = auxDir.Calle;

                txtCPostal.Text = auxDir.CodigoPostal.ToString();
                txtComuna.Text = auxDir.Comuna;
                txtCiudad.Text = auxDir.Cuidad;
                cargarcomboboxRegion();
                dataGridView1.DataSource = prov.proveedorPorId(auxProv.Id_proveedor);
                dataGridView1.ReadOnly = true;
                dataGridView1.Columns[0].HeaderText = "ID DIRECCION";
                dataGridView1.Columns[1].HeaderText = "ID PROVEEDOR";
                dataGridView1.Columns[2].HeaderText = "RAZON SOCIAL";
                dataGridView1.Columns[3].HeaderText = "RUT EMPRESA";

                //dataGridView1.Columns[2].Visible = false;
                dataGridView1.Update();
            }
            catch (Exception)
            {

                MessageBox.Show("Error, intentelo de nuevo");
            }
            
        }

        private void cbxRut_TextChanged(object sender, EventArgs e)
        {
            cbxRut.MaxLength = 10;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            txtDireccion.MaxLength = 100;
        }

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {
            txtCiudad.MaxLength = 100;
        }

        private void txtCPostal_TextChanged(object sender, EventArgs e)
        {
            txtCPostal.MaxLength = 38;
        }

        private void txtRazonS_TextChanged(object sender, EventArgs e)
        {
            txtRazonS.MaxLength = 25;
        }

        private void txtComuna_TextChanged(object sender, EventArgs e)
        {
            txtComuna.MaxLength = 100;
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
            if ((!Regex.IsMatch(this.txtRazonS.Text, @"^[A-Z0-9 a-z]*$")) && (txtRazonS.Text != ""))
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

        private void _Validating(object sender, CancelEventArgs e)
        {
            
        }
        

        private void cbxRut_Validating(object sender, CancelEventArgs e)
        {

            if ((!Regex.IsMatch(this.cbxRut.Text, @"\b\d{7,8}\[K|k|0-9]")) && (cbxRut.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres válidos");
                this.cbxRut.Focus();
                cbxRut.Text = "";
            }
        }

    }
}
