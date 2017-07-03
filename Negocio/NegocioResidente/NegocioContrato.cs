using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_DTO.Residente;
using CapaNegocio.webServiceFundacion;

namespace CapaNegocio.NegocioResidente
{
    public class NegocioContrato
    {
        
        public int IngresarContrato(Contrato contrato)
        {
          

            webServiceFundacion.webServiceFundacion webService = new webServiceFundacion.webServiceFundacion();
            string contra = webService.ingresarContrato(contrato.IdContrato,contrato.IddetalleContrato,contrato.CondicionesPerm);
            if (contra != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int EliminarContrato(int id)
        {
            
            webServiceFundacion.webServiceFundacion webService = new webServiceFundacion.webServiceFundacion();
            string dato = webService.eliminarContrato(id);

            if (dato !=null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

       
        public int ActualizarContrato(Contrato contra)
        {
            try
            {

                webServiceFundacion.webServiceFundacion webService = new webServiceFundacion.webServiceFundacion();
                string dato = webService.modificarContrato(contra.IdContrato, contra.IddetalleContrato, contra.CondicionesPerm);

                if (dato != null)
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

        public int consultarPorId(int ID)
        {
            
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();

          if (web.buscarContratoPorId(ID)!= null)
	        {
		        return 1;
	        }else
	            {
                    return 0;
	            }


        }

        public int consultarCondiciones(string c)
        {
            
            return 0;
   
        }


        public Array listarContrato()
        {

            try
            {
                webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
                Array dato = web.listadoContrato();

                return dato;

            }
            catch (Exception)
            {

                return null;
            }
           

        }

        public Contrato consultaporIdContrato(int id)
        {
            Contrato Contrato = new Contrato();
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarContratoPorId(id);
            if (objeto != null)
            {
                foreach (webServiceFundacion.contrato item in objeto)
                {

                    Contrato.IdContrato = item.id_contrato;
                    Contrato.IddetalleContrato = item.id_det_contrato;
                    Contrato.CondicionesPerm = item.condiciones_perm;
                    
                }


            }

            return Contrato;
        }
    }
}
