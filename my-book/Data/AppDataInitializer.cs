using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using my_books.Data.Model;
using System;
using System.Linq;

namespace my_book.Data
{
    public class AppDataInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
               {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "1st Book Title",
                        Desc = "1st Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Author = "First Author",
                        CoverUrl = "https:...",
                        dateadded = DateTime.Now

                    },
                    new Book()
                    {
                        Title = "2nd Book Title",
                        Desc = "2nd Book Description",
                        IsRead = false,
                        Author = "Second Author",
                        CoverUrl = "https:...",
                        dateadded = DateTime.Now

                    }
                    );

                    context.SaveChanges();
                }
            }

        }
    }
}
