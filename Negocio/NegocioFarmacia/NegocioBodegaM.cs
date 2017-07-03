
using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioBodegaM
    {
       
        public int ingresarBodegaMedica(BodegaMedica bodMed, int inventario)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.ingresarBodegaMed(bodMed.Id_bodega_med, bodMed.Id_medicina, bodMed.Stock, inventario);
            if (objeto!=null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


        public int eliminarBodegaMedica(int id)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.eliminarBodegaMed(id);

            if (objeto!=null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }





        public int actualizarBodegaMedica(BodegaMedica bM)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.modificarBodegaMed(bM.Id_bodega_med,bM.Id_medicina,bM.Stock,bM.Id_inventario);
                if (objeto!=null)
	            {
                    return 1;
	            }else
	            {
                    return 0;
	            }
        }


        
        public Array listarBodegaMedica()
        {

            
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.listadoBodegaMed();
                
                    return objeto;
	            
        }
        public Array bodegaMedporId(int id)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarBodegaMedPorId(id);
            return objeto;
        }
        public BodegaMedica consultarPorId(int id)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarBodegaMedPorId(id);
            BodegaMedica auxbMed = new BodegaMedica();
            foreach (webServiceFundacion.bodegaMed item in objeto)
            {
                auxbMed.Id_bodega_med = item.id_bodega_med;
                auxbMed.Id_inventario = item.id_inventario;
                auxbMed.Id_medicina = item.id_medicina;
                auxbMed.Stock = item.stock;
            }
            return auxbMed;
        }

    }
}
