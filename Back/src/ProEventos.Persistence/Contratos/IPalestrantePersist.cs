using ProEventos.Domain;
using System;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    
    public interface IPalestrantePersist
    {
        //PALESTRANTES

        Task<Palestrante[]> GetAllPalestrantesByNomeAsync( string nome , bool includeEventos);
        Task<Palestrante[]> GetAllPalestranteAsync( bool includeEventos);
        Task<Palestrante> GetPalestranteByIdAsync( int palestranteId , bool includeEventos);
    }
} 

