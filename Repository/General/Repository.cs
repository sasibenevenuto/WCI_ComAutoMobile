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
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseModel
    {
        #region .:: Prorpiedades ::.        
        public Settings _settings;

        #endregion

        #region .:: Construtor ::.
        public Repository()
        {
        }

        #endregion

        #region .:: Crud ::.
        public async Task<TEntity> AddAsync(TEntity entity, string query)
        {
            entity = BeforAdd(entity);
            using var con = new SqlConnection(_settings.ConnectionString);
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

        public async Task DeleteAsync(TEntity entity, string query)
        {
            using var con = new SqlConnection(_settings.ConnectionString);
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

        public async Task<List<TEntity>> GetListAsync(TEntity entity, string query)
        {
            List<TEntity> entityList = new List<TEntity>();

            using var con = new SqlConnection(_settings.ConnectionString);
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

        public async Task<int> GetListCountAsync(TEntity entity, string query)
        {
            int entityList = 0;
            using var con = new SqlConnection(_settings.ConnectionString);
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

        public async Task<TEntity> UpdateAsync(TEntity entity, string query)
        {
            entity = BeforUpdate(entity);
            using var con = new SqlConnection(_settings.ConnectionString);
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
        public virtual TEntity BeforAdd(TEntity entity)
        {
            entity.Active = true;
            entity.CreateDate = DateTime.Now;
            entity.ModifieldDate = DateTime.Now;
            return entity;
        }

        public virtual TEntity BeforUpdate(TEntity entity)
        {
            entity.ModifieldDate = DateTime.Now;
            return entity;
        }

        #endregion
    }
}
