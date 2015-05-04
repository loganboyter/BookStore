namespace BookStore.Data.Migrations
{
    using BookStore.Data.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookStore.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookStore.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var UserStore = new UserStore<ApplicationUser>(context);
            var UserManager = new UserManager<ApplicationUser>(UserStore);


            if (!context.Users.Any(u => u.UserName == "User"))
            {
                ApplicationUser User = new ApplicationUser();
                User.UserName = "User";
                UserManager.Create(User, "123456");
            }
            if (!context.Users.Any(u => u.UserName == "User2"))
            {
                ApplicationUser User = new ApplicationUser();
                User.UserName = "User2";
                UserManager.Create(User, "123456");
            }
            if (!context.Users.Any(u => u.UserName == "User3"))
            {
                ApplicationUser User = new ApplicationUser();
                User.UserName = "User3";
                UserManager.Create(User, "123456");
            }
            if (!context.Users.Any(u => u.UserName == "User4"))
            {
                ApplicationUser User = new ApplicationUser();
                User.UserName = "User4";
                UserManager.Create(User, "123456");
            }
            context.Books.AddOrUpdate(
                b => b.Title,
                new Book
                {
                    Title = "Harry Potter",
                    Author = "J.K. Rowling",
                    Pages = 500,
                    Price = 19.99m,
                    Stock = 100,
                    Image = "http://upload.wikimedia.org/wikipedia/en/c/c7/Harry_Potter_and_the_Goblet_of_Fire.jpg"
                },
                new Book
                {
                    Title = "Wheel Of Time",
                    Author = "Robert Jordan",
                    Pages = 10000,
                    Price = 21.59m,
                    Stock = 100,
                    Image = "http://upload.wikimedia.org/wikipedia/en/0/00/WoT01_TheEyeOfTheWorld.jpg"
                },
                new Book
                {
                    Title="Game of Thrones",
                    Author = "George R.R. Martin",
                    Pages = 8000,
                    Price = 30.28m,
                    Stock = 100,
                    Image = "http://upload.wikimedia.org/wikipedia/en/d/d8/Game_of_Thrones_title_card.jpg"
                },
                new Book
                {
                    Title = "1984",
                    Author = "George Orwell",
                    Pages = 150,
                    Price = 10.04m,
                    Stock = 32,
                    Image = "http://upload.wikimedia.org/wikipedia/en/c/c3/1984first.jpg"
                },
                new Book
                {
                    Title = "Siddhartha",
                    Author = "Hermann Hesse",
                    Pages = 152,
                    Price = 15.33m,
                    Stock = 150,
                    Image = "http://upload.wikimedia.org/wikipedia/en/0/04/Hermann_Hesse_-_Siddhartha_%28book_cover%29.jpg"
                }
                );

        }
    }
}
