using System.Collections.Generic;
using Hospimascotas.App.Dominio;
using System.Linq;

namespace Hospimascotas.App.Persistencia
{
    public interface IRepositorioSugerenciaCuidado
    {
           IEnumerable<SugerenciaCuidado> GetAllSugerenciaCuidado();
        SugerenciaCuidado AddSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado);
        SugerenciaCuidado UpdateSujerenciaCuidado(SugerenciaCuidado sugerenciCuidado);
        void DeleteSugerenciaCuidado (int idSugerenciaCuidado);
        SugerenciaCuidado GetSugerenciaCuidado(int idSugerenciaCuidado);      


    }
}