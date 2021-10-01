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
            DeleteMascota(1);
        }


        private static void AddMascota()
        {
            var peludoenfermo = new MascotaEnferma();
              peludoenfermo.Nombre="Pepe";
              peludoenfermo.Color= "Cafe";
              peludoenfermo.Edad= 8;
              peludoenfermo.Genero= Genero.masculino;
              peludoenfermo.TipoMascota= "Perro";
              peludoenfermo.Raza= "Criollo";
              peludoenfermo.Direccion= "mz 19 cs 128";
              peludoenfermo.Latitud= 24.000F;
              peludoenfermo.Longitud= -72.8894546F;
              peludoenfermo.Ciudad= "Cali" ;
              //Ejemplo de Relacion Uno a Uno
              Dueño pepe = new Dueño();
              pepe.Correo="pepe@gmail.com";
              peludoenfermo.DueñoEncargado=pepe;
             //Relacion Uno a Muchos
              Historia historiadePeludo = new Historia();
              historiadePeludo.Diagnostico= "Ja quien sabe yo me fui a almorzar";
              historiadePeludo.Entorno="Casa de Pepe";
              historiadePeludo.SugerenciasdeCuidado = new System.Collections.Generic.List<SugerenciaCuidado>(); 
              //aqui en la ultima parte se le tendria que colocar un registro de una sugerencia
              //pero se puede dejar vacio cuando se agrege creo que se llamara  SugerenciasdeCuidado.Add(aqui dentro el objeto de sugerencia de cuidado)
              

              peludoenfermo.RegistrodeSignos=  new System.Collections.Generic.List<SignosVitales>();

                _reporteMascota.AddMascotaEnferma(peludoenfermo);
        }

        public static void DeleteMascota(int id)
        {
             _reporteMascota.DeleteMascotaEnferma(id);
             
        }
    }
}
