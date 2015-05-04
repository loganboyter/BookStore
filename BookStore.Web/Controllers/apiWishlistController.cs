using BookStore.Web.Adapters;
using BookStore.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace BookStore.Web.Controllers
{
    public class apiWishlistController : ApiController
    {
        IWishlist _adapter;
        public apiWishlistController()
        {
            _adapter = new WishlistAdapter();
        }
        [Authorize]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_adapter.GetWishlist(User.Identity.GetUserId()));
        }
        [Authorize]
        [HttpPost]
        public IHttpActionResult Post(int bookId = 0)
        {
            if (bookId == 0) return BadRequest("The Book ID was incorrect.");
            else return Ok(_adapter.AddToWishlist(User.Identity.GetUserId(), bookId));
        }
        [Authorize]
        [HttpDelete]
        public IHttpActionResult Delete(int bookId = 0)
        {
            if (bookId == 0) return BadRequest("The Book ID was incorrect.");
            else return Ok(_adapter.RemoveFromWishlist(User.Identity.GetUserId(), bookId));
        }
    }
}