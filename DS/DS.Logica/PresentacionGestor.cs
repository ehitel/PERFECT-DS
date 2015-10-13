using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Logica
{
   public  class PresentacionGestor
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

    }
}
