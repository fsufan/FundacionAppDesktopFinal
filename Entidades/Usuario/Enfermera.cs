using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Usuario
{
    public class Enfermera
    {
        private int id_enfermera;
        private string turno;
        private string especialidad;
        private string descripcion;
        private DateTime fechaIngreso;
        private int id_infopersonal;
        private int id_usuario;

        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        public int Id_infopersonal
        {
            get { return id_infopersonal; }
            set { id_infopersonal = value; }
        }

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        public int Id_enfermera
        {
            get { return id_enfermera; }
            set { id_enfermera = value; }
        }
    }
}
