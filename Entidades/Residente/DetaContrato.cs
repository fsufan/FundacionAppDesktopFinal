using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Residente
{
    public class DetaContrato
    {
        private int _idDetContrato;
        private int _idServicio;
        private int _costoTotal;

        public int CostoTotal
        {
            get { return _costoTotal; }
            set { _costoTotal = value; }
        }

        public int IdServicio
        {
            get { return _idServicio; }
            set { _idServicio = value; }
        }

        public int IdDetContrato
        {
            get { return _idDetContrato; }
            set { _idDetContrato = value; }
        }
    }
}
