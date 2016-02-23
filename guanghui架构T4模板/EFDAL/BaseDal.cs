using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Guanghui.OA.EFDAL
{
    //针对所有的实体的公共的crud方法的封装。
    public class BaseDal<T> where T : class, new()
    {
        private DbContext _db;

        public BaseDal()
        {
            _db = DbContextFactory.GetCurrentDbContext();
        }


        public T Add(T entity)
        {
            _db.Set<T>().Add(entity);
            //db.SaveChanges();//自动增长的主键，会自动赋值到属性上去。
            return entity;
        }

        public bool Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            //return db.SaveChanges() > 0;
            return true;

        }

        public bool Delete(T entity)
        {
            _db.Entry(entity).State = EntityState.Deleted;
            //db.SaveChanges();
            //return db.SaveChanges() > 0;
            return true;
        }


        public IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda)
        {
            //db.Set<UserInfo>().Where(u => u.ID > 10).Select(u => u);
            return _db.Set<T>().Where(whereLambda);
        }

        public IQueryable<T> LoadPageEntities<S>(int pageSize, int pageIndex, out int totalCount, Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, S>> orderBy)
        {
            IQueryable<T> temp = _db.Set<T>().Where(whereLambda);

            totalCount = temp.Count();

            if (isAsc)
            {
                temp = temp.OrderBy(orderBy)
                           .Skip(pageSize * (pageIndex - 1))
                           .Take(pageSize);
            }
            else
            {
                temp = temp.OrderByDescending(orderBy)
                          .Skip(pageSize * (pageIndex - 1))
                          .Take(pageSize);
            }

            return temp;
        }

        public int ExecuteSql(string sql, params SqlParameter[] pms)
        {
            return _db.Database.ExecuteSqlCommand(sql, pms);
        }
        public List<TS> ExecuteQuery<TS>(string sql, params SqlParameter[] pms)
        {
            return _db.Database.SqlQuery<TS>(sql, pms).ToList();
        }

    }
}
