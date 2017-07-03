using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Residente
{
    public class FichaResidente
    {
        private int _idFichaResidente;
        private DateTime _fechaInscripcion;
        private string _comentarios;
        private string _situacionMedica;

       
        public string SituacionMedica
        {
            get { return _situacionMedica; }
            set { _situacionMedica = value; }
        }

        public string Comentarios
        {
            get { return _comentarios; }
            set { _comentarios = value; }
        }

        public DateTime FechaInscripcion
        {
            get { return _fechaInscripcion; }
            set { _fechaInscripcion = value; }
        }

        public int IdFichaResidente
        {
            get { return _idFichaResidente; }
            set { _idFichaResidente = value; }
        }
    }
}
