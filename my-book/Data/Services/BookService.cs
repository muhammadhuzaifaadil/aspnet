using my_book.Data.VModels;
using my_books.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace my_book.Data.Services
{
    public class BookService
    {
        private AppDbContext _context;
        public BookService(AppDbContext context)
        {
            _context = context;
        }

        public void AddBook(BookVm book)
        {
            var _book = new Book()
            {
                Title = book.Title,
                Desc = book.Desc,
                IsRead = book.IsRead,
                DateRead = book.IsRead ? book.DateRead.Value : null,
                Rate = book.IsRead ? book.Rate.Value : null,
                Author = book.Author,
                CoverUrl = book.CoverUrl,
                dateadded = DateTime.Now
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }
        public List<Book> GetAllBooks()
        {
            var allBooks = _context.Books.ToList();
            return allBooks;
    }
        public Book GetBookbyId(int bookId) => _context.Books.FirstOrDefault(n => n.Id == bookId);
    }
    
}
