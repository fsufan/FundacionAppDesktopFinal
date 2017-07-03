using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Residente
{
    public class Servicio
    {
        private int _idServicio;
        private string _nombreServicio;
        private string _descripcion;
        private int _costoServicio;

        public int CostoServicio
        {
            get { return _costoServicio; }
            set { _costoServicio = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string NombreServicio
        {
            get { return _nombreServicio; }
            set { _nombreServicio = value; }
        }

        public int IdServicio
        {
            get { return _idServicio; }
            set { _idServicio = value; }
        }
    }
}
