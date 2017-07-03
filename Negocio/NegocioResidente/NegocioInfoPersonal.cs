using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_DTO.Residente;

namespace CapaNegocio.NegocioResidente
{
    public class NegocioInfoPersonal
    { 

        public int IngresarInfoPersonal(InformacionPersonal infoPersonal)
        {
          
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            String Info = web.ingresarInfoPersonal(infoPersonal.Id_InfoPersonal,infoPersonal.Nombre,infoPersonal.ApellidoPat,infoPersonal.ApellidoMat,infoPersonal.Rut,infoPersonal.FechaNac.ToShortDateString(),infoPersonal.Telefono,infoPersonal.Email,infoPersonal.IdDireccion);
            
            if (Info != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public int EliminarInforPersonalPorID(int idInfoPersonal)
        {
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            String dato = web.eliminarInfoPersonal(idInfoPersonal);
            if (dato != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

       

        public int ActualizarInfoPersonal(InformacionPersonal info)
        {
            
            try
            {
                webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
                String objeto = web.modificarInfoPersonal(info.Id_InfoPersonal, info.Nombre, info.ApellidoPat, info.ApellidoMat, info.Rut, info.FechaNac.ToShortDateString(), info.Telefono, info.Email, info.IdDireccion);
                if (objeto != null)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

     

        public InformacionPersonal BuscaridPorRut(string rut)
        {
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            Array Obj = web.buscarInfoPersonalPorRut(rut);
            InformacionPersonal info = new InformacionPersonal();
            if (Obj != null)
            {
                foreach (webServiceFundacion.infoPersonal item in Obj)
                {
                    info.Id_InfoPersonal = item.id_infopersonal;
                    info.Nombre = item.nombre;
                    info.ApellidoPat = item.apellidoPat;
                    info.ApellidoMat = item.apellidoMat;
                    info.Rut = item.rut;
                    info.FechaNac = item.fechanac;
                    info.Telefono = item.telefono;
                    info.Email = item.email;
                    info.IdDireccion = item.id_direccion;
                }
            }
            return info;
        }

        public bool consultarRut(String rut)
        {
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            if (web.buscarInfoPersonalPorRut(rut)!= null)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
       

        public Array listarInfoPersonal()
        {
            try
            {
                webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
                Array Objeto = web.listadoInfoPersonal();
                InformacionPersonal infop = new InformacionPersonal();
                foreach (webServiceFundacion.infoPersonal item in Objeto)
                {
                    infop.Rut = item.rut;
                    infop.Nombre = item.nombre;
                    infop.ApellidoPat = item.apellidoPat;
                    infop.ApellidoMat = item.apellidoMat;
                    infop.FechaNac = item.fechanac;
                    infop.Telefono = item.telefono;
                    infop.Email = item.email;
                }

                return Objeto;

            }
            catch (Exception)
            {

                return null;
            }

            

           
        }

        public InformacionPersonal consultaporIdInfoPersonal(int id)
        {
            InformacionPersonal infoP = new InformacionPersonal();

            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();

            Array Objeto = web.buscarInfoPersonalPorId(id);
            if (Objeto != null)
            {
                foreach (webServiceFundacion.infoPersonal item in Objeto)
                {
                    infoP.Id_InfoPersonal = item.id_infopersonal;
                    infoP.Nombre = item.nombre;
                    infoP.ApellidoPat = item.apellidoPat;
                    infoP.ApellidoMat = item.apellidoMat;
                    infoP.Rut = item.rut;
                    infoP.FechaNac = item.fechanac;
                    infoP.Telefono = item.telefono;
                    infoP.Email = item.email;
                    infoP.IdDireccion = item.id_direccion;
                }
            }

            return infoP;
        }
    }
}
