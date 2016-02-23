using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Guanghui.OA.IDAL;
using Guanghui.OA.Model;

namespace Guanghui.OA.AdonetDAL
{
    public class UserDal : IUserDal
    {
        public User Add(User entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> LoadEntities(Expression<Func<User, bool>> whereLambda)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> LoadPageEntities<S>(int pageSize, int pageIndex, out int totalCount, Expression<Func<User, bool>> whereLambda, bool isAsc, Expression<Func<User, S>> orderBy)
        {
            throw new NotImplementedException();
        }

        public bool Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
