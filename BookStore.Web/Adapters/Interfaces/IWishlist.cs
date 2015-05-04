using BookStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Web.Adapters.Interfaces
{
    interface IWishlist
    {
        List<Book> GetWishlist(string userId);
        Book AddToWishlist(string userId, int bookId);
        Book RemoveFromWishlist(string userId, int bookId);

    }
}
