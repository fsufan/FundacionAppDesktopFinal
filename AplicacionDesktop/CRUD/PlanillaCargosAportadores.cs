using AplicacionDesktop.MENU;
using CapaNegocio.NegocioReporte;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDesktop.CRUD
{
    public partial class PlanillaCargosAportadores : Form
    {
        public PlanillaCargosAportadores()
        {
            InitializeComponent();
        }
        public PlanillaCargosAportadores(string rol)
        {
            InitializeComponent();
            lblRol.Text = rol;
            lblRol.Visible = false;
        }
        private void btn_volver_Click(object sender, EventArgs e)
        {
            MenuGenerarReportesG MR = new MenuGenerarReportesG(lblRol.Text);
            MR.Show();
            this.Close();
        }

        private void PlanillaCargosAportadores_Load(object sender, EventArgs e)
        {
            NegocioReporte reporte = new NegocioReporte();
            Array lista = reporte.reporteAportador();
            if (lista!=null)
            {
                //ReportDataSource rds = new ReportDataSource("ReporteAportador", lista);
                ReportDataSource rds = new ReportDataSource();
                rds.Value = lista;
                rds.Name = "DataSet1";
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);

                this.reportViewer1.RefreshReport();

            }
            else
            {
                MessageBox.Show("No hay datos para mostar");
            }
            
        }
    }
}
