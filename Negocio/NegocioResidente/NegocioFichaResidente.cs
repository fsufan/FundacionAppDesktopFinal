using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_DTO.Residente;
using CapaNegocio.webServiceFundacion;

namespace CapaNegocio.NegocioResidente
{
    public class NegocioFichaResidente
    {


        public int ingresarFicResidente(FichaResidente ficha)
        {
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            string FR = web.ingresarFicResidente(ficha.IdFichaResidente,ficha.FechaInscripcion.ToShortDateString(),ficha.Comentarios,ficha.SituacionMedica);
            if (FR != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
	

        }


        public int eliminarFichaResidente(int id)
        {

            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            String dato = web.eliminarFicResidente(id);

            if (dato != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }





        public int actualizarFichaResidente(FichaResidente ficha)
        {
            try
            {
                webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
                String dato = web.modificarFicResidente(ficha.IdFichaResidente, ficha.FechaInscripcion.ToShortDateString(), ficha.Comentarios, ficha.SituacionMedica);
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


       

        public FichaResidente consultarporFecha(DateTime Fecha)
        {
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            Array Obj = web.buscarFicResidentePorFecha(Fecha.ToShortDateString());
            FichaResidente auxf = new FichaResidente();
            if (Obj !=null)
            {
                foreach (webServiceFundacion.ficResidente item in Obj)
                {
                    auxf.IdFichaResidente = item.id_fic_residente;
                }
            }
            return auxf;
        }

        public Array listarFichaResidente()
        {
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            Array dato = web.listadoFicResidente();

            return dato;
        }

        public FichaResidente consultarPorComentariosSituacion(string comen, string situacion)
        {

            FichaResidente FichaR = new FichaResidente();
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            Array dato = web.buscarFicResidentePorComSitua(comen,situacion);

            if (dato != null)
            {
                foreach (webServiceFundacion.ficResidente item in dato)
                {
                    FichaR.IdFichaResidente = item.id_fic_residente;
                    FichaR.FechaInscripcion = item.fec_inscripcion;
                    FichaR.SituacionMedica = item.situacion_medica;
                    FichaR.Comentarios = item.comentarios;
                }
            }
            return FichaR;
        }

        public FichaResidente consultarPorIdFichaR(int id)
        {
                       
            FichaResidente FichaR = new FichaResidente();
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            Array dato = web.buscarFicResidentePorId(id);

            if (dato != null)
            {
                foreach (webServiceFundacion.ficResidente item in dato)
                {
                    FichaR.IdFichaResidente = item.id_fic_residente;
                    FichaR.FechaInscripcion = item.fec_inscripcion;
                    FichaR.SituacionMedica = item.situacion_medica;
                    FichaR.Comentarios = item.comentarios;
                }
            }
            return FichaR;
        }

    }
}
