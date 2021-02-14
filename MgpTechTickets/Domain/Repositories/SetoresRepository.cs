

using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MgpTechTickets.Domain.Repositories
{
    public class SetoresRepository : ISetoresRepository
    {
        public void Create(Setores entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Setores>> FindAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Setores> FindByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, Setores entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
