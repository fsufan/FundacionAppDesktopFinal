using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Residente
{
    public class InformacionPersonal
    {
        private int _id_InfoPersonal;
        private string _nombre;
        private string _ApellidoPat;
        private string _ApellidoMat;
        private string _rut;
        private DateTime _fechaNac;
        private int _telefono;
        private string _email;
        private int _idDireccion;


        public InformacionPersonal()
        {
           
        }

        

        public int IdDireccion
        {
            get { return _idDireccion; }
            set { _idDireccion = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public DateTime FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }

        public string Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }

        public string ApellidoMat
        {
            get { return _ApellidoMat; }
            set { _ApellidoMat = value; }
        }

        public string ApellidoPat
        {
            get { return _ApellidoPat; }
            set { _ApellidoPat = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Id_InfoPersonal
        {
            get { return _id_InfoPersonal; }
            set { _id_InfoPersonal = value; }
        }
    }
}
