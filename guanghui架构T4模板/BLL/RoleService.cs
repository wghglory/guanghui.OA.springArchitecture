using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guanghui.OA.IBLL;
using Guanghui.OA.Model;

namespace Guanghui.OA.BLL
{
    //our method, not from TT
    public partial class RoleService : BaseService<Role>, IRoleService
    {
        #region old

        //最不能用的。纯菜鸟
        //RoleDal dal =new RoleDal();

        //一般鸟
        //private IRoleDal dal = new Guanghui.OA.EFDAL.RoleDal();

        //private IRoleDal dal = new Guanghui.OA.ADONETDAL.RoleDal();

        //鸟：
        //private IRoleDal dal = DalFactory.GetRoleDal();//走了抽象工厂了。


        //private IRoleDal dal;
        //private IDbSession dbSession;
        //public RoleService()
        //{
        //    dbSession = DbSessionFactory.GetCurrentDbSession();
        //     dal= dbSession.RoleDal;
        //}


        ////依赖注入。Spring.Net


        //public Role Add(Role Role)
        //{
        //    //一个业务方法，一般都会操作多个表。


        //     dal.Add(Role);
        //     dbSession.SaveChanges();
        //    dal.Delete(Role);
        //    dal.Update(Role);
        //    dbSession.SaveChanges();

        //    return Role;

        //} 
        #endregion

        #region 批量删除
        public int DeleteRoles(IList<int> ids)
        {
            //foreach (var id in ids)
            //{
            //    var role = DbSession.RoleDal.LoadEntities(u => u.Id == id).FirstOrDefault();
            //    if (role != null)
            //    {
            //        role.DelFlag = (short)Guanghui.OA.Model.Enum.DelFlagEnum.Deleted;
            //    }
            //}
            //return DbSession.SaveChanges();

            var roles = CurrentDbSession.RoleDal.LoadEntities(u => ids.Contains(u.Id));
            foreach (var role in roles)
            {
                //role.DelFlag = (short)Guanghui.OA.Model.Enum.DelFlagEnum.Deleted;
                //DbSession.RoleDal.Delete(role);
            }
            return CurrentDbSession.SaveChanges();
        }

        #endregion

        /// <summary>
        /// 为角色分配权限
        /// </summary>
        /// <param name="roleId">角色编号</param>
        /// <param name="actionIdList">权限编号列表</param>
        /// <returns></returns>
        public bool SetRoleActionInfo(int roleId, List<int> actionIdList)
        {
            //获取角色信息.
            var role = CurrentDbSession.RoleDal.LoadEntities(r => r.Id == roleId).FirstOrDefault();
            if (role != null)
            {
                role.ActionInfo.Clear();
                foreach (int actionId in actionIdList)
                {
                    var actionInfo = CurrentDbSession.ActionInfoDal.LoadEntities(a => a.Id == actionId).FirstOrDefault();
                    role.ActionInfo.Add(actionInfo);
                }
                return CurrentDbSession.SaveChanges() > 0;
            }
            return false;
        }
    }
}
