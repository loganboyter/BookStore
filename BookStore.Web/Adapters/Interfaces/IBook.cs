using BookStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Web.Adapters.Interfaces
{
    interface IBook
    {
        IOrderedEnumerable<Book> GetBooks(string search, string sort);
        Book GetBook(int id);
    }
}
