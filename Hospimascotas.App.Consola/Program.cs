using System;
using Hospimascotas.App.Dominio;
using Hospimascotas.App.Persistencia;
using System.Collections;


namespace Hospimascotas.App.Consola
{
    class Program
    {

       private static IRepositorioMascotas _reporteMascota = new RepositorioMascotas (new Persistencia.AppContext());
         private static IRepositorioSignosVitales _reporteSignosVitales = new RepositorioSignosVitales (new Persistencia.AppContext());

          private static IRepositorioSugerenciaCuidado _reporteSugerenciaCuidado = new RepositorioSugerenciaCuidado (new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             var peludoenfermo = new MascotaEnferma();
              peludoenfermo.Nombre="Pepe";
              peludoenfermo.Color= "Cafe";
              peludoenfermo.Edad= 88;
              peludoenfermo.Genero= Genero.masculino;
              peludoenfermo.TipoMascota= "Perro";
              peludoenfermo.Raza= "Criollo";
              peludoenfermo.Direccion= "mz 19 cs 128";
              peludoenfermo.Latitud= 24.000F;
              peludoenfermo.Longitud= -72.8894546F;
              peludoenfermo.Ciudad= "Cali" ;
            
        }


        private static void AddMascota(MascotaEnferma peludoenfermo)
        {
  
                _reporteMascota.AddMascotaEnferma(peludoenfermo);
        }

        public static void DeleteMascota(int id)
        {
             _reporteMascota.DeleteMascotaEnferma(id);
             
        }
    }
}
