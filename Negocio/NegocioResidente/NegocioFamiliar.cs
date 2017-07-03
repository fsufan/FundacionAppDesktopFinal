using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Conexion;
using Capa_DTO.Residente;
using CapaNegocio.webServiceFundacion;

namespace CapaNegocio.NegocioResidente
{
    public class NegocioFamiliar
    {
        

        public int IngresarFamiliar(Familiar fami)
        {

            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            string fam = web.ingresarFamiliar(fami.IdFamiliar,fami.IdInfoPersonal,fami.Parentezco,fami.IdContrato);

            if (fami != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public int EliminarFamiliarporID(int id)
        {


            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            string datos = web.eliminarFamiliar(id);
            if (datos != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public Familiar consultarporParentesco(string parent)
        {

            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();

            Array obj = web.buscarFamiliarPorParentezco(parent);
            Familiar auxfami = new Familiar();
            if (obj != null)
            {
                foreach (webServiceFundacion.familiar item in obj)
                {
                    auxfami.IdFamiliar = item.id_familiar;
                    auxfami.IdInfoPersonal = item.id_infopersonal;
                    auxfami.IdContrato = item.id_contrato;
                    auxfami.Parentezco = item.parentezco;
                }
            }
            return auxfami;

        }

        public Familiar consultaridFamiliarporidInfo(int id)
        {

            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();

            Array obj = web.buscarFamiliarPorIdInfopersonal(id);
            Familiar auxfami = new Familiar();
            if (obj != null)
            {
                foreach (webServiceFundacion.familiar item in obj)
                {
                    auxfami.IdFamiliar = item.id_familiar;
                    auxfami.IdInfoPersonal = item.id_infopersonal;
                    auxfami.IdContrato = item.id_contrato;
                    auxfami.Parentezco = item.parentezco;
                }
            }
            return auxfami;

        }


        public int ActualizarFamiliar(Familiar fami)
        {
            try
            {
                webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
                String objeto = webServiceFund.modificarFamiliar(fami.IdFamiliar, fami.IdInfoPersonal, fami.Parentezco, fami.IdContrato);

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

        public Array listarFamiliar()
        {
            try
            {
                webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
                Array aux = webServiceFund.listadoFamiliar();



                return aux;
            }
            catch (Exception)
            {
                Array aux = null;
                return aux;
            }
        }

      

        public Familiar consultarPorIdFamiliar(int id)
        {

            Familiar familiar = new Familiar();
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarFamiliarPorId(id);
            if (objeto != null)
            {
                foreach (webServiceFundacion.familiar item in objeto)
                {

                    familiar.IdFamiliar = item.id_familiar;
                    familiar.IdInfoPersonal = item.id_infopersonal;
                    familiar.Parentezco = item.parentezco;
                    familiar.IdContrato = item.id_contrato;
                    
                }


            }

            return familiar;
        }

    }
}
