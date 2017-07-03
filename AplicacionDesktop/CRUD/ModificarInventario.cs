using AplicacionDesktop.MENU;
using Capa_DTO.Farmacia;
using Capa_DTO.Medicamento;
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
    public partial class ModificarInventario : Form
    {
        public ModificarInventario()
        {
            InitializeComponent();
           
        }
        public ModificarInventario(string rol)
        {
            InitializeComponent();
            lblRol.Text = rol;
            lblRol.Visible = false;

            cargarCombobox();
        }
        public void cargarCombobox()
        {
            NegocioInventario inven = new NegocioInventario();
            try
            {
                if (inven.listarInventarios() != null)
                {
                    cbxProducto.DataSource = inven.listarInventarios();
                    //validar q contenga datos
                    cbxProducto.DisplayMember = "observaciones";
                    cbxProducto.ValueMember = "id_inventario";

                    cbxProducto.SelectedIndex = -1;
                    if (cbxProducto.SelectedIndex == -1)
                    {
                        cbxProducto.Text = "Seleccione un Inventario";
                    }
                }
                else
                {
                    MessageBox.Show("No hay Inventarios ingresados");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No hay Inventarios ingresados");
                
            }

        }
        private void cargarGrilla()
        {
            NegocioInventario inventario = new NegocioInventario();
            try
            {
                if (inventario.listarInventarios() != null)
                {

                    dataGridView1.DataSource = inventario.listarInventarios();
                    dataGridView1.ReadOnly = true;
                    dataGridView1.Columns[0].HeaderText = "CANTIDAD INVENTARIO";
                    dataGridView1.Columns[1].HeaderText = "FECHA";
                    dataGridView1.Columns[3].HeaderText = "ID INVENTARIO";
                    dataGridView1.Columns[4].HeaderText = "OBSERVACIONES";
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Update();

                }
                else
                {
                    MessageBox.Show("No hay datos ingresados");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No hay datos ingresados");

            }

        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            // seleccion = "";
            //INVENTARIO
            Inventario auxInventario = new Inventario();
            NegocioInventario inventario = new NegocioInventario();
            

            try
            {
                if (txtCantidad.Text != "" & txtObservaciones.Text != "")
                {
                    if (DateTime.Compare(dtpFecha.Value.Date, DateTime.Today) >= 0)
                    {
                        if (!validaCampoVacio(txtObservaciones)&int.Parse(txtCantidad.Text)>=0)
                        {
                            if (cbxProducto.SelectedIndex!=-1)
                            {


                                //Inventario
                                auxInventario.Cantidad_productos = int.Parse(txtCantidad.Text);
                                auxInventario.Observaciones = txtObservaciones.Text;
                                auxInventario.Fecha_inventario = dtpFecha.Value;
                                auxInventario.Id_inventario = int.Parse(cbxProducto.SelectedValue.ToString());

                                if (inventario.actualizarInventario(auxInventario)>0)
                                {
                                    MessageBox.Show("Inventario Modificado");
                                    txtCantidad.Text = "";
                                    txtObservaciones.Text = "";
                                    dtpFecha.Value = DateTime.Now;
                                    dataGridView1.DataSource = inventario.inventarioPorId(int.Parse(cbxProducto.SelectedValue.ToString()));
                                }
                                else
                                {
                                    MessageBox.Show("Error al Modificar Inventario ");
                                }
                                

                            }
                            else
                            {
                                MessageBox.Show("Seleccione un inventario");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Ingrese datos válidos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fecha  no puede ser mayor o igual a la fecha de hoy");
                    }
                }
                else
                {
                    MessageBox.Show("No deje el campos vacíos");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error intentelo nuevamente");
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
        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdministrarInventario inv = new MenuAdministrarInventario(lblRol.Text);
            inv.Show();
            Hide();
        }

       

        

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            txtCantidad.MaxLength = 38;
        }

        private void txtObservaciones_TextChanged(object sender, EventArgs e)
        {
            txtObservaciones.MaxLength = 100;
        }

        private void txtObservaciones_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtObservaciones.Text, @"^[A-Z0-9 a-z]*$")) && (txtObservaciones.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtObservaciones.Focus();
                txtObservaciones.Text = "";
            }
        }

        private void cbxProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Inventario auxInventario = new Inventario();
                NegocioInventario inventario = new NegocioInventario();

                auxInventario = inventario.consultarPorId(int.Parse(cbxProducto.SelectedValue.ToString()));
                txtCantidad.Text = auxInventario.Cantidad_productos.ToString();
                txtObservaciones.Text = auxInventario.Observaciones;
                dtpFecha.Value = auxInventario.Fecha_inventario;

            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar, intentelo nuevamente");
            }
        }
    }
}
