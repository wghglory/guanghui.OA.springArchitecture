 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guanghui.OA.Model;

namespace Guanghui.OA.IBLL
{ 
 
	public partial interface IActionInfoService : IBaseService<ActionInfo>
    {
    }
 
	public partial interface IBookService : IBaseService<Book>
    {
    }
 
	public partial interface IDepartmentService : IBaseService<Department>
    {
    }
 
	public partial interface IOrderService : IBaseService<Order>
    {
    }
 
	public partial interface IR_User_ActionInfoService : IBaseService<R_User_ActionInfo>
    {
    }
 
	public partial interface IRoleService : IBaseService<Role>
    {
    }
 
	public partial interface ISearchLogService : IBaseService<SearchLog>
    {
    }
 
	public partial interface ISearchLogGroupByService : IBaseService<SearchLogGroupBy>
    {
    }
 
	public partial interface IUserService : IBaseService<User>
    {
    }
 
	public partial interface IUserExtService : IBaseService<UserExt>
    {
    }
 
	public partial interface IWF_InstanceService : IBaseService<WF_Instance>
    {
    }
 
	public partial interface IWF_StepService : IBaseService<WF_Step>
    {
    }
 
	public partial interface IWF_TempService : IBaseService<WF_Temp>
    {
    }

}