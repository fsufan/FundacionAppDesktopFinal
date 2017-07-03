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
using Microsoft.Reporting.WinForms;
using CapaNegocio.NegocioReporte;
using Capa_DTO.Reporte;


namespace AplicacionDesktop.CRUD
{
    public partial class ReporteIngresos : Form
    {
        public ReporteIngresos()
        {
            InitializeComponent();
        }
        public ReporteIngresos(string rol)
        {
            InitializeComponent();
            lblRol.Text = rol;
            lblRol.Visible = false;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            MenuGenerarReportesG MR = new MenuGenerarReportesG(lblRol.Text);
            MR.Show();
            Hide();
        }


        private void ReporteIngresos_Load(object sender, EventArgs e)
        {
            try
            {
                NegocioReporte reporte = new NegocioReporte();
                ReporteMensual Auxrep = new ReporteMensual();
                Auxrep = reporte.reporteMensual();


                List<ReportParameter> parametros = new List<ReportParameter>();

                parametros.Add(new ReportParameter("ingresos", Auxrep.Aportes.ToString()));
                parametros.Add(new ReportParameter("pagos", Auxrep.Pagos.ToString()));
                parametros.Add(new ReportParameter("gastos",Auxrep.Gastos.ToString()));
                parametros.Add(new ReportParameter("total", Auxrep.Total.ToString()));
                this.reportViewer1.LocalReport.SetParameters(parametros);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {
               
                MessageBox.Show("No hay datos para mostrar");
            }
           
        }
    }
}
