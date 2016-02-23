using System.Runtime.Remoting.Messaging;
using System.Web;
using Guanghui.OA.IDAL;

namespace Guanghui.OA.DALFactory
{
    public class DbSessionFactory
    {
        public static IDbSession GetCurrentDbSession()
        {
            //IDbSession dbSession = HttpContext.Current.Items["DbSession"] as IDbSession;
            //if (dbSession == null)
            //{
            //    dbSession = new DbSession();
            //    HttpContext.Current.Items.Add("DbSession", dbSession);
            //}
            //return dbSession;

            IDbSession dbSession = (IDbSession)CallContext.GetData("DbSession");
            if (dbSession == null)
            {
                dbSession = new DbSession();
                CallContext.SetData("DbSession", dbSession);
            }
            return dbSession;
        }
    }
}