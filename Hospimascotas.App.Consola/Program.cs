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
              peludoenfermo.Color= "gris";
              peludoenfermo.Edad= 7;
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


               var peludoimpostor = new MascotaEnferma(){
              Id=6,
              Nombre="Camilo",
              Color= "Negro",
              Edad= 7,
              Genero= Genero.masculino,
              TipoMascota= "Gato",
              Raza= "Siames",
              Direccion= "mz 19 cs 128",
              Latitud= 24.000F,
              Longitud= -72.8894546F,
              Ciudad= "Cali" ,
              
               };   
            
            DeleteMascota(5);
            UpdateMascotaEnferma(peludoimpostor);
                 
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
           
           var MascotaNueva=_reporteMascota.UpdateMascotaEnferma(peludoimpostor);
          Console.WriteLine("se ha Cambiado el registro");
        }

        public static void getMascota(int idMascotaEnferma)
        {
           var  peludoEncontrado=_reporteMascota.GetMascotaEnferma(idMascotaEnferma);
            Console.WriteLine("el nombre de la mascota es"+"  "+peludoEncontrado.Nombre+"  "+"la edad de la mascotas es"+"   "+ peludoEncontrado.Edad );
        }

        
        
    }
}

