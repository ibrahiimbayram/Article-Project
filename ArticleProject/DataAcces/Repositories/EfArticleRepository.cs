using DataAcces.Context;
using DataAcces.Interfaces;
using Entity;
using Entity.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Repositories
{
    public class EfArticleRepository : EfGenericRepository<Article>, IArticleDal ,IEntity
    {
        private readonly DataContext _context;

        public EfArticleRepository(DataContext context):base(context)
        {
            _context = context;
        }

        public async Task<Article> GetByName(string title)
        {
            return await _context.Articles.Where(I => I.Title.Contains(title)).FirstOrDefaultAsync();
        }

    }
}
