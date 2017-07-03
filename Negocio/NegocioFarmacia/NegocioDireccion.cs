using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioDireccion
    {


        public int ingresarDireccion(Direccion direccion)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.ingresarDireccion(direccion.Id_direccion, direccion.Calle, direccion.Comuna, direccion.Cuidad, direccion.Region, direccion.CodigoPostal);
            if (objeto!=null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


        public int eliminarDireccion(int id)
        {

            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.eliminarDireccion(id);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }



        public int actualizarDireccion(Direccion direccion)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.modificarDireccion(direccion.Id_direccion, direccion.Calle, direccion.Comuna, direccion.Cuidad, direccion.Region, direccion.CodigoPostal);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public int consultarDireccion(String calle)
        {
            try
            {
                webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
                int id = webServiceFund.buscarDireccionPorCalle(calle);
                           
                return id;
               
            }
            catch (Exception)
            {

                return 0;
            }
            
           
        }

        public Array listarDirecciones()
        {

            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.listadoDireccion();
            return objeto;
            
        }

        public Array direccionPorId(int id)
        {

            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarDireccionPorId(id);
            return objeto;

        }

        public Direccion consultarPorId(int id)
        {
            Direccion auxDireccion = new Direccion();
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarDireccionPorId(id);
            if (objeto!=null)
            {
                foreach (webServiceFundacion.direccion item in objeto)
                {
                    auxDireccion.Id_direccion = item.id_direccion;
                    auxDireccion.Calle = item.calle;
                    auxDireccion.Cuidad = item.ciudad;
                    auxDireccion.CodigoPostal = item.codigoPostal;
                    auxDireccion.Comuna = item.comuna;
                    auxDireccion.Region = item.region;
                }
            }
            
            return auxDireccion;
        }
    }
}
