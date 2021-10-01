using System.Collections.Generic;
using Hospimascotas.App.Dominio;
using System.Linq;


namespace Hospimascotas.App.Persistencia
{
    public class RepositorioHistoria:IRepositorioHistoria
    {

         private readonly AppContext _appContext;

        public RepositorioHistoria(AppContext appContext)
        {
            _appContext = appContext;
        }   
        
        Historia IRepositorioHistoria.AddHistoria(Historia historia)
        {
          var historiadicionada = _appContext.Historias.Add(historia);
          _appContext.SaveChanges();
          return historiadicionada.Entity;

        }   
         void IRepositorioHistoria.DeleteHistoria(int idHistoria)
        {
            var historiadicionada = _appContext.Historias.FirstOrDefault( p => p.Id==idHistoria);
           if (historiadicionada==null)
              return;
            _appContext.Historias.Remove(historiadicionada);
             _appContext.SaveChanges();
        }
         IEnumerable<Historia> IRepositorioHistoria.GetAllHistoria()
        {
            return _appContext.Historias;
        }
         Historia IRepositorioHistoria.GetHistoria(int idHistoria)
        {
             return _appContext.Historias.FirstOrDefault( p => p.Id==idHistoria);
          
        }
        Historia IRepositorioHistoria.UpdateHistoria(Historia historia)
        {
           var historiadicionada = _appContext.Historias.FirstOrDefault( p => p.Id==historia.Id);
           if (historiadicionada==null)
           {
               historiadicionada.Diagnostico=historia.Diagnostico;
               historiadicionada.Entorno=historia.Entorno;
               historiadicionada.SugerenciasdeCuidado=historia.SugerenciasdeCuidado;

               _appContext.SaveChanges();
           }

           return historiadicionada;
        }
    }
}