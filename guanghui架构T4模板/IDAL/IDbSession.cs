using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Guanghui.OA.IDAL
{
    //业务层调用的是数据会话层的接口。
    public partial interface IDbSession
    {
        //IUserDal UserDal { get; }

        //IOrderDal OrderDal { get; }

        int SaveChanges();

        DbContext Db { get; }
        //int ExecuteSql(string sql, params SqlParameter[] pars);
        //List<T> ExecuteQuery<T>(string sql, params SqlParameter[] pars);
    }
}