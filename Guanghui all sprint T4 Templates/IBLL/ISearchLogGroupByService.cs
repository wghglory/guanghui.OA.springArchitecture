using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guanghui.OA.Model;

namespace Guanghui.OA.IBLL
{
    public partial interface ISearchLogGroupByService : IBaseService<SearchLogGroupBy>
    {
        bool DeleteAllSearchLogGroupBy();
        bool InsertSearchLogGroupBy();
        List<string> GetSearchMsg(string term);
    }
}
