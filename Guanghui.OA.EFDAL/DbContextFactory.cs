using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Guanghui.OA.Model;

namespace Guanghui.OA.EFDAL
{
    /// <summary>
    /// 保证EF的上下文线程内实例唯一。一次请求创建一个实例。一个请求一个实例都这么做！
    /// </summary>
    public class DbContextFactory
    {
        public static DbContext GetCurrentDbContext()
        {
            //线程内实例唯一
            //DbContext dbContext = HttpContext.Current.Items["dbContext"] as DbContext;
            //if (dbContext == null)
            //{
            //    dbContext = new GuanghuiOAEntities();
            //    HttpContext.Current.Items.Add("dbContext", dbContext);
            //}

            //return dbContext;

            DbContext dbContext = (DbContext)CallContext.GetData("dbContext");
            if (dbContext == null)
            {
                dbContext = new DataModelContainer();
                CallContext.SetData("dbContext", dbContext);
            }
            return dbContext;
        }
    }
}
