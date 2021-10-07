
using System.Collections.Generic;
using Hospimascotas.App.Dominio;
using System.Linq;


namespace Hospimascotas.App.Persistencia
{
    public class RepositorioPersonas : IRepositorioPersonas
    {
      private readonly AppContext _appContext;

        public RepositorioPersonas(AppContext appContext)
        {
            _appContext = appContext;
        }    

        Persona IRepositorioPersonas.AddPersona(Persona persona)
        {
          var personadicionada = _appContext.Personas.Add(persona);
          _appContext.SaveChanges();
          return personadicionada.Entity;

        }   
         void IRepositorioPersonas.DeletePersona(int idPersona)
        {
            var personadicionada = _appContext.Personas.FirstOrDefault( p => p.Id==idPersona);
           if (personadicionada==null)
              return;
            _appContext.Personas.Remove(personadicionada);
             _appContext.SaveChanges();
        }
         IEnumerable<Persona> IRepositorioPersonas.GetAllPersona()
        {
            return _appContext.Personas;
        }

          IEnumerable<Dueño> IRepositorioPersonas.GetAllDueño()
        {
            return _appContext.Dueños;
        }

          IEnumerable<MedicoVeterinario> IRepositorioPersonas.GetAllMedicoVeterinario()
        {
            return _appContext.MedicosVeterianarios;            
        }

         Persona IRepositorioPersonas.GetPersona(int idPersona)
        {
             return _appContext.Personas.FirstOrDefault( p => p.Id==idPersona);
          
        }
        Persona IRepositorioPersonas.UpdatePersona(Persona persona)
        {
           var personadicionada = _appContext.Personas.FirstOrDefault( p => p.Id==persona.Id);
           if (personadicionada!=null)
           {
               personadicionada.Nombre=persona.Nombre;
               personadicionada.Apellido=persona.Apellido;
               personadicionada.Numero=persona.Numero;
               personadicionada.Genero=persona.Genero;
               _appContext.SaveChanges();
           }

           return personadicionada;

        }

       Dueño IRepositorioPersonas.UpdateDueño(Dueño dueño)
       {
        var dueñoActualizado = _appContext.Dueños.FirstOrDefault( p => p.Id==dueño.Id);
           if (dueñoActualizado!=null)
           {
               dueñoActualizado.Correo=dueño.Correo;
               dueñoActualizado.MascotaEnfermaId=dueño.MascotaEnfermaId;
               _appContext.SaveChanges();
           }

           return dueñoActualizado;
       }
       
        MedicoVeterinario IRepositorioPersonas.UpdateMedicoVeterinario(MedicoVeterinario medicoVeterinario)
        {
          var medicoActualizado = _appContext.MedicosVeterianarios.FirstOrDefault( p => p.Id==medicoVeterinario.Id);
           if (medicoVeterinario!=null)
           {
               medicoActualizado.Codigo=medicoVeterinario.Codigo;
               medicoActualizado.Especialidad=medicoVeterinario.Especialidad;
               medicoActualizado.CetificadoVeterinario=medicoVeterinario.CetificadoVeterinario;
               medicoActualizado.MascotasAsignadas=medicoVeterinario.MascotasAsignadas;
               _appContext.SaveChanges();
           }

           return medicoActualizado;
        }

        AuxiliarVeterinario IRepositorioPersonas.UpdateAuxiliarVeterinario(AuxiliarVeterinario auxiliarVeterinario)
        {
         var auxiliarActualizado = _appContext.AuxiliaresVeterinarios.FirstOrDefault( p => p.Id==auxiliarVeterinario.Id);
         
           if (auxiliarActualizado!=null)
           {
              auxiliarActualizado.No_Certificado=auxiliarVeterinario.No_Certificado;
              auxiliarActualizado.HorasLaborales=auxiliarVeterinario.HorasLaborales;
              
               _appContext.SaveChanges();
           }
           return auxiliarActualizado;

        }
    }
}   