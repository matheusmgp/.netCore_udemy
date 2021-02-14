

using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MgpTechTickets.Domain.Repositories
{
    public class FiliaisRepository : IFiliaisRepository
    {
        public void Create(Filial entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Filial>> FindAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Filial> FindByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, Filial entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
