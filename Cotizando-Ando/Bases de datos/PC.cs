//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Punto_de_venta.Bases_de_datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class PC
    {
        public PC()
        {
            this.Detalle_Venta_Tiempo = new HashSet<Detalle_Venta_Tiempo>();
        }
    
        public long IdPC { get; set; }
        public string Nombre { get; set; }
        public string Fila { get; set; }
        public string Columna { get; set; }
        public bool Estado { get; set; }
    
        public virtual ICollection<Detalle_Venta_Tiempo> Detalle_Venta_Tiempo { get; set; }
    }
}