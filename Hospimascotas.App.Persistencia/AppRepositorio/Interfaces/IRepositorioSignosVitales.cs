using System.Collections.Generic;
using Hospimascotas.App.Dominio;
using System.Linq;


namespace Hospimascotas.App.Persistencia
{
    public interface IRepositorioSignosVitales
    {
        IEnumerable<SignosVitales> GetAllSignosVitales();
        SignosVitales AddSignosVitales(SignosVitales signo);
        SignosVitales UpdateSignosVitales(SignosVitales signo);
        void DeleteSignosVitales (int idSignosVitales);
        SignosVitales GetSignosVitales(int idSignosVitales);
    }
}