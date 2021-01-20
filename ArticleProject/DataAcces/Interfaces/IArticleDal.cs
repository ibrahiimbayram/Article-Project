using Entity;
using Entity.Tables;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Interfaces
{
    public interface IArticleDal : IGenericDal<Article> ,IEntity
    {
        Task<Article> GetByName(string title);
    }
}
