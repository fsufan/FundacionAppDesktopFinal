using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Usuario
{
    public class Paramedico
    {
        private int id_paramedico;
        private string turno;
        private string especialidad;
        private string descripcion;
        private DateTime fechaIngreso;
        private int id_infopersonal;
        private int id_usuario;


        public Paramedico()
        {
            this.Init();
        }

        private void Init()
        {
            id_paramedico = 0;
            turno = string.Empty;
            especialidad = string.Empty;
            descripcion = string.Empty;
            fechaIngreso = new DateTime(1900, 1, 1);
            Id_infopersonal = 0;
            id_usuario = 0;
        }

        public int Id_paramedico
        {
            get { return id_paramedico; }
            set { id_paramedico = value; }
        }
        

        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        

        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }
        

        public int Id_infopersonal
        {
            get { return id_infopersonal; }
            set { id_infopersonal = value; }
        }

        


        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }


    }
}
