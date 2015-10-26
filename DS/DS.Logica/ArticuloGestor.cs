using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Logica
{
    public class ArticuloGestor
    {
        public List<ARTICULO_CONSULTA> obtenerCatalogoPresentaciones(string codigoArticulo, string nombreArticulo)
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
    }
}
