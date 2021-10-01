namespace Hospimascotas.App.Dominio
{
    public class SignosVitales
    {
        public int Id { get; set; }
        public string FechaHora { get; set; }
        public TipoSigno Signo { get; set; }
        public int Valor { get; set; }
        public int MascotaEnfermaId { get; set; }
        
        
        
        
        
        
        
        
    }
}