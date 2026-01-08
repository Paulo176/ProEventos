using ProEventos.Domain;
using System;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    
    public interface IEventoPersist
    {
       //EVENTOS
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);
        Task<Evento> GetEventosByIdAsync(int eventoId , bool includePalestrantes = false);

    }
} 

