using System.Collections.Generic;
using Hospimascotas.App.Dominio;
using System.Linq;

namespace Hospimascotas.App.Persistencia
{
    public class RepositorioMascotas : IRepositorioMascotas
    {
         private readonly AppContext _appContext;

        public RepositorioMascotas(AppContext appContext)
        {
            _appContext = appContext;
        }
                  
    MascotaEnferma IRepositorioMascotas.AddMascotaEnferma(MascotaEnferma mascotaEnferma)
        {
          var mascotaEnfermaadicionada = _appContext.MascotasEnfermas.Add(mascotaEnferma);
          _appContext.SaveChanges();
          return mascotaEnfermaadicionada.Entity;

        }   
         void IRepositorioMascotas.DeleteMascotaEnferma(int idMascotaEnferma)
        {
            var mascotaEnfermaadicionada = _appContext.MascotasEnfermas.FirstOrDefault( p => p.Id==idMascotaEnferma);
           if (mascotaEnfermaadicionada==null)
              return;
            _appContext.MascotasEnfermas.Remove(mascotaEnfermaadicionada);
             _appContext.SaveChanges();
        }
         IEnumerable<MascotaEnferma> IRepositorioMascotas.GetAllMascotasEnfermas()
        {
            return _appContext.MascotasEnfermas;
        }
         MascotaEnferma IRepositorioMascotas.GetMascotaEnferma(int idMascotaEnferma)
        {
             return _appContext.MascotasEnfermas.FirstOrDefault( p => p.Id==idMascotaEnferma);
          
        }
        MascotaEnferma IRepositorioMascotas.UpdateMascotaEnferma(MascotaEnferma mascotaEnferma)
        {
           var mascotaEnfermaadicionada = _appContext.MascotasEnfermas.FirstOrDefault( p => p.Id==mascotaEnferma.Id);
           if (mascotaEnfermaadicionada==null)
           {
               mascotaEnfermaadicionada.Nombre=mascotaEnferma.Nombre;
               mascotaEnfermaadicionada.Color=mascotaEnferma.Color;
               mascotaEnfermaadicionada.Edad=mascotaEnferma.Edad;
               mascotaEnfermaadicionada.Genero=mascotaEnferma.Genero;
               mascotaEnfermaadicionada.TipoMascota=mascotaEnferma.TipoMascota;
               mascotaEnfermaadicionada.Raza=mascotaEnferma.Raza;
               mascotaEnfermaadicionada.Direccion=mascotaEnferma.Direccion;
               mascotaEnfermaadicionada.Latitud=mascotaEnferma.Latitud;
               mascotaEnfermaadicionada.Longitud=mascotaEnferma.Longitud;
               mascotaEnfermaadicionada.Ciudad=mascotaEnferma.Ciudad;
               mascotaEnfermaadicionada.IdMedicoVeterinario=mascotaEnferma.IdMedicoVeterinario;
               mascotaEnfermaadicionada.IdAuxiliarVeterinario=mascotaEnferma.IdAuxiliarVeterinario;
               mascotaEnfermaadicionada.DueñoEncargado=mascotaEnferma.DueñoEncargado;
               mascotaEnfermaadicionada.HistoriaMedica=mascotaEnferma.HistoriaMedica;
               mascotaEnferma.RegistrodeSignos=mascotaEnferma.RegistrodeSignos;
               _appContext.SaveChanges();
           }

           return mascotaEnfermaadicionada;

        }
    

    }
}    