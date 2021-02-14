

using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MgpTechTickets.Domain.Repositories
{
    public class ClientesRepository : IClientesRepository
    {
        public void Create(Cliente entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Cliente>> FindAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Cliente> FindByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, Cliente entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
