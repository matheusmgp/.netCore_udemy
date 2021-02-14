

using MgpTechTickets.Models;
using MgpTechTickets.Services.interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.service
{
    public class ClientesService : IClientesService
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
