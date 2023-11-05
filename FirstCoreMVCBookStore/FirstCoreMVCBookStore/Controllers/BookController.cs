using System.Collections.Generic;
using FirstCoreMVCBookStore.Models;
using FirstCoreMVCBookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FirstCoreMVCBookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }

        public BookModel GetBookById(int Id)
        {
            return _bookRepository.GetBookById(Id);
        }

        public List<BookModel> SearchBooks(string Title, string Author)
        {
            return _bookRepository.SearchBook(Title, Author);
        }
    }
}
