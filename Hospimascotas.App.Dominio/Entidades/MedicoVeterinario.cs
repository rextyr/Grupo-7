namespace Hospimascotas.App.Dominio
{
    public class MedicoVeterinario :  Persona
    {
        public int Codigo { get; set; }
        public string Especialidad { get; set; }
        public int TarjetaProfesional { get; set; }
        public  System.Collections.Generic.List<MascotaEnferma> MascotasAsignadas { get; set; }
        public AuxiliarVeterinario AuxiliarAyudante { get; set; }
        
    }
}