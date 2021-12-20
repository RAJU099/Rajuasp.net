using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id==id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="maths",Author="Rd sharma" },
                 new BookModel(){Id=1,Title="math",Author="Rd barman" },
                  new BookModel(){Id=2,Title="maths",Author="Rd ramu" },
                   new BookModel(){Id=3,Title="maths",Author="Rd ketu" }


            };
        }
       
    }
}
