using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Models;
using MgpTechTickets.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.service
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }       

        public async Task<IEnumerable<Categoria>> FindAllAsync()
        {
            return await _categoriaRepository.FindAllAsync();
        }

        public async Task<Categoria> FindByIdAsync(int id)
        {
            return await _categoriaRepository.FindByIdAsync(id);
        }

        public void Create(Categoria entity)
        {
            _categoriaRepository.Create(entity);
        }

        public void Update(int id, Categoria entity)
        {
            _categoriaRepository.Update(id,entity);
        }

        public bool SaveChanges()
        {
            return _categoriaRepository.SaveChanges();
        }
    }
}
