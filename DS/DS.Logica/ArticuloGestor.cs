using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Logica
{
    public class ArticuloGestor
    {
        public List<ARTICULO_CONSULTA> obtenerCatalogo(string codigoArticulo, string nombreArticulo)
        {
            try
            {
                PERFECTEntities ent = new PERFECTEntities();

                return ent.PROG_ARTICULO_CONSULTA_GENERAL(codigoArticulo, nombreArticulo).ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public ARTICULO_CONSULTA obtenerArticulo(string codigoArticulo)
        {
            try
            {
                PERFECTEntities ent = new PERFECTEntities();

                 var result = ent.PROG_ARTICULO_CONSULTA_UNICO(codigoArticulo).ToList();

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

        public ResultadoTransaccion guardarRegistro(ARTICULO articulo)
        {
            try
            {
                PERFECTEntities entidad = new PERFECTEntities();

                System.Data.Entity.Core.Objects.ObjectParameter resultado = new System.Data.Entity.Core.Objects.ObjectParameter("RESULTADO", typeof(string));
                System.Data.Entity.Core.Objects.ObjectParameter mensaje = new System.Data.Entity.Core.Objects.ObjectParameter("MENSAJE", typeof(string));


                entidad.PROG_ARTICULO_ACTUALIZA(articulo.CODIGO_ARTICULO, 
                    articulo.NOMBRE_ARTICULO, 
                    articulo.NOMBRE_CORTO, 
                    articulo.DESCRIPCION, 
                    articulo.CODIGO_CATEGORIA, 
                    articulo.CLASIFICACION1,
                    articulo.CLASIFICACION2,
                    articulo.CLASIFICACION3,
                    articulo.CLASIFICACION4,
                    articulo.PRESENTACION_BASE,
                    articulo.PERMITE_VENTA,
                    articulo.PERMITE_COMPRA,
                    articulo.CAMBIAR_DESCRIPCION, 
                    articulo.CONSULTAR_PRECIO,
                    articulo.PAGA_IMPUESTO, 
                    articulo.PRECIO_VENTA, 
                    articulo.MANEJA_INVENTARIO,
                    articulo.INVENTARIO_MINIMO,
                    articulo.INVENTARIO_MAXIMO,
                    resultado, mensaje);
                    


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

        public ResultadoTransaccion borrarRegistro(string codigoArticulo)
        {
            try
            {
                PERFECTEntities entidad = new PERFECTEntities();
                System.Data.Entity.Core.Objects.ObjectParameter resultado = new System.Data.Entity.Core.Objects.ObjectParameter("RESULTADO", typeof(string));
                System.Data.Entity.Core.Objects.ObjectParameter mensaje = new System.Data.Entity.Core.Objects.ObjectParameter("MENSAJE", typeof(string));


                entidad.PROG_ARTICULO_BORRAR(codigoArticulo, resultado, mensaje);


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
