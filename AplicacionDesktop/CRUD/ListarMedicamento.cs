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
    public partial class ListarMedicamento : Form
    {
        public ListarMedicamento()
        {
            InitializeComponent();
            cargarGrilla();
            
        }
        private void cargarGrilla()
        {
            NegocioMedicina medicina = new NegocioMedicina();
            try
            {
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
                else
                {
                    MessageBox.Show("No hay medicinas ingresadas");

                    button1.Enabled = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No hay medicinas ingresadas");

                button1.Enabled = false;
            }
            
        }

        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdminMedicamentos med = new MenuAdminMedicamentos();
            med.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Instanciamos la clase y cargamos el datagridview
            //NegocioMedicina aux = new NegocioMedicina();
            //dataGridView1.DataSource = aux.listarMedicinas();
            //dataGridView1.Update();
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\PDFs\ListadoMedicinas.pdf", FileMode.Create));
            // Abrimos el archivo
            doc.Open();
            // Creamos una tabla 
            PdfPTable tblPrueba = new PdfPTable(dataGridView1.ColumnCount-2);
            tblPrueba.WidthPercentage = 100;
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);


            tblPrueba.DefaultCell.Padding = 3;
            tblPrueba.WidthPercentage = 100;
            tblPrueba.HorizontalAlignment = Element.ALIGN_TOP;
            tblPrueba.DefaultCell.BorderWidth = 0;
            


            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                
                if (!column.DisplayIndex.Equals(4) && !column.DisplayIndex.Equals(6))
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
                    if (!cell.ColumnIndex.Equals(4)&&!cell.ColumnIndex.Equals(6))
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
   }
    
}
