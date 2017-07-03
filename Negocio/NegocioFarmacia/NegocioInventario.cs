using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioInventario
    {   public int ingresarInventario(Inventario inventario)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.ingresarInventario(inventario.Id_inventario, inventario.Cantidad_productos, inventario.Fecha_inventario.ToShortDateString(), inventario.Observaciones);
            if (objeto!=null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public int eliminarInventario(int id)
        {

            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.eliminarInventario(id);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }





        public int actualizarInventario(Inventario inventario)
        {
            
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.modificarInventario(inventario.Id_inventario, inventario.Cantidad_productos, inventario.Fecha_inventario.ToShortDateString(), inventario.Observaciones);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public int consultarInventario(String observaciones, DateTime fecha)
        {
            
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            try
            {
                int objeto = webServiceFund.buscarInventarioPorFechaYObs(fecha.ToShortDateString(), observaciones);
                return objeto;
            }
            catch (Exception)
            {

                return 0;
            }
           

        }
               

        public Array inventarioPorId(int id)
        {

            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarInventarioPorId(id);
           
                return objeto;
            
        }

        public Array listarInventarios()
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.listadoInventario();

            return objeto;
        }


        public Inventario consultarPorId(int id)
        {

            Inventario auxInventario = new Inventario();

            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarInventarioPorId(id);
            if (objeto!=null)
            {
                foreach (webServiceFundacion.inventario item in objeto)
                {
                    auxInventario.Id_inventario = item.id_inventario;
                    auxInventario.Cantidad_productos = item.cantidad_productos;
                    auxInventario.Fecha_inventario = item.fecha_inventario;
                    auxInventario.Observaciones = item.observaciones;
                }
            }
            return auxInventario;
        }
    }
}
