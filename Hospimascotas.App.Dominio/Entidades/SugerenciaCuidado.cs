using System;

namespace Hospimascotas.App.Dominio
{
    public class SugerenciaCuidado
    {
        public int Id { get; set; }
        public string FechaHora { get; set; }
        public string Descripcion { get; set; }
        public int HistoriaId { get; set; }
        public int AuxiliarVeterinario.Id { get; set;}
         
    
        
        
    }
}