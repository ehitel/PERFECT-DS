//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DS.Logica
{
    using System;
    using System.Collections.Generic;
    
    public partial class ARTICULO_CATEGORIA
    {
        public ARTICULO_CATEGORIA()
        {
            this.ARTICULO = new HashSet<ARTICULO>();
        }
    
        public string CODIGO_CATEGORIA { get; set; }
        public string NOMBRE_CATEGORIA { get; set; }
    
        public virtual ICollection<ARTICULO> ARTICULO { get; set; }
    }
}
