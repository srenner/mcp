using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mcp.web.Data
{
    public class McpRepository : IMcpRepository
    {
        private readonly ApplicationDbContext _context;

        public McpRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        #region Generics

        public T AddEntity<T>(T entity) where T : class
        {
            try
            {
                _context.Entry<T>(entity).State = EntityState.Added;
                _context.SaveChanges();
                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T UpdateEntity<T>(T updateObj) where T : class
        {
            try
            {
                _context.Entry<T>(updateObj).State = EntityState.Modified;
                _context.SaveChanges();

                return updateObj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T AddOrUpdateEntity<T>(T obj) where T : class
        {
            try
            {
                Type type = obj.GetType();
                int id = (int)obj.GetType().GetProperty(_context.Model.FindEntityType(type).FindPrimaryKey().Properties.Select(x => x.Name).FirstOrDefault()).GetValue(obj);
                if (id == 0)
                {
                    return this.AddEntity(obj);
                }
                else
                {
                    return this.UpdateEntity(obj);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteEntity<T>(T deleteObj) where T : class
        {
            try
            {
                _context.Entry<T>(deleteObj).State = EntityState.Deleted;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T GetEntity<T>(object id) where T : class
        {
            return _context.Set<T>().Find(id);
        }

        #endregion
    }
}
