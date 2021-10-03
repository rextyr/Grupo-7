using System;
using Hospimascotas.App.Dominio;
using Hospimascotas.App.Persistencia;
using System.Collections.Generic;


namespace Hospimascotas.App.Consola
{
    class Program
    {

       private static IRepositorioMascotas _reporteMascota = new RepositorioMascotas (new Persistencia.AppContext());
       private static IRepositorioSignosVitales _reporteSignosVitales = new RepositorioSignosVitales (new Persistencia.AppContext());
        private static IRepositorioSugerenciaCuidado _reporteSugerenciaCuidado = new RepositorioSugerenciaCuidado (new Persistencia.AppContext());
        private static IRepositorioPersonas _reportePersonas = new RepositorioPersonas (new Persistencia.AppContext());
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
              peludoenfermo.IdMedicoVeterinario=1;

            var MedicoRaul = new MedicoVeterinario();
               MedicoRaul.Nombre= "Raul";
               MedicoRaul.Apellido= "Enrique";
               MedicoRaul.Numero=310187478;
               MedicoRaul.Genero= Genero.masculino; 
               MedicoRaul.Codigo= 784545;
               MedicoRaul.Especialidad="Perros";
               MedicoRaul.TarjetaProfesional= 89745612;
               List<MascotaEnferma> ListasMascotas=new List<MascotaEnferma>();
               MedicoRaul.MascotasAsignadas= ListasMascotas ;
               MedicoRaul.MascotasAsignadas.Add(peludoenfermo);


               var peludoimpostor = new MascotaEnferma();
              peludoimpostor.Id=4;
              peludoimpostor.Nombre="Camilo";
              peludoimpostor.Color= "Negro";
              peludoimpostor.Edad= 7;
              peludoimpostor.Genero= Genero.masculino;
              peludoimpostor.TipoMascota= "Gato";
              peludoimpostor.Raza= "Siames";
              peludoimpostor.Direccion= "mz 19 cs 128";
              peludoimpostor.Latitud= 24.000F;
              peludoimpostor.Longitud= -72.8894546F;
              peludoimpostor.Ciudad= "Cali" ;
              peludoimpostor.IdMedicoVeterinario=1;
                 
             
                 
        }


        private static void AddMascota(MascotaEnferma peludoenfermo)
        {
  
                _reporteMascota.AddMascotaEnferma(peludoenfermo);
                Console.WriteLine("se ha guardado el registro");
        }

        public static void DeleteMascota(int id)
        {
             _reporteMascota.DeleteMascotaEnferma(id);
             Console.WriteLine("se ha eliminado el registro");
        }


        public static void AgregarMedico(MedicoVeterinario medico){

          _reportePersonas.AddPersona(medico);
           Console.WriteLine("se ha guardado el registro");
        }
        
        public static void UpdateMascotaEnferma(MascotaEnferma peludoimpostor)
        {
           _reporteMascota.DeleteMascotaEnferma(peludoimpostor.Id);
           var MascotaNueva=_reporteMascota.UpdateMascotaEnferma(peludoimpostor);
           _reporteMascota.AddMascotaEnferma(MascotaNueva);
          Console.WriteLine("se ha Cambiado el registro");
        }

        public static void getMascota(int idMascotaEnferma)
        {
           var  peludoEncontrado=_reporteMascota.GetMascotaEnferma(idMascotaEnferma);
            Console.WriteLine("el nombre de la mascota es"+"  "+peludoEncontrado.Nombre+"  "+"la edad de la mascotas es"+"   "+ peludoEncontrado.Edad );
        }
        
    }
}

