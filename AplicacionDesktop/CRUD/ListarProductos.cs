using AplicacionDesktop.MENU;
using CapaNegocio.NegocioFarmacia;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDesktop.CRUD
{
    public partial class ListarProductos : Form
    {
        public ListarProductos()
        {
            InitializeComponent();
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            NegocioProducto producto = new NegocioProducto();
            //VALIDAR  Q SEA DIFERENTE A NULL
            try
            {
                if (producto.listarProductos() != null)
                {

                    dataGridView1.DataSource = producto.listarProductos();
                    dataGridView1.ReadOnly = true;
                    dataGridView1.Columns[0].HeaderText = "CATEGORIA";
                    dataGridView1.Columns[1].HeaderText = "ID PRODUCTO";
                    dataGridView1.Columns[2].HeaderText = "ID PROVEEDOR";
                    dataGridView1.Columns[3].HeaderText = "NOMBRE";
                    dataGridView1.Columns[4].HeaderText = "PRECIO";
                    dataGridView1.Columns[5].HeaderText = "TIPO";
                    //dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Update();

                }
                else
                {
                    MessageBox.Show("No hay datos ingresados");
                    btn_pdf.Enabled = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No hay datos ingresados");
                //this.Close();
                btn_pdf.Enabled = false;

            }
            
        }
        private void btn_volver_Click(object sender, EventArgs e)
        {
            MenuAdminProductos menu = new MenuAdminProductos();
            menu.Show();
            Hide();
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioInventario inventario = new NegocioInventario();
                //Instanciamos la clase y cargamos el datagridview
                //NegocioMedicina aux = new NegocioMedicina();
                //dataGridView1.DataSource = aux.listarMedicinas();
                //dataGridView1.Update();
                Document doc = new Document(PageSize.LETTER);
                // Indicamos donde vamos a guardar el documento
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\PDFs\ListadoProductos.pdf", FileMode.Create));
                // Abrimos el archivo
                doc.Open();
                // Creamos una tabla 
                PdfPTable tblPrueba = new PdfPTable(dataGridView1.ColumnCount - 1);
                tblPrueba.WidthPercentage = 100;
                iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);


                tblPrueba.DefaultCell.Padding = 3;
                tblPrueba.WidthPercentage = 100;
                tblPrueba.HorizontalAlignment = Element.ALIGN_TOP;
                tblPrueba.DefaultCell.BorderWidth = 0;



                //Adding Header row
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {

                    //if (!column.DisplayIndex.Equals(2))
                    //{
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                        cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
                        cell.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
                        tblPrueba.AddCell(cell);
                    //}

                }

                //Adding DataRow
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //if (!cell.ColumnIndex.Equals(2))
                        //{
                            tblPrueba.AddCell(cell.Value.ToString());
                        //}



                    }
                }
                //Finalmente, añadimos la tabla al documento PDF y cerramos el documento
                doc.Add(tblPrueba);
                doc.Close();
                writer.Close();
                MessageBox.Show("¡PDF creado!");
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL CREAR PDF");
            }
        }
    }
}
