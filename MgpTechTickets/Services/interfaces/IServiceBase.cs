using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Services.interfaces
{
    public interface IServiceBase<Entity>
    {
        Task<IEnumerable<Entity>> FindAllAsync();
        Task<Entity> FindByIdAsync(int id);
        void Create(Entity entity);
        void Update(int id, Entity entity);
        bool SaveChanges();

    }
}
