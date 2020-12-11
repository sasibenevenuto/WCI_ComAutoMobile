using Model.Models.General;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.General
{
    public interface IRepository<TEntity> where TEntity : BaseModel
    {
        Task<TEntity> Add(TEntity entity, string query);
        Task Delete(string query);
        Task<List<TEntity>> GetList(TEntity entity, string query);
        Task<int> GetListCount(TEntity entity, string query);
        Task<TEntity> Update(TEntity entity, string query);
    }
}
