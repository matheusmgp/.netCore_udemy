

using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MgpTechTickets.Domain.Repositories
{
    public class RolesRepository : IRolesRepository
    {
        public void Create(Roles entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Roles>> FindAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Roles> FindByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, Roles entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
