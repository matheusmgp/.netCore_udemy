using MgpTechTickets.Models;
using MgpTechTickets.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.service
{
    public class ChamadoLogsService : IChamadoLogsService
    {
        public void Create(ChamadoLog entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ChamadoLog>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ChamadoLog> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, ChamadoLog entity)
        {
            throw new NotImplementedException();
        }
    }
}
