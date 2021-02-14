
using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Domain.Repositories;
using MgpTechTickets.Models;
using MgpTechTickets.Services.interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.service
{
    public class AmbienteService : IAmbienteService
    {

        private readonly IAmbienteRepository _ambienteRepository;

        public AmbienteService(IAmbienteRepository ambienteRepository)
        {
            _ambienteRepository = ambienteRepository;
        }

        public void Create(Ambiente entity)
        {
            _ambienteRepository.Create(entity);
        }

        public async Task<IEnumerable<Ambiente>> FindAllAsync()
        {
            return await _ambienteRepository.FindAllAsync();
        }

        public async Task<Ambiente> FindByIdAsync(int id)
        {
            return await _ambienteRepository.FindByIdAsync(id);
        }

        public bool SaveChanges()
        {
            return _ambienteRepository.SaveChanges();
        }

        public void Update(int id, Ambiente entity)
        {
            _ambienteRepository.Update(id, entity);
        }
    }
}
