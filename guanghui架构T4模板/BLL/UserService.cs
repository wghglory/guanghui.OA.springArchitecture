using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guanghui.OA.IBLL;
using Guanghui.OA.Model;
using Guanghui.OA.Model.SearchParams;

namespace Guanghui.OA.BLL
{
    ////定义自己特有的
    public partial class UserService : BaseService<User>, IUserService
    {
        #region old

        //最不能用的。纯菜鸟
        //UserDal dal =new UserDal();

        //一般鸟
        //private IUserDal dal = new Guanghui.OA.EFDAL.UserDal();

        //private IUserDal dal = new Guanghui.OA.ADONETDAL.UserDal();

        //鸟：
        //private IUserDal dal = DalFactory.GetUserDal();//走了抽象工厂了。


        //private IUserDal dal;
        //private IDbSession dbSession;
        //public UserService()
        //{
        //    dbSession = DbSessionFactory.GetCurrentDbSession();
        //     dal= dbSession.UserDal;
        //}


        ////依赖注入。Spring.Net


        //public User Add(User user)
        //{
        //    //一个业务方法，一般都会操作多个表。


        //     dal.Add(user);
        //     dbSession.SaveChanges();
        //    dal.Delete(user);
        //    dal.Update(user);
        //    dbSession.SaveChanges();

        //    return user;

        //} 
        #endregion

        #region 批量删除
        public int DeleteUsers(IList<int> ids)
        {
            //foreach (var id in ids)
            //{
            //    var user = DbSession.UserDal.LoadEntities(u => u.Id == id).FirstOrDefault();
            //    if (user != null)
            //    {
            //        user.DelFlag = (short)Guanghui.OA.Model.Enum.DelFlagEnum.Deleted;
            //    }
            //}
            //return DbSession.SaveChanges();

            var userList = CurrentDbSession.UserDal.LoadEntities(u => ids.Contains(u.Id));
            foreach (var user in userList)
            {
                //DbSession.UserDal.Delete(user);
                user.DelFlag = (short)Guanghui.OA.Model.Enum.DelFlagEnum.Deleted;
            }
            return CurrentDbSession.SaveChanges();
        }
        #endregion

        #region 分页加载数据，带搜索内容
        public IQueryable<User> LoadSearchedUsers(UserSearchParam param)
        {
            short delNormal = (short)Guanghui.OA.Model.Enum.DelFlagEnum.Normal;
            var temp = CurrentDbSession.UserDal.LoadEntities(u => u.DelFlag == delNormal);
            if (!string.IsNullOrEmpty(param.SearchEmail))
            {
                temp = temp.Where(u => u.Email.Contains(param.SearchEmail));
            }

            if (!string.IsNullOrEmpty(param.SearchName))
            {
                temp = temp.Where(u => u.UserName.Contains(param.SearchName));
            }

            param.Total = temp.Count();

            return temp.OrderBy(u => u.Id)
                .Skip(param.PageSize * (param.PageIndex - 1))
                .Take(param.PageSize);

        }

        public IQueryable<User> LoadSearchedUsers(UserSearchParam param, short delFlag)
        {
            var temp = CurrentDbSession.UserDal.LoadEntities(u => u.DelFlag == delFlag);
            if (!string.IsNullOrEmpty(param.SearchEmail))
            {
                temp = temp.Where(u => u.Email.Contains(param.SearchEmail));
            }

            if (!string.IsNullOrEmpty(param.SearchName))
            {
                temp = temp.Where(u => u.UserName.Contains(param.SearchName));
            }

            param.Total = temp.Count();

            return temp.OrderBy(u => u.Id)
                .Skip(param.PageSize * (param.PageIndex - 1))
                .Take(param.PageSize);

        }
        #endregion

        #region 设置用户的角色
        public bool SetUserRole(int userId, List<int> selectRoleIds)
        {
            //查询出当前设置角色的用户
            var user = CurrentDbSession.UserDal.LoadEntities(u => u.Id == userId).FirstOrDefault();

            //如果用户之前已经有了角色。先把之前的角色都清空掉。
            if (user != null)
            {
                user.Role.Clear();//EF内部处理了两个集合的变化。
                //e.g  start set{1,2,3}  and  final set{1,2,4}
                //要从第一个集合删除3，第二个集合加上4.这个过程比较复杂。
                //可以像上面那样处理，另一种处理就是清空用户原有的角色，把所有新的final set角色id加给用户

                //把用户已有的角色查询出来。
                var allRoles = CurrentDbSession.RoleDal.LoadEntities(r => selectRoleIds.Contains(r.Id)).ToList();

                foreach (var roleInfo in allRoles)
                {
                    user.Role.Add(roleInfo);
                }

                //foreach (int roleId in selectRoleIds)
                //{
                //    var roleInfo =DbSession.RoleDal.LoadEntities(r => r.Id == roleId).FirstOrDefault();
                //    user.Role.Add(roleInfo);
                //}

            }
            return CurrentDbSession.SaveChanges() > 0;
        }
        #endregion

        #region 完成用户权限的分配
        public bool SetUserActionInfo(int actionId, int userId, bool isPass)
        {
            //判断userId以前是否有了该actionId,如果有了只需要修改isPass状态，否则插入。
            var r_userInfo_actionInfo = CurrentDbSession.R_User_ActionInfoDal.LoadEntities(a => a.ActionInfoId == actionId && a.UserId == userId).FirstOrDefault();
            if (r_userInfo_actionInfo == null)
            {
                R_User_ActionInfo userInfoActionInfo = new R_User_ActionInfo();
                userInfoActionInfo.ActionInfoId = actionId;
                userInfoActionInfo.UserId = userId;
                userInfoActionInfo.IsPass = isPass;
                CurrentDbSession.R_User_ActionInfoDal.Add(userInfoActionInfo);
            }
            else
            {
                r_userInfo_actionInfo.IsPass = isPass;
                CurrentDbSession.R_User_ActionInfoDal.Update(r_userInfo_actionInfo);
            }
            return CurrentDbSession.SaveChanges() > 0;

        }
        #endregion
    }
}
