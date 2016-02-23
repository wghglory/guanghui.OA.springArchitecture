using System.Collections.Generic;
using Guanghui.OA.Model;

namespace Guanghui.OA.IDAL
{
    public partial interface ISearchLogGroupByDal : IBaseDal<SearchLogGroupBy>
    {
        bool DeleteAllSearchLogGroupBy();
        bool InsertSearchLogGroupBy();
        List<string> GetSearchMsg(string term);

    }
}