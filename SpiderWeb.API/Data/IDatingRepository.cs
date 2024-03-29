using System.Collections.Generic;
using System.Threading.Tasks;
using SpiderWeb.API.Models;

namespace SpiderWeb.API.Data
{
    public interface IDatingRepository
    {
         

         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T:class;

         Task<bool> SaveAll();

         Task<IEnumerable<User>> GetUsers();

         Task<User> GetUser(int id);
    }
}