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
    public partial class IngresarInventario : Form
    {
        public IngresarInventario()
        {
            InitializeComponent();
        }
        public IngresarInventario(string rol)
        {
            InitializeComponent();
            lblRol.Text = rol;
            lblRol.Visible = false;
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
        private void rdMedicina_CheckedChanged(object sender, EventArgs e)
        {
            
            
            try
            {
                if (!rdMedicina.Checked)
                {
                   
                }
                else
                {
                    NegocioMedicina medic = new NegocioMedicina();
                    if (medic.listarMedicinas()!=null)
                    {
                        cbxMedicina.DataSource = medic.listarMedicinas();
                        //validar q contenga datos
                        cbxMedicina.DisplayMember = "nom_comercial";
                        cbxMedicina.ValueMember = "id_medicina";
                        //cbxMedicina.DataSource = DataHelper.LoadDataTable();
                        //cbxMedicina.AutoCompleteCustomSource = DataHelper.LoadAutoComplete();
                        //cbxMedicina.AutoCompleteMode = AutoCompleteMode.Suggest;
                        //cbxMedicina.AutoCompleteSource = AutoCompleteSource.CustomSource;

                        cbxMedicina.SelectedIndex = -1;
                        if (cbxMedicina.SelectedIndex == -1)
                        {
                            cbxMedicina.Text = "Seleccione una Medicina";
                        }
                    }
                    else
                    {
                        //rdMedicina.Enabled = false;
                        //cbxMedicina.Enabled = false;
                        MessageBox.Show("No hay medicinas ingresadas");
                    }
                }
               
            }
            catch (Exception)
            {

                MessageBox.Show("Error intentelo nuevamente");
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // seleccion = "";
            //INVENTARIO
            Inventario auxInventario = new Inventario();
            NegocioInventario inventario = new NegocioInventario();
            //BODEGA MEDICA
            BodegaMedica auxBmedicina = new BodegaMedica();
            NegocioBodegaM bMedicina = new NegocioBodegaM();
            //MEDICINA
            NegocioMedicina medicina = new NegocioMedicina();
            Medicina auxMedicina = new Medicina();
            //BODEGA PRODUCTO
            NegocioBodegaP bProducto = new NegocioBodegaP();
            BodegaProducto auxBproducto = new BodegaProducto();
            //PRODUCTO
            NegocioProducto producto = new NegocioProducto();
            Producto auxProducto = new Producto();
            
            try
            {
                if (txtCantidad.Text != "" & txtObservaciones.Text !="" & txtCantidad.Text!="")
                {
                    if (DateTime.Compare(dtpFecha.Value.Date, DateTime.Today) >= 0)
                    {
                        if (!validaCampoVacio(txtObservaciones)&int.Parse(txtCantidad.Text)>0)
                        {
                            if (rdMedicina.Checked | rdProducto.Checked)
                            {


                                //Inventario
                                auxInventario.Cantidad_productos = int.Parse(txtCantidad.Text);
                                auxInventario.Observaciones = txtObservaciones.Text;
                                auxInventario.Fecha_inventario = dtpFecha.Value;
                                if (rdMedicina.Checked && cbxMedicina.SelectedIndex != -1)
                                {

                                    if (inventario.consultarInventario(auxInventario.Observaciones, auxInventario.Fecha_inventario) == 0)
                                    {

                                        DialogResult dialogResult = MessageBox.Show("Desea agregar inventario de la medicina: " + cbxMedicina.Text, "Información", MessageBoxButtons.YesNo);
                                        if (dialogResult == DialogResult.Yes)
                                        {
                                            DialogResult result = MessageBox.Show("Se ingresara el inventario de la medicina ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                            switch (result)
                                            {


                                                case DialogResult.Yes:
                                                    if (inventario.ingresarInventario(auxInventario) > 0)
                                                    {
                                                        //Bodega Medicina
                                                        auxBmedicina.Id_medicina = int.Parse(cbxMedicina.SelectedValue.ToString());
                                                        //obtener id inventario
                                                        auxInventario.Id_inventario = inventario.consultarInventario(auxInventario.Observaciones, DateTime.Parse(auxInventario.Fecha_inventario.ToShortDateString()));

                                                        //obtener medicina
                                                        auxMedicina = medicina.consultarPorIdMedicina(auxBmedicina.Id_medicina);
                                                        //obtener cantidad medicina
                                                        auxBmedicina.Stock = auxMedicina.Cantidad;

                                                        if (bMedicina.ingresarBodegaMedica(auxBmedicina, auxInventario.Id_inventario) > 0)
                                                        {

                                                            txtCantidad.Text = "";
                                                            txtObservaciones.Text = "";
                                                            dtpFecha.Value = DateTime.Now;
                                                            cbxMedicina.SelectedIndex = -1;
                                                            rdMedicina.Checked = false;
                                                            MessageBox.Show("Inventario ingresado correctamente");
                                                            cargarGrilla();
                                                            
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("ERROR, al registrar, intente nuevamente");
                                                        }
                                                    }
                                                    break;
                                                case DialogResult.No:
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El inventario ya existe");
                                    }
                                }
                                else
                                {
                                    if (rdProducto.Checked && cbxProducto.SelectedIndex != -1)
                                    {
                                        NegocioProducto produc = new NegocioProducto();
                                        

                                        if (inventario.consultarInventario(auxInventario.Observaciones, auxInventario.Fecha_inventario) == 0)
                                        {
                                            DialogResult dialogResult = MessageBox.Show("Desea agregar un inventario de producto: " + cbxProducto.Text, "Información", MessageBoxButtons.YesNo);
                                            if (dialogResult == DialogResult.Yes)
                                            {
                                                DialogResult result = MessageBox.Show("Se ingresara inventario de producto ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                                switch (result)
                                                {


                                                    case DialogResult.Yes:
                                                        if (inventario.ingresarInventario(auxInventario) > 0)
                                                        {
                                                            //obtener id inventario
                                                            auxInventario.Id_inventario = inventario.consultarInventario(auxInventario.Observaciones, auxInventario.Fecha_inventario);

                                                            auxBproducto.Id_producto = int.Parse(cbxProducto.SelectedValue.ToString());
                                                            //Obtener cantidad producto
                                                            //?? como obtener cantidad
                                                            auxBproducto.Stock = int.Parse(txtCantidad.Text);

                                                            if (bProducto.ingresarBodegaProducto(auxBproducto, auxInventario.Id_inventario) > 0)
                                                            {

                                                                txtCantidad.Text = "";
                                                                txtObservaciones.Text = "";
                                                                dtpFecha.Value = DateTime.Now;
                                                                cbxMedicina.SelectedIndex = -1;
                                                                rdMedicina.Checked = false;
                                                                MessageBox.Show("Inventario ingresado correctamente");
                                                                cargarGrilla();
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("ERROR, al registrar, intente nuevamente");
                                                            }
                                                        }
                                                        break;
                                                    case DialogResult.No:
                                                        break;
                                                    default:
                                                        break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("El inventario ya existe");
                                        }

                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("Seleccione producto o medicina");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Ingrese campos válidos");
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

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdministrarInventario adInv = new MenuAdministrarInventario(lblRol.Text);
            adInv.Show();
            Hide();
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

        private void rdProducto_Click(object sender, EventArgs e)
        {
            rdMedicina.Checked = false;
            rdProducto.Checked = true;
        }

        private void rdMedicina_Click(object sender, EventArgs e)
        {
            rdMedicina.Checked = true;
            rdProducto.Checked = false;
        }

        private void rdProducto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!rdProducto.Checked)
                {
                   
                }
                else
                {
                    NegocioProducto produc = new NegocioProducto();
                    if (produc.listarProductos() != null)
                    {
                        cbxProducto.DataSource = produc.listarProductos();
                        //validar q contenga datos
                        cbxProducto.DisplayMember = "nombre";
                        cbxProducto.ValueMember = "id_producto";

                        cbxProducto.SelectedIndex = -1;
                        if (cbxProducto.SelectedIndex == -1)
                        {
                            cbxProducto.Text = "Seleccione un producto";
                        }
                    }
                    else
                    {
                        //rdMedicina.Enabled = false;
                        //cbxMedicina.Enabled = false;
                        MessageBox.Show("No hay productos ingresados");
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error intentelo nuevamente");
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

        

        //private void IngresarInventario_Load(object sender, EventArgs e)
        //{
        //    rdProducto.Checked = false;
            
        //}

        

    }
}
