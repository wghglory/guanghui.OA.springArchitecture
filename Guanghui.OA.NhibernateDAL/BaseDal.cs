using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Event.Default;
using NHibernate.Linq;

namespace Guanghui.OA.NHibernateDAL
{
    //针对所有的实体的公共的crud方法的封装。
    public class BaseDal<T> where T : class, new()
    {
        private ISession _session;

        public BaseDal()
        {
            _session = DbContextFactory.GetCurrentDbContext();
        }

        //public void SaveChanges()
        //{
        //    ITransaction trans = session.BeginTransaction();//开始事务
        //    trans.Commit();
        //}

        public T Add(T entity)
        {
            //Role role = new Role();
            //role.ModifiedOn = DateTime.Now;
            //role.SubmitTime = DateTime.Now;
            //role.RoleName = "小样爱洗222222222脚2";
            //role.DelFlag = 0;
            ITransaction trans = _session.BeginTransaction();//开始事务
            _session.Save(entity);  //add new  
            trans.Commit();
            return entity;
        }

        public bool Update(T entity)
        {
            ITransaction trans = _session.BeginTransaction();
            _session.Update(entity);
            trans.Commit();
            return true;

        }

        public bool Delete(T entity)
        {
            ITransaction trans = _session.BeginTransaction();
            _session.Delete(entity);
            trans.Commit();
            return true;
        }

        public IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda)
        {
            //db.Set<UserInfo>().Where(u => u.ID > 10).Select(u => u);
            return _session.Query<T>().Where(whereLambda);
        }

        //分页
        public IQueryable<T> LoadPageEntities<S>(int pageSize, int pageIndex,
                                                  out int totalCount,
            Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, S>> orderBy)
        {
            IQueryable<T> temp = _session.Query<T>().Where(whereLambda);

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

        //以下需要修改。
        public int ExecuteSql(string sql, params SqlParameter[] pms)
        {
            var result = _session.CreateSQLQuery(sql).SetParameterList("work?", pms);
            return 1;
        }
        public List<TS> ExecuteQuery<TS>(string sql, params SqlParameter[] pms)
        {
            var result = _session.CreateSQLQuery(sql).SetParameter("work?", pms).List<TS>();
            return result.ToList();
        }

    }
}
