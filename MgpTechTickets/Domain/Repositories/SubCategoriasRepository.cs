

using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MgpTechTickets.Domain.Repositories
{
    public class SubCategoriasRepository : ISubCategoriasRepository
    {
        public void Create(SubCategorias entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<SubCategorias>> FindAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<SubCategorias> FindByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, SubCategorias entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
