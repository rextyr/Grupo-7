using System.Collections.Generic;
using Hospimascotas.App.Dominio;
using System.Linq;


namespace Hospimascotas.App.Persistencia
{
    public class RepositorioSignosVitales:IRepositorioSignosVitales
    {
         private readonly AppContext _appContext;

        public RepositorioSignosVitales(AppContext appContext)
        {
            _appContext = appContext;
        }    
     SignosVitales IRepositorioSignosVitales.AddSignosVitales(SignosVitales signo)
        {
          var SignoaAdicionado = _appContext.SignosVitales.Add(signo);
          _appContext.SaveChanges();
          return SignoaAdicionado.Entity;

        }   
         void IRepositorioSignosVitales.DeleteSignosVitales(int idSignosVitales)
        {
            var SignoaAdicionado= _appContext.SignosVitales.FirstOrDefault( p => p.Id==idSignosVitales);
           if (SignoaAdicionado==null)
              return;
            _appContext.SignosVitales.Remove(SignoaAdicionado);
             _appContext.SaveChanges();
        }
         IEnumerable<SignosVitales> IRepositorioSignosVitales.GetAllSignosVitales()
        {
            return _appContext.SignosVitales;
        }
         SignosVitales IRepositorioSignosVitales.GetSignosVitales(int idSignosVitales)
        {
             return _appContext.SignosVitales.FirstOrDefault( p => p.Id==idSignosVitales);
          
        }
        SignosVitales IRepositorioSignosVitales.UpdateSignosVitales(SignosVitales signo)
        {
           var signoaAdicionado= _appContext.SignosVitales.FirstOrDefault( p => p.Id==signo.Id);
           if (signoaAdicionado!=null)
           {
               signoaAdicionado.FechaHora=signo.FechaHora;
               signoaAdicionado.Signo=signo.Signo;
               signoaAdicionado.Valor=signo.Valor;
               _appContext.SaveChanges();
           }

           return signoaAdicionado;
        }

    }
}