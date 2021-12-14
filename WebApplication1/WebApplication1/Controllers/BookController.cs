using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BookController:Controller
    {
        private readonly BookRepository _bookRepository=null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }
        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }
        public List<BookModel> SearchBook(string BookName,string AuthorName)
        {
            return _bookRepository.SearchBook(BookName, AuthorName);
        }
    }
}
