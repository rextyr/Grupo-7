using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospimascotas.App.Dominio;
using Hospimascotas.App.Persistencia;

namespace Hospimascotas.App.Frontend.Pages
{
    public class ListaMascotasModel : PageModel
    {

         private readonly IRepositorioMascotas _repoMascotas;
        
         public IEnumerable<MascotaEnferma> MascotasEnfermas {get ; set;}

        public ListaMascotasModel(IRepositorioMascotas _repoMascotas)
         {
             this._repoMascotas=_repoMascotas;
         }

        
        
        public void  OnGet()
        {
            MascotasEnfermas=_repoMascotas.GetAllMascotasEnfermas();
            
        }
    }
}
