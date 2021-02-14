using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MgpTechTickets.Domain.Repositories
{
    public class ChamadosRepository : IChamadosRepository
    {
        public void Create(Chamado entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Chamado>> FindAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Chamado> FindByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, Chamado entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
