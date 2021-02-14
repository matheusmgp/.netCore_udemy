
using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MgpTechTickets.Domain.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public void Create(Users entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Users>> FindAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Users> FindByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, Users entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
