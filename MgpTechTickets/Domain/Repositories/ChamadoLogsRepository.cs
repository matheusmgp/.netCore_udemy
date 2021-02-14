

using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MgpTechTickets.Domain.Repositories
{
    public class ChamadoLogsRepository : IChamadoLogsRepository
    {
        public void Create(ChamadoLog entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ChamadoLog>> FindAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ChamadoLog> FindByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, ChamadoLog entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
