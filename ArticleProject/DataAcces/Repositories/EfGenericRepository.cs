using DataAcces.Context;
using DataAcces.Interfaces;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Repositories
{
    public class EfGenericRepository<Tentity> : IGenericDal<Tentity> where Tentity : class,  IEntity ,new()
    {

        private readonly DataContext _context;

        public EfGenericRepository(DataContext context)
        {
            _context = context;
        }


        public async Task AddAsync(Tentity tentity)
        {
           await _context.AddAsync(tentity);

            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(Tentity tentity)
        {
            _context.Remove(tentity);

            await _context.SaveChangesAsync();
        }

        public async Task<List<Tentity>> GetAllAsync()
        {
            return await _context.Set<Tentity>().ToListAsync();
        }

        public async Task<Tentity> GetByIdAsync(int id)
        {
            return await _context.Set<Tentity>().FindAsync(id);
        }

        public async Task<Tentity> GetByNameAsync(string id)
        {
            return await _context.Set<Tentity>().FindAsync(id);
        }


        public async Task UpdateAsync(Tentity tentity)
        {
            _context.Update(tentity);

            await _context.SaveChangesAsync();
        }
    }
}
