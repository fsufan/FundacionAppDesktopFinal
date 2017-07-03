using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Reporte
{
    public class ReporteMensual
    {
        private int aportes;
        private int pagos;
        private int gastos;
        private int total;

        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        

        public int Gastos
        {
            get { return gastos; }
            set { gastos = value; }
        }
        

        public int Pagos
        {
            get { return pagos; }
            set { pagos = value; }
        }
        

        public int Aportes
        {
            get { return aportes; }
            set { aportes = value; }
        }
        
    }
}
