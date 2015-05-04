using BookStore.Web.Adapters;
using BookStore.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BookStore.Web.Controllers
{
    public class apiBookController : ApiController
    {
        IBook _adapter;
        public apiBookController()
        {
            _adapter = new BookAdapter();
        }
        [HttpGet]
        public IHttpActionResult Get(string id="all", string search = null, string sort = "asc") 
        {
            int number;
            if (id == "all") return Ok(_adapter.GetBooks(search, sort));
            else if (Int32.TryParse(id, out number) == true && _adapter.GetBook(Convert.ToInt32(id)) != null) return Ok(_adapter.GetBook(Convert.ToInt32(id)));
            else return BadRequest("Book ID Was Invalid");
        }
    }
}