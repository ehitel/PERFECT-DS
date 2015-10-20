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
    }
}
