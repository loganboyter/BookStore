using BookStore.Data;
using BookStore.Data.Models;
using BookStore.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Web.Adapters
{
    public class WishlistAdapter : IWishlist
    {
        public List<Book> GetWishlist(string userId)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            return Db.Wishlists.Where(w => w.ApplicationUserId == userId).Select(w => Db.Books.FirstOrDefault(b => b.Id == w.BookId)).ToList();
        }

        public Book AddToWishlist(string userId, int bookId)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Db.Wishlists.Add(new Wishlist
            {
                ApplicationUserId = userId,
                BookId = bookId
            });
            Db.SaveChanges();
            return Db.Books.Where(b => b.Id == bookId).FirstOrDefault();
        }

        public Book RemoveFromWishlist(string userId, int bookId)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Db.Wishlists.Remove(Db.Wishlists.Where(w => w.BookId == bookId && w.ApplicationUserId == userId).FirstOrDefault());
            Db.SaveChanges();
            return Db.Books.Where(b => b.Id == bookId).FirstOrDefault();
        }
    }
}