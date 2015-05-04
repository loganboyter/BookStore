using BookStore.Data;
using BookStore.Data.Models;
using BookStore.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Web.Adapters
{
    public class BookAdapter : IBook
    {
        public IOrderedEnumerable<Book> GetBooks(string search, string sort)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            if (search != null && search != "nosearch")
            {
                if (sort == "asc") return Db.Books.Where(b => b.Title.Contains(search) || b.Author.Contains(search)).ToList().OrderBy(b => b.Title);
                else return Db.Books.Where(b => b.Title.Contains(search) || b.Author.Contains(search)).ToList().OrderByDescending(b => b.Title);
            }
            else
            {
                if (sort == "asc") return Db.Books.ToList().OrderBy(b => b.Title);
                else return Db.Books.ToList().OrderByDescending(b => b.Title);
            }
        }

        public Book GetBook(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            return Db.Books.Where(a => a.Id == id).FirstOrDefault();
        }
    }
}