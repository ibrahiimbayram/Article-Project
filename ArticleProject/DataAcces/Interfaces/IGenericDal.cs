using Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Interfaces
{
    public interface IGenericDal<Tentity> where Tentity : class, IEntity ,new()
    {
        Task<List<Tentity>> GetAllAsync();

        Task<Tentity> GetByIdAsync(int id);
        Task<Tentity> GetByNameAsync(string id);

        Task AddAsync(Tentity tentity);
        Task UpdateAsync(Tentity tentity);

        Task DeleteAsync(Tentity tentity);

    }
}
