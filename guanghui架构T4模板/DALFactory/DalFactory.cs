using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Guanghui.OA.IDAL;

namespace Guanghui.OA.DALFactory
{
    /// <summary>
    /// 简单工厂或者抽象工厂。我们都不用，用spring.NET
    /// </summary>
    public partial class DalFactory
    {
        public static readonly string AssemblyName;
        public static readonly string NameSpace;

        static DalFactory()//静态构造函数：clr，而且处理多线程并发的问题。
        {
            AssemblyName = System.Configuration.ConfigurationManager.AppSettings["AssemblyName"];
            //<add key="AssemblyName" value="Guanghui.OA.EFDAL"/>
            NameSpace = System.Configuration.ConfigurationManager.AppSettings["NameSpace"];
        }

        private static object CreateInstance(string className)
        {
            var assembly = Assembly.Load(AssemblyName);
            return assembly.CreateInstance(className);
        }

        //GetDAL有tt模板搞定！

        //public static IUserDal GetUserDal()
        //{
        //    //简单工厂
        //    //return new Guanghui.OA.EFDAL.UserDal();
        //    //return new Guanghui.OA.ADONETDAL.UserDal();

        //    //不用缓存，因为要保证实例唯一。
        //    //IUserDal userDal = HttpRuntime.Cache[AssemblyName + ".UserDal"]
        //    //                           as IUserDal;

        //    //if (userDal == null)
        //    //{
        //    //    userDal = Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".UserDal", true) as IUserDal;
        //    //    HttpRuntime.Cache.Insert(AssemblyName + ".UserDal", userDal);

        //    //}
        //    //return userDal;

        //    //抽象工厂：反射的方式创建实例，读取web.config
        //    return Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".UserDal", true) as IUserDal;

        //}

        //public static IOrderDal GetOrderDal()
        //{
        //    //抽象工厂：反射的方式创建实例，读取web.config
        //    return Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".OrderDal", true) as IOrderDal;

        //}



    }
}

