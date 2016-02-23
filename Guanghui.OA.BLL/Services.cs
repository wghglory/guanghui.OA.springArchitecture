 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guanghui.OA.DALFactory;
using Guanghui.OA.IBLL;
using Guanghui.OA.IDAL;
using Guanghui.OA.Model;

namespace Guanghui.OA.BLL
{
 
	public partial class ActionInfoService : BaseService<ActionInfo>, IActionInfoService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDbSession.ActionInfoDal;
        }
    }
 
	public partial class BookService : BaseService<Book>, IBookService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDbSession.BookDal;
        }
    }
 
	public partial class DepartmentService : BaseService<Department>, IDepartmentService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDbSession.DepartmentDal;
        }
    }
 
	public partial class OrderService : BaseService<Order>, IOrderService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDbSession.OrderDal;
        }
    }
 
	public partial class R_User_ActionInfoService : BaseService<R_User_ActionInfo>, IR_User_ActionInfoService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDbSession.R_User_ActionInfoDal;
        }
    }
 
	public partial class RoleService : BaseService<Role>, IRoleService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDbSession.RoleDal;
        }
    }
 
	public partial class SearchLogService : BaseService<SearchLog>, ISearchLogService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDbSession.SearchLogDal;
        }
    }
 
	public partial class SearchLogGroupByService : BaseService<SearchLogGroupBy>, ISearchLogGroupByService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDbSession.SearchLogGroupByDal;
        }
    }
 
	public partial class UserService : BaseService<User>, IUserService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDbSession.UserDal;
        }
    }
 
	public partial class UserExtService : BaseService<UserExt>, IUserExtService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDbSession.UserExtDal;
        }
    }
 
	public partial class WF_InstanceService : BaseService<WF_Instance>, IWF_InstanceService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDbSession.WF_InstanceDal;
        }
    }
 
	public partial class WF_StepService : BaseService<WF_Step>, IWF_StepService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDbSession.WF_StepDal;
        }
    }
 
	public partial class WF_TempService : BaseService<WF_Temp>, IWF_TempService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDbSession.WF_TempDal;
        }
    }

}