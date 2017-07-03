using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Residente
{
    public class Familiar
    {
        private int _idFamiliar;
        private int _idInfoPersonal;
        private string _parentezco;
        private int _idContrato;

        public int IdContrato
        {
            get { return _idContrato; }
            set { _idContrato = value; }
        }

        public string Parentezco
        {
            get { return _parentezco; }
            set { _parentezco = value; }
        }

        public int IdInfoPersonal
        {
            get { return _idInfoPersonal; }
            set { _idInfoPersonal = value; }
        }

        public int IdFamiliar
        {
            get { return _idFamiliar; }
            set { _idFamiliar = value; }
        }
    }
}
