using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using Guanghui.OA.IDAL;
using DbContextFactory = Guanghui.OA.EFDAL.DbContextFactory;

namespace Guanghui.OA.DALFactory
{
    /// <summary>
    /// 数据会话层：就是一个工厂类，负责完成所有数据操作类实例的创建，然后业务层通过数据会话层来获取要操作数据类的实例。所以数据会话层将业务层与数据层解耦。
    /// 在数据会话层中提供一个方法：完成所有数据的保存。
    /// </summary>
    public partial class DbSession : IDbSession
    {
        public DbContext Db
        {
            get
            {
                return DbContextFactory.GetCurrentDbContext();
            }
        }

        #region 行为
        /// <summary>
        /// 一个业务中经常涉及到对多张操作，我们希望链接一次数据库，完成对张表数据的操作。提高性能。工作单元模式。
        /// </summary>
        public int SaveChanges()
        {
            //让当前的上下文（一次一个上下文。）进行提交。
            return Db.SaveChanges();  //ef         
        }

        //public int ExecuteSql(string sql, params SqlParameter[] pars)
        //{
        //    return Db.Database.ExecuteSqlCommand(sql, pars);
        //}
        //public List<T> ExecuteQuery<T>(string sql, params SqlParameter[] pars)
        //{
        //    return Db.Database.SqlQuery<T>(sql, pars).ToList();
        //}


        #endregion

        //所有属性由模板搞定！
        #region 属性

        //private IUserDal _UserDal;
        //public IUserDal UserDal
        //{
        //    get
        //    {
        //        if (_UserDal == null)
        //        {
        //            _UserDal = DalFactory.GetUserDal();
        //        }
        //        return _UserDal;
        //    }
        //}

        //private IOrderDal _OrderDal;
        //public IOrderDal OrderDal
        //{
        //    get
        //    {
        //        if (_OrderDal == null)
        //        {
        //            _OrderDal = DalFactory.GetOrderDal();
        //        }
        //        return _OrderDal;
        //    }
        //}
        #endregion

    }
}