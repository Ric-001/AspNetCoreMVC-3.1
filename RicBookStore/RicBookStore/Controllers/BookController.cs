using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RicBookStore.Models;
using RicBookStore.Repository;

namespace RicBookStore.Controllers
{
    public class BookController : Controller
    {

        private readonly BookRepository bookRepository;
        public BookController()
        {
            bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = bookRepository.GetAllBooks();

            return View(data);
        }
        public ViewResult GetBook(int id)
        {
            var data = bookRepository.GetBookById(id);
            return View();
        }

        //public ViewResult SearchBook(string bookName, string authorName)
        public ViewResult SearchBook()
        {
            //var data = bookRepository.SearchBook(bookName, authorName);
            return View();
        }
    }
}
