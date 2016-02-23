using System.Collections.Generic;
using System.Data.SqlClient;

namespace Guanghui.OA.EFDAL
{
    public partial class SearchLogGroupByDal
    {
        /// <summary>
        /// 将统计的明细表的数据插入。
        /// </summary>
        /// <returns></returns>
        public bool InsertSearchLogGroupBy()
        {
            string sql = @"insert into SearchLogGroupBy(Id,KeyWord,SearchCount) 
                           select newid(),KeyWord,count(*)  from SearchLog 
                           where DateDiff(day,SearchLog.SearchDateTime,getdate())<=7 
                           group by SearchLog.KeyWord";
            return ExecuteSql(sql) > 0;
        }
        /// <summary>
        /// 删除汇总中的数据。
        /// </summary>
        /// <returns></returns>
        public bool DeleteAllSearchLogGroupBy()
        {
            string sql = "truncate table SearchLogGroupBy";
            return ExecuteSql(sql) > 0;
        }
        public List<string> GetSearchMsg(string term)
        {
            //KeyWord like term%
            string sql = "select KeyWord from SearchLogGroupBy where KeyWord like @term";
            return ExecuteQuery<string>(sql, new SqlParameter("@term", term + "%"));
        }
    }
}