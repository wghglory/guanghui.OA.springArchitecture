using System.Collections.Generic;
using System.Linq;
using Guanghui.OA.Model;

namespace Guanghui.OA.IBLL
{

    public partial interface IRoleService : IBaseService<Role>
    {
        int DeleteRoles(IList<int> ids);
        bool SetRoleActionInfo(int roleId, List<int> actionIdList);
    }
}