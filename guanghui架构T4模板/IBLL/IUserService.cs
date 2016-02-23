using System.Collections.Generic;
using System.Linq;
using Guanghui.OA.Model;
using Guanghui.OA.Model.SearchParams;

namespace Guanghui.OA.IBLL
{

    public partial interface IUserService : IBaseService<User>
    {
        //定义自己特有
        int DeleteUsers(IList<int> ids);

        IQueryable<User> LoadSearchedUsers(UserSearchParam param);

        IQueryable<User> LoadSearchedUsers(UserSearchParam param, short delFlag);

        bool SetUserRole(int userId, List<int> selectRoleIds);

        bool SetUserActionInfo(int actionId, int userId, bool isPass);
    }
}