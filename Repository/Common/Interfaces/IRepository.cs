using Model.Models.General;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Common.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseModel
    {
        //Task<TEntity> AddAsync(TEntity entity, string query);
        //Task DeleteAsync(TEntity entity, string query);
        //Task<List<TEntity>> GetListAsync(TEntity entity, string query);
        //Task<int> GetListCountAsync(TEntity entity, string query);
        //Task<TEntity> UpdateAsync(TEntity entity, string query);
    }
}
