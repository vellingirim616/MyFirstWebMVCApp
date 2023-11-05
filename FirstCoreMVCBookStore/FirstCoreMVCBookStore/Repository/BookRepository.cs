using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using FirstCoreMVCBookStore.Models;

namespace FirstCoreMVCBookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int Id)
        {
            return DataSource().Where(x => x.Id == Id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string Title, string Author)
        {
            List<BookModel> list = DataSource().Where(x => x.Title.Contains(Title) && x.Author.Contains(Author)).ToList();
            return DataSource().Where(x => x.Title.Contains(Title) && x.Author.Contains(Author)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "MVC", Author = "Giri" },
                new BookModel() { Id = 2, Title = ".NET", Author = "Karthik" },
                new BookModel() { Id = 3, Title = "Java", Author = "Vijay" },
                new BookModel() { Id = 4, Title = "C#", Author = "Arun" },
                new BookModel() { Id = 5, Title = "Azure", Author = "Steve" }
            };
        }
    }
}
