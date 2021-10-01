using System.Collections.Generic;
using Hospimascotas.App.Dominio;
using System.Linq;

namespace Hospimascotas.App.Persistencia
{
    public class RepositorioSugerenciaCuidado: IRepositorioSugerenciaCuidado
    {

        private readonly AppContext _appContext;

        public RepositorioSugerenciaCuidado(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        SugerenciaCuidado IRepositorioSugerenciaCuidado.AddSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado)
        {
          var sugerenciaAdicionada = _appContext.SugerenciasCuidado.Add(sugerenciaCuidado);
          _appContext.SaveChanges();
          return sugerenciaAdicionada.Entity;

        }   
         void IRepositorioSugerenciaCuidado.DeleteSugerenciaCuidado(int idSugerenciaCuidado)
        {
            var sugerenciaAdicionada= _appContext.SugerenciasCuidado.FirstOrDefault( p => p.Id==idSugerenciaCuidado);
           if (sugerenciaAdicionada==null)
              return;
            _appContext.SugerenciasCuidado.Remove(sugerenciaAdicionada);
             _appContext.SaveChanges();
        }
         IEnumerable<SugerenciaCuidado> IRepositorioSugerenciaCuidado.GetAllSugerenciaCuidado()
        {
            return _appContext.SugerenciasCuidado;
        }
         SugerenciaCuidado IRepositorioSugerenciaCuidado.GetSugerenciaCuidado(int idSugerencia)
        {
             return _appContext.SugerenciasCuidado.FirstOrDefault( p => p.Id==idSugerencia);
          
        }
        SugerenciaCuidado IRepositorioSugerenciaCuidado.UpdateSujerenciaCuidado(SugerenciaCuidado sugerenciaCuidado)
        {
           var sugerenciaAdicionada= _appContext.SugerenciasCuidado.FirstOrDefault( p => p.Id==sugerenciaCuidado.Id);
           if (sugerenciaAdicionada==null)
           {
               sugerenciaAdicionada.FechaHora=sugerenciaCuidado.FechaHora;
               sugerenciaAdicionada.Descripcion=sugerenciaCuidado.Descripcion;
               
               
               _appContext.SaveChanges();
           }

           return sugerenciaAdicionada;
        }

    }
}