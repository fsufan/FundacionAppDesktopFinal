using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionDesktop.MENU;
using CapaNegocio.NegocioFarmacia;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using CapaNegocio.NegocioReporte;

namespace AplicacionDesktop.CRUD
{
    public partial class ListarCompras : Form
    {
        public ListarCompras()
        {
            InitializeComponent();
            cargarGrilla();
        }
        public ListarCompras(string rol)
        {
            InitializeComponent();
            lblRol.Text = rol;
            lblRol.Visible = false;
            cargarGrilla();
            
        }
        private void cargarGrilla()
        {

            NegocioReporte reporte = new NegocioReporte();
            try
            {
                if (reporte.reporteCompra() != null)
                {

                    dataGridView1.DataSource = reporte.reporteCompra();
                    dataGridView1.ReadOnly = true;
                    dataGridView1.Columns[0].HeaderText = "CANT PROD";
                    dataGridView1.Columns[1].HeaderText = "CATEGORIA";
                    dataGridView1.Columns[2].HeaderText = "DESCRIPCION COMPRA";
                    dataGridView1.Columns[3].HeaderText = "DESCRIPCION DETALLE";
                    dataGridView1.Columns[4].HeaderText = "FECHA COMPRA";
                    dataGridView1.Columns[6].HeaderText = "ID COMPRA";
                    dataGridView1.Columns[7].HeaderText = "ID DETALLE";
                    dataGridView1.Columns[8].HeaderText = "ID PRODUCTO";
                    dataGridView1.Columns[9].HeaderText = "TOTAL COMPRA";
                    dataGridView1.Columns[10].HeaderText = "NOMBRE";
                    dataGridView1.Columns[11].HeaderText = "PRECIO";
                    dataGridView1.Columns[12].HeaderText = "TIPO";
                    dataGridView1.Columns[13].HeaderText = "TOTAL DETALLE";
                    dataGridView1.Columns[5].Visible = false;

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
                btn_pdf.Enabled = false;
            }

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            MenuAdminCompra mCompra = new MenuAdminCompra(lblRol.Text);
            mCompra.Show();
            Hide();
            this.Close();
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioReporte reporte = new NegocioReporte();
                //Instanciamos la clase y cargamos el datagridview
                //NegocioMedicina aux = new NegocioMedicina();
                //dataGridView1.DataSource = aux.listarMedicinas();
                //dataGridView1.Update();
                Document doc = new Document(PageSize.LETTER);
                doc.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
                // Indicamos donde vamos a guardar el documento
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\PDFs\ReporteCompra.pdf", FileMode.Create));
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

                    if (!column.DisplayIndex.Equals(5))
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                        cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
                        cell.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
                        tblPrueba.AddCell(cell);
                    }

                }

                //Adding DataRow
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (!cell.ColumnIndex.Equals(5))
                        {
                            tblPrueba.AddCell(cell.Value.ToString());
                        }



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
