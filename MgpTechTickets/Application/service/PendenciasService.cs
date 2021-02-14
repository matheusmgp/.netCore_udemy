using MgpTechTickets.Models;
using MgpTechTickets.Services.interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MgpTechTickets.Application.service
{
    public class PendenciasService : IPendenciasService
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
