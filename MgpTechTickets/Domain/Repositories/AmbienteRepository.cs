using MgpTechTickets.Data;
using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Domain.Repositories
{
    public class AmbienteRepository : IAmbienteRepository
    {
        private readonly DataContext _dataContext;

        public AmbienteRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public async Task<IEnumerable<Ambiente>> FindAllAsync()
        {
            IQueryable<Ambiente> query = _dataContext.Ambientes;

            query = query.AsNoTracking().OrderBy(a => a.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Ambiente> FindByIdAsync(int id)
        {
            return await _dataContext.Ambientes.FindAsync(id);
        }

        public bool SaveChanges()
        {
            return (_dataContext.SaveChanges() > 0);
        }

        public void Update(int id, Ambiente entity)
        {
            if (id > 0)
            {
                var OldAmbiente = _dataContext.Ambientes.AsNoTracking().FirstOrDefault(a => a.Id == id);
                if (OldAmbiente != null)
                {
                    _dataContext.Update(entity);
                }
            }

        }
        public async void Create(Ambiente entity)
        {            
            _dataContext.Add(entity);
        }
    }
}
