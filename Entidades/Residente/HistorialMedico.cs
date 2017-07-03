using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Residente
{
    public class HistorialMedico
    {
        private int _idHistoMedico;
        private string _enfermedades;
        private string _alergias;
        private string _tratamientoEspecial;
        private int _idFicResidente;

        public int IdFicResidente
        {
            get { return _idFicResidente; }
            set { _idFicResidente = value; }
        }

        
        public string TratamientoEspecial
        {
            get { return _tratamientoEspecial; }
            set { _tratamientoEspecial = value; }
        }

        public string Alergias
        {
            get { return _alergias; }
            set { _alergias = value; }
        }

        public string Enfermedades
        {
            get { return _enfermedades; }
            set { _enfermedades = value; }
        }

        public int IdHistoMedico
        {
            get { return _idHistoMedico; }
            set { _idHistoMedico = value; }
        }
    }
}
