using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospimascotas.App.Persistencia;
using Hospimascotas.App.Dominio;

namespace Hospimascotas.App.Frontend.Pages
{
    public class ListaHistoriasModel : PageModel
    {

        private readonly IRepositorioHistoria repositorioHistoria;

        public IEnumerable<Historia> Historias { get; set; }
        
        public ListaHistoriasModel(IRepositorioHistoria repositorioHistoria)
        {
            this.repositorioHistoria=repositorioHistoria;
        }
        public void OnGet()
        {

           Historias=repositorioHistoria.GetAllHistoria();
        }
    }
}
