﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PERFECTEntities : DbContext
    {
        public PERFECTEntities()
            : base("name=PERFECTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PRESENTACION> PRESENTACION { get; set; }
        public virtual DbSet<ARTICULO_CATEGORIA> ARTICULO_CATEGORIA { get; set; }
        public virtual DbSet<ARTICULO> ARTICULO { get; set; }
    
        public virtual ObjectResult<PERMISO_USUARIO_MODULO> SEGURIDAD_OBTENER_PERMISOS_USUARIO_MODULO(string cODIGO_USUARIO, string cODIGO_MODULO, string dESCRIPCION)
        {
            var cODIGO_USUARIOParameter = cODIGO_USUARIO != null ?
                new ObjectParameter("CODIGO_USUARIO", cODIGO_USUARIO) :
                new ObjectParameter("CODIGO_USUARIO", typeof(string));
    
            var cODIGO_MODULOParameter = cODIGO_MODULO != null ?
                new ObjectParameter("CODIGO_MODULO", cODIGO_MODULO) :
                new ObjectParameter("CODIGO_MODULO", typeof(string));
    
            var dESCRIPCIONParameter = dESCRIPCION != null ?
                new ObjectParameter("DESCRIPCION", dESCRIPCION) :
                new ObjectParameter("DESCRIPCION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PERMISO_USUARIO_MODULO>("SEGURIDAD_OBTENER_PERMISOS_USUARIO_MODULO", cODIGO_USUARIOParameter, cODIGO_MODULOParameter, dESCRIPCIONParameter);
        }
    
        public virtual ObjectResult<PRESENTACION_CONSULTA> PROG_PRESENTACION_CONSULTA_GENERAL()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PRESENTACION_CONSULTA>("PROG_PRESENTACION_CONSULTA_GENERAL");
        }
    
        public virtual int PROG_PRESENTACION_ACTUALIZA(string cODIGO_PRESENTACION, string nOMBRE_PRESENTACION, ObjectParameter rESULTADO, ObjectParameter mENSAJE)
        {
            var cODIGO_PRESENTACIONParameter = cODIGO_PRESENTACION != null ?
                new ObjectParameter("CODIGO_PRESENTACION", cODIGO_PRESENTACION) :
                new ObjectParameter("CODIGO_PRESENTACION", typeof(string));
    
            var nOMBRE_PRESENTACIONParameter = nOMBRE_PRESENTACION != null ?
                new ObjectParameter("NOMBRE_PRESENTACION", nOMBRE_PRESENTACION) :
                new ObjectParameter("NOMBRE_PRESENTACION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROG_PRESENTACION_ACTUALIZA", cODIGO_PRESENTACIONParameter, nOMBRE_PRESENTACIONParameter, rESULTADO, mENSAJE);
        }
    
        public virtual ObjectResult<PRESENTACION_CONSULTA> PROG_PRESENTACION_CONSULTA_UNICO(string cODIGO_PRESENTACION)
        {
            var cODIGO_PRESENTACIONParameter = cODIGO_PRESENTACION != null ?
                new ObjectParameter("CODIGO_PRESENTACION", cODIGO_PRESENTACION) :
                new ObjectParameter("CODIGO_PRESENTACION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PRESENTACION_CONSULTA>("PROG_PRESENTACION_CONSULTA_UNICO", cODIGO_PRESENTACIONParameter);
        }
    
        public virtual int PROG_PRESENTACION_BORRAR(string cODIGO_PRESENTACION, ObjectParameter rESULTADO, ObjectParameter mENSAJE)
        {
            var cODIGO_PRESENTACIONParameter = cODIGO_PRESENTACION != null ?
                new ObjectParameter("CODIGO_PRESENTACION", cODIGO_PRESENTACION) :
                new ObjectParameter("CODIGO_PRESENTACION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROG_PRESENTACION_BORRAR", cODIGO_PRESENTACIONParameter, rESULTADO, mENSAJE);
        }
    
        public virtual int PROG_ARTICULO_CATEGORIA_ACTUALIZA(string cODIGO_CATEGORIA, string nOMBRE_CATEGORIA, ObjectParameter rESULTADO, ObjectParameter mENSAJE)
        {
            var cODIGO_CATEGORIAParameter = cODIGO_CATEGORIA != null ?
                new ObjectParameter("CODIGO_CATEGORIA", cODIGO_CATEGORIA) :
                new ObjectParameter("CODIGO_CATEGORIA", typeof(string));
    
            var nOMBRE_CATEGORIAParameter = nOMBRE_CATEGORIA != null ?
                new ObjectParameter("NOMBRE_CATEGORIA", nOMBRE_CATEGORIA) :
                new ObjectParameter("NOMBRE_CATEGORIA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROG_ARTICULO_CATEGORIA_ACTUALIZA", cODIGO_CATEGORIAParameter, nOMBRE_CATEGORIAParameter, rESULTADO, mENSAJE);
        }
    
        public virtual ObjectResult<CATEGORIA_CONSULTA> PROG_ARTICULO_CATEGORIA_CONSULTA_GENERAL()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CATEGORIA_CONSULTA>("PROG_ARTICULO_CATEGORIA_CONSULTA_GENERAL");
        }
    
        public virtual ObjectResult<CATEGORIA_CONSULTA> PROG_ARTICULO_CATEGORIA_CONSULTA_UNICO(string cODIGO_CATEGORIA)
        {
            var cODIGO_CATEGORIAParameter = cODIGO_CATEGORIA != null ?
                new ObjectParameter("CODIGO_CATEGORIA", cODIGO_CATEGORIA) :
                new ObjectParameter("CODIGO_CATEGORIA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CATEGORIA_CONSULTA>("PROG_ARTICULO_CATEGORIA_CONSULTA_UNICO", cODIGO_CATEGORIAParameter);
        }
    
        public virtual int PROG_ARTICULO_CATEGORIA_BORRAR(string cODIGO_CATEGORIA, ObjectParameter rESULTADO, ObjectParameter mENSAJE)
        {
            var cODIGO_CATEGORIAParameter = cODIGO_CATEGORIA != null ?
                new ObjectParameter("CODIGO_CATEGORIA", cODIGO_CATEGORIA) :
                new ObjectParameter("CODIGO_CATEGORIA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROG_ARTICULO_CATEGORIA_BORRAR", cODIGO_CATEGORIAParameter, rESULTADO, mENSAJE);
        }
    
        public virtual ObjectResult<ARTICULO_CONSULTA> PROG_ARTICULO_CONSULTA_GENERAL(string cODIGO_ARTICULO, string nOMBRE_ARTICULO)
        {
            var cODIGO_ARTICULOParameter = cODIGO_ARTICULO != null ?
                new ObjectParameter("CODIGO_ARTICULO", cODIGO_ARTICULO) :
                new ObjectParameter("CODIGO_ARTICULO", typeof(string));
    
            var nOMBRE_ARTICULOParameter = nOMBRE_ARTICULO != null ?
                new ObjectParameter("NOMBRE_ARTICULO", nOMBRE_ARTICULO) :
                new ObjectParameter("NOMBRE_ARTICULO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ARTICULO_CONSULTA>("PROG_ARTICULO_CONSULTA_GENERAL", cODIGO_ARTICULOParameter, nOMBRE_ARTICULOParameter);
        }
    
        public virtual ObjectResult<ARTICULO_CONSULTA> PROG_ARTICULO_CONSULTA_UNICO(string cODIGO_ARTICULO)
        {
            var cODIGO_ARTICULOParameter = cODIGO_ARTICULO != null ?
                new ObjectParameter("CODIGO_ARTICULO", cODIGO_ARTICULO) :
                new ObjectParameter("CODIGO_ARTICULO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ARTICULO_CONSULTA>("PROG_ARTICULO_CONSULTA_UNICO", cODIGO_ARTICULOParameter);
        }
    
        public virtual int PROG_ARTICULO_ACTUALIZA(string cODIGO_ARTICULO, string nOMBRE_ARTICULO, string nOMBRE_CORTO, string dESCRIPCION, string cODIGO_CATEGORIA, string cLASIFICACION1, string cLASIFICACION2, string cLASIFICACION3, string cLASIFICACION4, string pRESENTACION_BASE, Nullable<bool> pERMITE_VENTA, Nullable<bool> pERMITE_COMPRA, Nullable<bool> cAMBIAR_DESCRIPCION, Nullable<bool> cONSULTAR_PRECIO, Nullable<bool> pAGA_IMPUESTO, Nullable<decimal> pRECIO_VENTA, Nullable<bool> mANEJA_INVENTARIO, Nullable<int> iNVENTARIO_MINIMO, Nullable<int> iNVENTARIO_MAXIMO, ObjectParameter rESULTADO, ObjectParameter mENSAJE)
        {
            var cODIGO_ARTICULOParameter = cODIGO_ARTICULO != null ?
                new ObjectParameter("CODIGO_ARTICULO", cODIGO_ARTICULO) :
                new ObjectParameter("CODIGO_ARTICULO", typeof(string));
    
            var nOMBRE_ARTICULOParameter = nOMBRE_ARTICULO != null ?
                new ObjectParameter("NOMBRE_ARTICULO", nOMBRE_ARTICULO) :
                new ObjectParameter("NOMBRE_ARTICULO", typeof(string));
    
            var nOMBRE_CORTOParameter = nOMBRE_CORTO != null ?
                new ObjectParameter("NOMBRE_CORTO", nOMBRE_CORTO) :
                new ObjectParameter("NOMBRE_CORTO", typeof(string));
    
            var dESCRIPCIONParameter = dESCRIPCION != null ?
                new ObjectParameter("DESCRIPCION", dESCRIPCION) :
                new ObjectParameter("DESCRIPCION", typeof(string));
    
            var cODIGO_CATEGORIAParameter = cODIGO_CATEGORIA != null ?
                new ObjectParameter("CODIGO_CATEGORIA", cODIGO_CATEGORIA) :
                new ObjectParameter("CODIGO_CATEGORIA", typeof(string));
    
            var cLASIFICACION1Parameter = cLASIFICACION1 != null ?
                new ObjectParameter("CLASIFICACION1", cLASIFICACION1) :
                new ObjectParameter("CLASIFICACION1", typeof(string));
    
            var cLASIFICACION2Parameter = cLASIFICACION2 != null ?
                new ObjectParameter("CLASIFICACION2", cLASIFICACION2) :
                new ObjectParameter("CLASIFICACION2", typeof(string));
    
            var cLASIFICACION3Parameter = cLASIFICACION3 != null ?
                new ObjectParameter("CLASIFICACION3", cLASIFICACION3) :
                new ObjectParameter("CLASIFICACION3", typeof(string));
    
            var cLASIFICACION4Parameter = cLASIFICACION4 != null ?
                new ObjectParameter("CLASIFICACION4", cLASIFICACION4) :
                new ObjectParameter("CLASIFICACION4", typeof(string));
    
            var pRESENTACION_BASEParameter = pRESENTACION_BASE != null ?
                new ObjectParameter("PRESENTACION_BASE", pRESENTACION_BASE) :
                new ObjectParameter("PRESENTACION_BASE", typeof(string));
    
            var pERMITE_VENTAParameter = pERMITE_VENTA.HasValue ?
                new ObjectParameter("PERMITE_VENTA", pERMITE_VENTA) :
                new ObjectParameter("PERMITE_VENTA", typeof(bool));
    
            var pERMITE_COMPRAParameter = pERMITE_COMPRA.HasValue ?
                new ObjectParameter("PERMITE_COMPRA", pERMITE_COMPRA) :
                new ObjectParameter("PERMITE_COMPRA", typeof(bool));
    
            var cAMBIAR_DESCRIPCIONParameter = cAMBIAR_DESCRIPCION.HasValue ?
                new ObjectParameter("CAMBIAR_DESCRIPCION", cAMBIAR_DESCRIPCION) :
                new ObjectParameter("CAMBIAR_DESCRIPCION", typeof(bool));
    
            var cONSULTAR_PRECIOParameter = cONSULTAR_PRECIO.HasValue ?
                new ObjectParameter("CONSULTAR_PRECIO", cONSULTAR_PRECIO) :
                new ObjectParameter("CONSULTAR_PRECIO", typeof(bool));
    
            var pAGA_IMPUESTOParameter = pAGA_IMPUESTO.HasValue ?
                new ObjectParameter("PAGA_IMPUESTO", pAGA_IMPUESTO) :
                new ObjectParameter("PAGA_IMPUESTO", typeof(bool));
    
            var pRECIO_VENTAParameter = pRECIO_VENTA.HasValue ?
                new ObjectParameter("PRECIO_VENTA", pRECIO_VENTA) :
                new ObjectParameter("PRECIO_VENTA", typeof(decimal));
    
            var mANEJA_INVENTARIOParameter = mANEJA_INVENTARIO.HasValue ?
                new ObjectParameter("MANEJA_INVENTARIO", mANEJA_INVENTARIO) :
                new ObjectParameter("MANEJA_INVENTARIO", typeof(bool));
    
            var iNVENTARIO_MINIMOParameter = iNVENTARIO_MINIMO.HasValue ?
                new ObjectParameter("INVENTARIO_MINIMO", iNVENTARIO_MINIMO) :
                new ObjectParameter("INVENTARIO_MINIMO", typeof(int));
    
            var iNVENTARIO_MAXIMOParameter = iNVENTARIO_MAXIMO.HasValue ?
                new ObjectParameter("INVENTARIO_MAXIMO", iNVENTARIO_MAXIMO) :
                new ObjectParameter("INVENTARIO_MAXIMO", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROG_ARTICULO_ACTUALIZA", cODIGO_ARTICULOParameter, nOMBRE_ARTICULOParameter, nOMBRE_CORTOParameter, dESCRIPCIONParameter, cODIGO_CATEGORIAParameter, cLASIFICACION1Parameter, cLASIFICACION2Parameter, cLASIFICACION3Parameter, cLASIFICACION4Parameter, pRESENTACION_BASEParameter, pERMITE_VENTAParameter, pERMITE_COMPRAParameter, cAMBIAR_DESCRIPCIONParameter, cONSULTAR_PRECIOParameter, pAGA_IMPUESTOParameter, pRECIO_VENTAParameter, mANEJA_INVENTARIOParameter, iNVENTARIO_MINIMOParameter, iNVENTARIO_MAXIMOParameter, rESULTADO, mENSAJE);
        }
    
        public virtual int PROG_ARTICULO_BORRAR(string cODIGO_ARTICULO, ObjectParameter rESULTADO, ObjectParameter mENSAJE)
        {
            var cODIGO_ARTICULOParameter = cODIGO_ARTICULO != null ?
                new ObjectParameter("CODIGO_ARTICULO", cODIGO_ARTICULO) :
                new ObjectParameter("CODIGO_ARTICULO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROG_ARTICULO_BORRAR", cODIGO_ARTICULOParameter, rESULTADO, mENSAJE);
        }
    }
}
