using AplicacionDesktop.MENU;
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
    public partial class IngresarMedicamentos : Form
    {
        public IngresarMedicamentos()
        {
            InitializeComponent();
            // Unidad medida
            Dictionary<string, string> undMed = new Dictionary<string, string>();
            undMed.Add("G", "GRAMOS");
            undMed.Add("MG", "MILIGRAMOS");
            undMed.Add("ML", "MILILITROS");
            undMed.Add("L", "LITROS");
            combum.DisplayMember = "Value";
            combum.ValueMember = "Key";
            combum.DataSource = undMed.ToArray();
            combum.SelectedIndex = -1;
            if (combum.SelectedIndex == -1)
            {
                combum.Text = "Seleccione Unidad de Medida";
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
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                String seleccion = "";
                Medicina auxMedicina = new Medicina();
                NegocioMedicina medicina = new NegocioMedicina();
                
                if (txtNombreG.Text != "" & txtNombreC.Text != "" & txtContenido.Text != "" & txtContenido.Text != "" & combum.SelectedIndex != -1 & txtCantidad.Text != "" & txtDes.Text != "")
                {
                    // La fecha de fabricacion y vencimientos sean diferentes
                    if (dtpff.Text.CompareTo(dtpfv.Text) != 0)
                    {
                        //Que la fecha de fabricacion sea menor o igual a la fecha de hoy
                        if (DateTime.Compare(dtpff.Value.Date, DateTime.Today) == 0 | DateTime.Compare(dtpff.Value.Date, DateTime.Today)<0)
                        {
                            //La fecha de vencimiento  sea mayor  a la fecha de hoy 
                            if (DateTime.Compare(dtpfv.Value.Date, DateTime.Today) != 0 | DateTime.Compare(dtpfv.Value.Date, DateTime.Today)>0)
                            {

                                if (combum.SelectedIndex != -1)
                                {
                                    seleccion = combum.SelectedValue.ToString();
                                    //validar fechas fecha_v > fecha_f < hoy

                                    if (!validaCampoVacio(txtNombreG) & !validaCampoVacio(txtNombreC)&!validaCampoVacio(txtDes) & int.Parse(txtCantidad.Text) > 0)
                                    {
                                        auxMedicina.Nom_generico = txtNombreG.Text.ToUpper().Trim();

                                        if (medicina.consultarMedicina(auxMedicina.Nom_generico) == 0)
                                        {
                                            DialogResult dialogResult = MessageBox.Show("Desea agregar la medicina: " + txtNombreC.Text, "Información", MessageBoxButtons.YesNo);
                                            if (dialogResult == DialogResult.Yes)
                                            {
                                                DialogResult result = MessageBox.Show("Se ingresara la medicina ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                                auxMedicina.Nom_comercial = txtNombreC.Text.ToUpper().Trim(); ;
                                                //| dtpff.Value.Date <= DateTime.Now.Date | dtpfv.Value.Date <= DateTime.Now.Date
                                                //validar q sea n?
                                                auxMedicina.Contenido = txtContenido.Text.ToUpper().Trim(); ;
                                                auxMedicina.Unidad_medida = combum.SelectedValue.ToString().ToUpper().Trim(); ;
                                                //validar q se pueda convertir
                                                auxMedicina.Cantidad = int.Parse(txtCantidad.Text);
                                                auxMedicina.Fec_fabricacion = dtpff.Value;
                                                auxMedicina.Fec_vencimiento = dtpfv.Value;
                                                auxMedicina.Descripcion = txtDes.Text.ToUpper().Trim(); ;
                                                switch (result)
                                                {
                                                    case DialogResult.Yes:
                                                        if (medicina.ingresarMedicina(auxMedicina) > 0)
                                                        {
                                                            MessageBox.Show("Medicina ingresada", "Información");
                                                            //mostrar medicinas ingresadas
                                                            cargarGrilla();
                                                            //limpiar campos
                                                            combum.SelectedIndex = -1;
                                                            txtNombreG.Text = "";
                                                            txtNombreC.Text = "";
                                                            txtContenido.Text = "";
                                                            txtCantidad.Text = "";
                                                            txtDes.Text = "";
                                                            dtpff.Value = DateTime.Now;
                                                            dtpfv.Value = DateTime.Now;
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("ERROR al ingresar medicina");
                                                        }

                                                        break;
                                                    case DialogResult.No:
                                                        break;

                                                }

                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("El medicamento ya esta registrado");
                                        }


                                    }
                                    else
                                    {
                                        MessageBox.Show("ingrese datos válidos");
                                    }



                                }
                                else
                                {
                                    MessageBox.Show("Seleccione una unidad de medida");
                                    //focusComponente(txtContrasena);
                                }
                            }
                            else
                            {
                                MessageBox.Show("La fecha de vencimiento no puede ser menor o igual a la fecha de hoy");
                            }
                        }

                        else
                        {
                            MessageBox.Show("La fecha de fabricacion no puede ser mayor a la fecha de hoy");
                        }
                    }
                    else
                    {
                        //La fecha de fabricacion no puede ser igual a la fecha de vencimiento
                        MessageBox.Show("La fecha de fabricacion no puede ser igual a la fecha de vencimiento");
                    }
                }
                else
                {
                    //La fecha de fabricacion no puede ser igual a la fecha de vencimiento
                    MessageBox.Show("ingrese todos los campos");
                }
            }
            catch (Exception )
            {
                MessageBox.Show("ERROR al registrar, intente nuevamente");
            }
        }

        private void cargarGrilla()
        {
            NegocioMedicina medicina = new NegocioMedicina();
            if (medicina.listarMedicinas() != null)
            {
                dataGridView1.DataSource = medicina.listarMedicinas();
                dataGridView1.ReadOnly = true;
                dataGridView1.Columns[0].HeaderText = "CANTIDAD";
                dataGridView1.Columns[1].HeaderText = "CONTENIDO";
                dataGridView1.Columns[2].HeaderText = "DESCRIPCION";
                dataGridView1.Columns[3].HeaderText = "FECHA FAB";
                dataGridView1.Columns[5].HeaderText = "FECHA VEC";
                dataGridView1.Columns[7].HeaderText = "ID MEDICINA";
                dataGridView1.Columns[8].HeaderText = "NOMBRE COMERCIAL";
                dataGridView1.Columns[9].HeaderText = "NOMBRE GENERICO";
                dataGridView1.Columns[10].HeaderText = "UNIDAD MEDIDA";
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[6].Visible = false;

                dataGridView1.Update();

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

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdminMedicamentos med = new MenuAdminMedicamentos();
            med.Show();
            Hide();
        }

        private void btnVolverr_Click(object sender, EventArgs e)
        {
            MenuAdminMedicamentos med = new MenuAdminMedicamentos();
            med.Show();
            Hide();
        }

        private void txtNombreC_TextChanged(object sender, EventArgs e)
        {
            txtNombreC.MaxLength = 100;
        }

        private void txtNombreG_TextChanged(object sender, EventArgs e)
        {
            txtNombreG.MaxLength = 50;
        }

        private void txtContenido_TextChanged(object sender, EventArgs e)
        {
            txtContenido.MaxLength = 4;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            txtCantidad.MaxLength = 38;
        }

        private void txtDes_TextChanged(object sender, EventArgs e)
        {
            txtDes.MaxLength = 250;
        }

        private void txtNombreC_Validating(object sender, CancelEventArgs e)
        {

            if ((!Regex.IsMatch(this.txtNombreC.Text, @"^[A-Z0-9 a-z]*$")) && (txtNombreC.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtNombreC.Focus();
                txtNombreC.Text = "";
            }
        }

        private void txtNombreG_Validating(object sender, CancelEventArgs e)
        {

            if ((!Regex.IsMatch(this.txtNombreG.Text, @"^[A-Z0-9 a-z]*$")) && (txtNombreG.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres validos");
                this.txtNombreG.Focus();
                txtNombreG.Text = "";
            }
        }

        private void txtContenido_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtContenido.Text, @"^\d+$")) && (txtContenido.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo números");
                this.txtContenido.Focus();
                txtContenido.Text = "";
            }
        }

        private void txtDes_Validating(object sender, CancelEventArgs e)
        {
            if ((!Regex.IsMatch(this.txtDes.Text, @"^[A-Z0-9 a-z]*$")) && (txtDes.Text != ""))
            {
                MessageBox.Show("Debe ingresar sólo caracteres vÁlidos");
                this.txtDes.Focus();
                txtDes.Text = "";
            }
        }

    }
}
