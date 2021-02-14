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
    public class CategoriasRepository : ICategoriaRepository
    {

        private readonly DataContext _dataContext;

        public CategoriasRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<Categoria>> FindAllAsync()
        {
            IQueryable<Categoria> query = _dataContext.Categorias;

            query = query.AsNoTracking().OrderBy(a => a.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Categoria> FindByIdAsync(int id)
        {
            return await _dataContext.Categorias.FindAsync(id);
        }
      
        public void Update(int id, Categoria entity)
        {
            if (id > 0)
            {
                var OldCategorias = _dataContext.Categorias.AsNoTracking().FirstOrDefault(a => a.Id == id);
                if (OldCategorias != null)
                {
                    _dataContext.Update(entity);
                }
            }
        }

        public void Create(Categoria entity)
        {
            _dataContext.Add(entity);
        }

        public bool SaveChanges()
        {
            return (_dataContext.SaveChanges() > 0);
        }

    }
}
