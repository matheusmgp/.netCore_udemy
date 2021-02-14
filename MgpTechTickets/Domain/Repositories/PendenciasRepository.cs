

using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MgpTechTickets.Domain.Repositories
{
    public class PendenciasRepository : IPendenciasRepository
    {
        public void Create(Pendencia entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Pendencia>> FindAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Pendencia> FindByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, Pendencia entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
