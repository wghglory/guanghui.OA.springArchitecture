using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Guanghui.OA.DALFactory;
using Guanghui.OA.IDAL;

namespace Guanghui.OA.BLL
{
    public abstract class BaseService<T> where T : class, new()
    {
        //check-out签出的时候，会自动到源代码服务器上下载最新的源代码。

        public IDbSession CurrentDbSession
        {
            get
            {
                //return new DbSession();//暂时
                return DbSessionFactory.GetCurrentDbSession();
            }
        }

        //protected IDbSession CurrentDbSession;//当前类或者是子类
        protected BaseService()
        {
            //CurrentDbSession = DbSessionFactory.GetCurrentDbSession();
            SetCurrentDal();//构造函数里面调用了 抽象方法：SetCurrentDal
        }

        public IBaseDal<T> CurrentDal { get; set; }
        //需要给CurrentDal赋值。基类 不知道当前Dal是谁。 子类知道。
        //逼迫子类给父类的一个属性赋值。
        public abstract void SetCurrentDal();

        public T Add(T entity)
        {
            CurrentDal.Add(entity);
            CurrentDbSession.SaveChanges();
            return entity;
            //return CurrentDbSession.UserDal.Add(entity);
        }

        public bool Update(T entity)
        {
            CurrentDal.Update(entity);
            return CurrentDbSession.SaveChanges() > 0;
        }

        public bool Delete(T entity)
        {
            CurrentDal.Delete(entity);
            return CurrentDbSession.SaveChanges() > 0;
        }

        public IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda)
        {
            return CurrentDal.LoadEntities(whereLambda);
        }

        public IQueryable<T> LoadPageEntities<S>(int pageSize, int pageIndex, out int totalCount, Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, S>> orderBy)
        {
            return CurrentDal.LoadPageEntities(pageSize, pageIndex, out totalCount, whereLambda, isAsc, orderBy);
        }

    }
}
