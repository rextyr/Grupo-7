using System;
using System.Collections;

namespace Hospimascotas.App.Dominio
{
    public class AuxiliarVeterinario : Persona
    {
        public int NoCertificado { get; set; }
        public int  HorasLaborales { get; set; }
        public int MedicoVeterinarioId { get; set; }
        public  System.Collections.Generic.List<Historia> HistoriasEncargadas { get; set; }
        
        
        
        
        
        
        
    }
}