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
    
    public partial class ARTICULO_CONSULTA
    {
        public string CODIGO_ARTICULO { get; set; }
        public string NOMBRE_ARTICULO { get; set; }
        public string NOMBRE_CORTO { get; set; }
        public string DESCRIPCION { get; set; }
        public string CODIGO_CATEGORIA { get; set; }
        public string NOMBRE_CATEGORIA { get; set; }
        public string CLASIFICACION1 { get; set; }
        public string CLASIFICACION2 { get; set; }
        public string CLASIFICACION3 { get; set; }
        public string CLASIFICACION4 { get; set; }
        public string PRESENTACION_BASE { get; set; }
        public string NOMBRE_PRESENTACION { get; set; }
        public bool PERMITE_VENTA { get; set; }
        public bool PERMITE_COMPRA { get; set; }
        public bool CAMBIAR_DESCRIPCION { get; set; }
        public bool CONSULTAR_PRECIO { get; set; }
        public bool PAGA_IMPUESTO { get; set; }
        public decimal PRECIO_VENTA { get; set; }
        public int INVENTARIO_MINIMO { get; set; }
        public int INVENTARIO_MAXIMO { get; set; }
        public bool MANEJA_INVENTARIO { get; set; }
    }
}
