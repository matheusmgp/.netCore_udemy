using MgpTechTickets.Data;
using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Domain.Models;
using MgpTechTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Domain.repositories
{
    public class AgendasRepository : IBaseRepository<Agenda>
    {
        private readonly DataContext _dataContext;

        public AgendasRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void create<T>(T entity) where T : class
        {
             _dataContext.Add(entity);
        }

        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Agenda>> findAll()
        {
            IQueryable<Agenda> query =  _dataContext.Agendas;

            query = query.AsNoTracking().OrderBy(a => a.Id);

            return  query.ToArray();
        }

        public async Task<Agenda> findById(int id)
        {
            return await _dataContext.Agendas.FindAsync(id);
        }

        public void update<T>(int id, T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
