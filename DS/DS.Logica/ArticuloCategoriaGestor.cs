using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Logica
{
    public class ArticuloCategoriaGestor
    {

        public List<CATEGORIA_CONSULTA> obtenerCatalogo()
        {
            try
            {
                PERFECTEntities ent = new PERFECTEntities();

                return ent.PROG_ARTICULO_CATEGORIA_CONSULTA_GENERAL().ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ResultadoTransaccion guardarRegistro(ARTICULO_CATEGORIA categoria)
        {
            try
            {
                PERFECTEntities entidad = new PERFECTEntities();
                System.Data.Entity.Core.Objects.ObjectParameter resultado = new System.Data.Entity.Core.Objects.ObjectParameter("RESULTADO", typeof(string));
                System.Data.Entity.Core.Objects.ObjectParameter mensaje = new System.Data.Entity.Core.Objects.ObjectParameter("MENSAJE", typeof(string));


                entidad.PROG_ARTICULO_CATEGORIA_ACTUALIZA(categoria.CODIGO_CATEGORIA, categoria.NOMBRE_CATEGORIA, resultado, mensaje);


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


        public CATEGORIA_CONSULTA obterCategoria(string codigoCategoria)
        {
            try
            {
                PERFECTEntities entidad = new PERFECTEntities();

                List<CATEGORIA_CONSULTA> result = entidad.PROG_ARTICULO_CATEGORIA_CONSULTA_UNICO(codigoCategoria).ToList();

                if (result.Count() > 0)
                {
                    return result.First();
                }
                else
                {
                    return null;
                }
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ResultadoTransaccion borrarRegistro(string codigoCategoria)
        {
            try
            {
                PERFECTEntities entidad = new PERFECTEntities();
                System.Data.Entity.Core.Objects.ObjectParameter resultado = new System.Data.Entity.Core.Objects.ObjectParameter("RESULTADO", typeof(string));
                System.Data.Entity.Core.Objects.ObjectParameter mensaje = new System.Data.Entity.Core.Objects.ObjectParameter("MENSAJE", typeof(string));


                entidad.PROG_ARTICULO_CATEGORIA_BORRAR(codigoCategoria, resultado, mensaje);


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
