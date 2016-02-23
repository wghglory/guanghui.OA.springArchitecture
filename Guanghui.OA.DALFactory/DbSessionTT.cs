 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guanghui.OA.EFDAL;
using Guanghui.OA.IDAL;

namespace Guanghui.OA.DALFactory
{
    public partial class DbSession :IDbSession
    { 
	
		public IActionInfoDal ActionInfoDal { get; set; }
	
		public IBookDal BookDal { get; set; }
	
		public IDepartmentDal DepartmentDal { get; set; }
	
		public IOrderDal OrderDal { get; set; }
	
		public IR_User_ActionInfoDal R_User_ActionInfoDal { get; set; }
	
		public IRoleDal RoleDal { get; set; }
	
		public ISearchLogDal SearchLogDal { get; set; }
	
		public ISearchLogGroupByDal SearchLogGroupByDal { get; set; }
	
		public IUserDal UserDal { get; set; }
	
		public IUserExtDal UserExtDal { get; set; }
	
		public IWF_InstanceDal WF_InstanceDal { get; set; }
	
		public IWF_StepDal WF_StepDal { get; set; }
	
		public IWF_TempDal WF_TempDal { get; set; }
	}

}