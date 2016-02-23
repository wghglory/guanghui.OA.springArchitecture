 

namespace Guanghui.OA.IDAL
{
    public partial interface IDbSession
    { 
	
		IActionInfoDal ActionInfoDal { get; }
	
		IBookDal BookDal { get; }
	
		IDepartmentDal DepartmentDal { get; }
	
		IOrderDal OrderDal { get; }
	
		IR_User_ActionInfoDal R_User_ActionInfoDal { get; }
	
		IRoleDal RoleDal { get; }
	
		ISearchLogDal SearchLogDal { get; }
	
		ISearchLogGroupByDal SearchLogGroupByDal { get; }
	
		IUserDal UserDal { get; }
	
		IUserExtDal UserExtDal { get; }
	
		IWF_InstanceDal WF_InstanceDal { get; }
	
		IWF_StepDal WF_StepDal { get; }
	
		IWF_TempDal WF_TempDal { get; }
	}

}