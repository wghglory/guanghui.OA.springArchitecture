using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guanghui.OA.DALFactory;
using Guanghui.OA.IBLL;
using Guanghui.OA.Model;

namespace Guanghui.OA.BLL
{
    public partial class SearchLogGroupByService : BaseService<SearchLogGroupBy>, ISearchLogGroupByService
    {
        /// <summary>
        /// 将统计的明细表的数据插入。
        /// </summary>
        /// <returns></returns>
        public bool InsertSearchLogGroupBy()
        {
            return CurrentDbSession.SearchLogGroupByDal.InsertSearchLogGroupBy();
        }
        /// <summary>
        /// 删除汇总中的数据。
        /// </summary>
        /// <returns></returns>
        public bool DeleteAllSearchLogGroupBy()
        {
            return CurrentDbSession.SearchLogGroupByDal.DeleteAllSearchLogGroupBy();
        }
        public List<string> GetSearchMsg(string term)
        {
            return CurrentDbSession.SearchLogGroupByDal.GetSearchMsg(term);
        }
    }
}
