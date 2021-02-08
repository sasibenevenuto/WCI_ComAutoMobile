using Context;
using Dapper;
using Model.Models.General;
using Repository.General.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.General
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseModel
    {
        #region .:: Prorpiedades ::.        
        //public Settings _settings;

        public SolutionContext _db;

        #endregion

        #region .:: Construtor ::.
        public Repository(SolutionContext db)
        {
            _db = db;
        }

        #endregion

        #region .:: Crud ::.
        protected async Task<TEntity> AddAsync(TEntity entity, string query)
        {
            entity = BeforAdd(entity);
            using var con = new SqlConnection(_db.connectionString);
            try
            {
                con.Open();
                entity = await con.ExecuteScalarAsync<TEntity>(query, entity);
            }
            catch (Exception ex)
            {
                con.BeginTransaction().Rollback();
                throw new Exception(ex.InnerException.InnerException.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return entity;
        }

        protected async Task DeleteAsync(TEntity entity, string query)
        {
            using var con = new SqlConnection(_db.connectionString);
            try
            {
                con.Open();
                await con.ExecuteScalarAsync<TEntity>(query, entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        protected async Task<List<TEntity>> GetListAsync(TEntity entity, string query)
        {
            List<TEntity> entityList = new List<TEntity>();

            using var con = new SqlConnection(_db.connectionString);
            try
            {
                con.Open();

                entityList = (await con.QueryAsync<TEntity>(query)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return entityList;
        }

        protected async Task<int> GetListCountAsync(TEntity entity, string query)
        {
            int entityList = 0;
            using var con = new SqlConnection(_db.connectionString);
            try
            {
                con.Open();

                entityList = (await con.QueryAsync<TEntity>(query)).Count();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return entityList;
        }

        protected async Task<TEntity> UpdateAsync(TEntity entity, string query)
        {
            entity = BeforUpdate(entity);
            using var con = new SqlConnection(_db.connectionString);
            try
            {
                con.Open();
                entity = await con.ExecuteScalarAsync<TEntity>(query, entity);
            }
            catch (Exception ex)
            {
                con.BeginTransaction().Rollback();
                throw new Exception(ex.InnerException.InnerException.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return entity;
        }

        public void Dispose()
        {

        }
        #endregion

        #region .:: Methods Helpers ::.
        protected virtual TEntity BeforAdd(TEntity entity)
        {
            entity.Active = true;
            entity.CreateDate = DateTime.Now;
            entity.ModifieldDate = DateTime.Now;
            return entity;
        }

        protected virtual TEntity BeforUpdate(TEntity entity)
        {
            entity.ModifieldDate = DateTime.Now;
            return entity;
        }       

        #endregion
    }
}
