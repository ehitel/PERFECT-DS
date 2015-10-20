using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Logica
{
    public class PresentacionGestor
    {

        public List<PRESENTACION_CONSULTA> obtenerCatalogoPresentaciones()
        {
            try
            {
                PERFECTEntities ent = new PERFECTEntities();

                return ent.PROG_PRESENTACION_CONSULTA_GENERAL().ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ResultadoTransaccion GuardarRegistro(PRESENTACION presentacion)
        {
            try
            {
                PERFECTEntities entidad = new PERFECTEntities();
                System.Data.Entity.Core.Objects.ObjectParameter resultado = new System.Data.Entity.Core.Objects.ObjectParameter("RESULTADO", typeof(string));
                System.Data.Entity.Core.Objects.ObjectParameter mensaje = new System.Data.Entity.Core.Objects.ObjectParameter("MENSAJE", typeof(string));


                entidad.PROG_PRESENTACION_ACTUALIZA(presentacion.CODIGO_PRESENTACION, presentacion.NOMBRE_PRESENTACION, resultado, mensaje);


                return new ResultadoTransaccion
                {
                    Resultado = resultado.Value.ToString().ToLower() == "ok" ? TipoResultado.Ok : TipoResultado.Error,
                    Mensaje = mensaje.Value.ToString()                    
                };

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }
}
