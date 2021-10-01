using System.Collections.Generic;
using Hospimascotas.App.Dominio;
using System.Linq;


namespace Hospimascotas.App.Persistencia
{
    public interface IRepositorioPersonas
    {
        IEnumerable<Persona> GetAllPersona();
        IEnumerable<MedicoVeterinario> GetAllMedicoVeterinario();
        IEnumerable<Dueño> GetAllDueño();
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        Dueño UpdateDueño(Dueño dueño);
        MedicoVeterinario UpdateMedicoVeterinario(MedicoVeterinario medicoVeterinario);
        AuxiliarVeterinario UpdateAuxiliarVeterinario(AuxiliarVeterinario auxiliarVeterinario);
        void DeletePersona (int idPersona);
        Persona GetPersona(int idPersona);
    }
}