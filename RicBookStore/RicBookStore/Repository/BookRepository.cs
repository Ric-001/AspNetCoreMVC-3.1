using RicBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RicBookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(b => b.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(b => b.Title.Contains(title)).Where(b => b.Author.Contains(authorName)).ToList();
        }

        public List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id=1, Title="El Temor de un Hombre Sabio", Author="Patrick Rothfuss"},
                new BookModel() { Id=2, Title="El Problema de los tres cuerpos", Author="Liu Cixin"},
                new BookModel() { Id=3, Title="Vientos de Invierno", Author="George R. R. Martin"},
                new BookModel() { Id=4, Title="El Señor de los Anillos", Author="J. R. R. Tolkien"},
                new BookModel() { Id=5, Title="La espada del destino", Author="Andrzej Sapkowski"}
            };
        }
    }
}
