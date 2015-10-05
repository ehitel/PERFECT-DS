using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Logica.Seguridad
{
    public class Permisos
    {

        public List<PERMISO_USUARIO_MODULO> obetenerPermisoUsuarioModulo(string CODIGO_USUARIO, 
            string CODIGO_MODULO, string DESCRIPCION)
        {
            PERFECTEntities entity = new PERFECTEntities();

            return entity.SEGURIDAD_OBTENER_PERMISOS_USUARIO_MODULO(CODIGO_USUARIO, CODIGO_MODULO, DESCRIPCION).ToList();
            
        }

    }
}
