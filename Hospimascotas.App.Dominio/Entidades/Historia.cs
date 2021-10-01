using System;
using System.Collections;

namespace Hospimascotas.App.Dominio
{
    public class Historia
    {
        public  int Id { get; set; }
        public string Diagnostico { get; set; }
        public string Entorno { get; set; }
        public int MascotaEnfermaId { get; set; }
        public System.Collections.Generic.List<SugerenciaCuidado> SugerenciasdeCuidado { get; set; }
       
       
        
        
        
        
        
    }
}