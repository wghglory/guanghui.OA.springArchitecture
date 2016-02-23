using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using Guanghui.OA.Model;
using Newtonsoft.Json;

namespace Guanghui.OA.Webapp.Controllers
{
    public class BookController : Controller
    {

        //IBLL.IBookService BookService = new BLL.BookService();
        private IBLL.IBookService BookService { get; set; }
        public ActionResult Index()
        {
            #region call bll
            int totalCount = 0;
            return View(BookService.LoadPageEntities(20, 1, out totalCount, u => true, true, o => o.Id));
            #endregion

            #region call api
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("http://localhost:48647/");
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //    var response = client.GetAsync("api/books").Result;
            //    if (response.IsSuccessStatusCode)
            //    {
            //        string responseString = response.Content.ReadAsStringAsync().Result;
            //        IEnumerable<Book> book = JsonConvert.DeserializeObject<IEnumerable<Book>>(responseString);  //iqueryable cannot work
            //        return View(book);
            //    }
            //}
            //return null; 
            #endregion

        }


    }
}
