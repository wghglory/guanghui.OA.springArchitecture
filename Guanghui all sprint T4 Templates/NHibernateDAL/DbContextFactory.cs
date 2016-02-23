using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Guanghui.OA.Model;
using NHibernate;
using NHibernate.Cfg;

namespace Guanghui.OA.NHibernateDAL
{
    /// <summary>
    /// 保证EF的上下文线程内实例唯一。一次请求创建一个实例。一个请求一个实例都这么做！
    /// </summary>
    public class DbContextFactory
    {
        public static ISession GetCurrentDbContext()
        {
            //创建Nh的工厂
            ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();

            return sessionFactory.OpenSession();

        }
    }
}
