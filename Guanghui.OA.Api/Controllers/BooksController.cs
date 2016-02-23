using System.Linq;
using System.Web.Http;
using Guanghui.OA.Model;

namespace Guanghui.OA.Api.Controllers
{
    public class BooksController : ApiController
    {
        IBLL.IBookService BookService = new BLL.BookService();
        //private IBLL.IBookService BookService { get; set; }
        public IQueryable<Book> Get()
        {
            int totalCount = 0;
            return BookService.LoadPageEntities(20, 1, out totalCount, u => true, true, o => o.Id);
        }


    }
}
