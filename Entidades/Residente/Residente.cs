using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Residente
{
    public class Residente
    {
        private int _idResidente;
        private int _idInfoPersonal;
        private int _edad;
        private int _idFamiliar;
        private int _idFicResidente;

        public Residente()
        {
        }
       
        public int IdFicResidente
        {
            get { return _idFicResidente; }
            set { _idFicResidente = value; }
        }

        public int IdFamiliar
        {
            get { return _idFamiliar; }
            set { _idFamiliar = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public int IdInfoPersonal
        {
            get { return _idInfoPersonal; }
            set { _idInfoPersonal = value; }
        }

        public int IdResidente
        {
            get { return _idResidente; }
            set { _idResidente = value; }
        }
        
    }
}
