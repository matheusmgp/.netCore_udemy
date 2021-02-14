using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Models;
using MgpTechTickets.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.service
{
    public class CanaisService : ICanaisService
    {
        private readonly ICanaisRepository _canaisRepository;

        public CanaisService(ICanaisRepository canaisRepository)
        {
            _canaisRepository = canaisRepository;
        }

        public async Task<IEnumerable<CanaisComunicacao>> FindAllAsync()
        {
            return await _canaisRepository.FindAllAsync();
        }

        public async Task<CanaisComunicacao> FindByIdAsync(int id)
        {
            return await _canaisRepository.FindByIdAsync(id);
        }
        
        public void Create(CanaisComunicacao entity)
        {
            _canaisRepository.Create(entity);
        }

        public void Update(int id, CanaisComunicacao entity)
        {
            _canaisRepository.Update(id, entity);
        }

        public bool SaveChanges()
        {
            return _canaisRepository.SaveChanges();
        }
    }
}
