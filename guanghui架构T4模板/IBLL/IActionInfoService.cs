using System.Collections.Generic;
using Guanghui.OA.Model;

namespace Guanghui.OA.IBLL
{
    public partial interface IActionInfoService : IBaseService<ActionInfo>
    {
        int DeleteActions(IList<int> ids);

        bool SetRole(int userId, List<int> selectRoleIds);
    }
}