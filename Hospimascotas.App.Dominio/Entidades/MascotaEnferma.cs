using System;
using System.Collections;

namespace Hospimascotas.App.Dominio
{
    public class MascotaEnferma
    {
        public  int  Id { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }
        public int  Edad { get; set; }
        public Genero Genero { get; set; }
        public string TipoMascota { get; set; }
        public string Raza { get; set; }
        public string Direccion { get; set; }
        public float Latitud  { get; set; }
        public float  Longitud { get; set; }
        public string Ciudad { get; set; }

        public int MedicoVeterinarioId { get; set; }
        
        public Dueño DueñoEncargado { get; set; }
        public Historia HistoriaMedica { get; set; }
        public  System.Collections.Generic.List<SignosVitales> RegistrodeSignos { get; set; }

        

        
        
        
        
    }
}