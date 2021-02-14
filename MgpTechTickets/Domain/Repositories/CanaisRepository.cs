

using MgpTechTickets.Data;
using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Domain.Repositories
{
    public class CanaisRepository : ICanaisRepository
    {
        private readonly DataContext _dataContext;

        public CanaisRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }       

        public async Task<IEnumerable<CanaisComunicacao>> FindAllAsync()
        {
            IQueryable<CanaisComunicacao> query = _dataContext.Canais;

            query = query.AsNoTracking().OrderBy(a => a.Id);

            return await query.ToArrayAsync();
        }

        public async Task<CanaisComunicacao> FindByIdAsync(int id)
        {
            return await _dataContext.Canais.FindAsync(id);
        }

        public void Create(CanaisComunicacao entity)
        {
            _dataContext.Add(entity);
        }

        public void Update(int id, CanaisComunicacao entity)
        {
            if (id > 0)
            {
                var OldCanal = _dataContext.Canais.AsNoTracking().FirstOrDefault(a => a.Id == id);
                if (OldCanal != null)
                {
                    _dataContext.Update(entity);
                }
            }
        }

        public bool SaveChanges()
        {
            return (_dataContext.SaveChanges() > 0);
        }
    }
}
