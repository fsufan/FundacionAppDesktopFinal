using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioProveedor
    {
       
        public int ingresarProveedor(Proveedor prov, int direccion)
        {            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.ingresarProveedor(prov.Id_proveedor, prov.Rut_empresa, prov.Razon_social, direccion);
            if (objeto!=null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public int eliminarProveedor(int prove)
        {

            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.eliminarProveedor(prove);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }





        public int actualizarProveedor(Proveedor prov)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.modificarProveedor(prov.Id_proveedor, prov.Rut_empresa, prov.Razon_social, prov.Id_direccion);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public int consultarProveedor(String prov)
        {
            try
            {
                webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
                Array objeto = webServiceFund.buscarProveedorPorRazonSocial(prov);
                if (objeto!=null)
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

        public Array listarProveedor()
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.listadoProveedor();
            return objeto;
            
        }

        public Array proveedorPorId(int id)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarProveedorPorId(id);
            return objeto;
        }
        public Proveedor consultarPorId(int id)
        {
                       
            Proveedor auxProveedor = new Proveedor();

            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarProveedorPorId(id);
            if (objeto!=null)
            {
                foreach (webServiceFundacion.proveedor item in objeto)
                {
                    auxProveedor.Id_proveedor = item.id_proveedor;
                    auxProveedor.Id_direccion = item.id_direccion;
                    auxProveedor.Rut_empresa = item.rut_empresa;
                    auxProveedor.Razon_social = item.razon_social;
                }
            }
                                            

                   
            return auxProveedor;
        }
    }
}
