using Capa_DTO.Reporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio.NegocioReporte
{
    public class NegocioReporte
    {
        public Array reporteCompra()
        {
            webServiceFundacion.webServiceFundacion webService = new webServiceFundacion.webServiceFundacion();
            Array objeto = webService.listadoReporteCompra();
            return objeto;
        }
        public Array reporteInventario()
        {
            webServiceFundacion.webServiceFundacion webService = new webServiceFundacion.webServiceFundacion();
            Array objeto = webService.listadoReporteInventario();
            return objeto;
        }
        public ReporteMensual reporteMensual()
        {
            webServiceFundacion.webServiceFundacion webService = new webServiceFundacion.webServiceFundacion();
            Array objeto = webService.listadoReporteMensual();
            ReporteMensual reporte = new ReporteMensual();
            foreach (webServiceFundacion.reporteMensual item in objeto)
            {
                reporte.Aportes = item.arecibidos;
                reporte.Pagos = item.presidentes;
                reporte.Gastos = item.gastos;
                reporte.Total = item.total;
            }
            return reporte;
        }
        public Array reporteAportador()
        {
            webServiceFundacion.webServiceFundacion webService = new webServiceFundacion.webServiceFundacion();
            Array objeto = webService.listadoReporteAportador();
            return objeto;
        }
    }
}
