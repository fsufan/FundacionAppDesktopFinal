using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Residente
{
    public class Contrato
    {
        private int _idContrato;
        private int _iddetalleContrato;
        private string _condicionesPerm;


        public string CondicionesPerm
        {
            get { return _condicionesPerm; }
            set { _condicionesPerm = value; }
        }

        public int IddetalleContrato
        {
            get { return _iddetalleContrato; }
            set { _iddetalleContrato = value; }
        }

        public int IdContrato
        {
            get { return _idContrato; }
            set { _idContrato = value; }
        }
    }
}
