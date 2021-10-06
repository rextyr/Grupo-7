using System;
using System.Collections.Generic;

namespace Hospimascotas.App.Dominio
{
    public class MedicoVeterinario:Persona
    {
         public int Codigo { get; set; }
        public string Especialidad { get; set; }
        public int CetificadoVeterinario { get; set; }
        public System.Collections.Generic.List<MascotaEnferma> MascotasAsignadas  { get; set; }
        
        
    }
}