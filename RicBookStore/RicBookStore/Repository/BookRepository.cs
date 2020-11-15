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
                new BookModel() { Id=1, Title="El Temor de un Hombre Sabio", Author="Patrick Rothfuss", Description="Es la continuación de El nombre del viento y pertenece a la serie Crónica del asesino de reyes"},
                new BookModel() { Id=2, Title="El Problema de los tres cuerpos", Author="Liu Cixin", Description="Es el primer libro de la trilogía titulada El recuerdo del pasado de la Tierra"},
                new BookModel() { Id=3, Title="Vientos de Invierno", Author="George R. R. Martin", Description="Vientos de invierno es la planeada sexta entrega de la serie de fantasía épica Canción de hielo y fuego"},
                new BookModel() { Id=4, Title="El Señor de los Anillos", Author="J. R. R. Tolkien", Description="El Señor de los Anillos es una novela de fantasía épica escrita por el filólogo y escritor británico J. R. R. Tolkien"},
                new BookModel() { Id=5, Title="La espada del destino", Author="Andrzej Sapkowski", Description="Es el segundo libro en La saga del brujo de Andrzej Sapkowski en términos de una cronología interna"},
                new BookModel() { Id=5, Title="Crónicas de la Dragonlance", Author="Margaret Weis, Tracy Hickman", Description="Aventuras de los Héroes de la Lanza y su enfrentamiento contra la diosa de la oscuridad Takhisis."},
                new BookModel() { Id=5, Title="El Elfo Oscuro", Author="R.A. Salvatore", Description="interminable saga de 26+1 libros (al menos por ahora)"}
            };
        }
    }
}
