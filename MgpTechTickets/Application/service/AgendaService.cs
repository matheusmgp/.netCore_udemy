
using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Domain.repositories;
using MgpTechTickets.Models;
using MgpTechTickets.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.service
{
    public class AgendaService : IAgendaService
    {

        private readonly IAgendaRepository _agendasRepository;

        public AgendaService(IAgendaRepository agendasRepository)
        {
            _agendasRepository = agendasRepository;
        }
      
        public async Task<IEnumerable<Agenda>> FindAllAsync()
        {
            return await _agendasRepository.FindAllAsync();
        }

        public async Task<Agenda> FindByIdAsync(int id)
        {
            return await _agendasRepository.FindByIdAsync(id);
        }

        public void Create(Agenda entity)
        {
            _agendasRepository.Create(entity);
        }           

        public void Update(int id, Agenda entity)
        {
            _agendasRepository.Update(id, entity);
        }
        public bool SaveChanges()
        {
            return _agendasRepository.SaveChanges();
        }
    }
}
