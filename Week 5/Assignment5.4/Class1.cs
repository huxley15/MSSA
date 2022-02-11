using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._4
{
    public enum Genre
    {
        Biography,
        Children,
        Fantasy,
        Fiction,
        NonFiction,
        SciFi
    }

    public class Library
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public Genre BookGenre { get; set; }
    }
    public class BookRepository
    {
        private List<Library> booklist;
        public BookRepository()
        {
            Random random = new Random();
            booklist = new List<Library>()
            {
                new Library() { Id=random.Next(100000,999999), Title="The Fellowship of the Ring", Author="Tolkien", BookGenre=Genre.Fantasy },
                new Library() { Id=random.Next(100000,999999), Title="The Two Towers", Author="Tolkien", BookGenre=Genre.Fantasy },
                new Library() { Id=random.Next(100000,999999), Title="The Return of the King", Author="Tolkien", BookGenre=Genre.Fantasy },
                new Library() { Id=random.Next(100000,999999), Title="The Hobbit", Author="Tolkien", BookGenre=Genre.Fantasy }
            };
        }
        public List<Library> GetBooks()
        {
            return booklist;
        }
        public void AddBook(Library newbook)
        {
            booklist.Add(newbook);
        }
        public void DeleteBook(int index)
        {
            booklist.RemoveAt(index);
        }
    }

    
}
