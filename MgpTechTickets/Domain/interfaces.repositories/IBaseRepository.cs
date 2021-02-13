using MgpTechTickets.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Domain.interfaces.repositories
{
     public interface IBaseRepository<T>
    {
        Task<IEnumerable<T>> findAll();
        Task<T> findById(int id);
        void create<T>(T entity) where T : class;
        int delete(int id);
        void update<T>(int id, T entity) where T : class;
    }
}
