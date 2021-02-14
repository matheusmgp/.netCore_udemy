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
    public class AgendasRepository : IAgendaRepository
    {
        private readonly DataContext _dataContext;

        public AgendasRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
                     

        public async Task<IEnumerable<Agenda>> FindAllAsync()
        {
            IQueryable<Agenda> query =  _dataContext.Agendas;

            query =  query.AsNoTracking().OrderBy(a => a.Id);

            return  await query.ToArrayAsync();
        }

        public async Task<Agenda> FindByIdAsync(int id)
        {
            return  await _dataContext.Agendas.FindAsync(id);
        }

        public bool SaveChanges()
        {
           return ( _dataContext.SaveChanges() > 0) ;
        }

        public void Update(int id, Agenda entity) 
        {
            if (id > 0)
            {
                var OldAgenda = _dataContext.Agendas.AsNoTracking().FirstOrDefault(a => a.Id == id);
                if(OldAgenda != null)
                {
                    _dataContext.Update(entity);
                }
            }
           

            
        }

        public async void Create(Agenda entity)
        {
            
           // var ambiente = await _dataContext.Ambientes.FindAsync(entity.AmbienteId).ConfigureAwait(true);

           // entity.Ambiente = ambiente;

            _dataContext.Add(entity);
        }
    }
}
