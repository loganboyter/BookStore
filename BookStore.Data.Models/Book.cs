using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public Book() { }
        public Book(string title, string author, int pages, decimal price, int stock, string image)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Price = price;
            Stock = stock;
            Image = image;
        }
    }
}
