using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._0
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public string ISBN { get; set; }

        public Book(int id, string title, string author, int yearPublished, string isbn)
        {
            Id = id;
            Title = title;
            Author = author;
            YearPublished = yearPublished;
            ISBN = isbn;
        }
    }


    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public bool RemoveBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);
                return true;
            }
            return false;
        }

        public List<Book> SearchByTitle(string title)
        {
            return books.Where(b => b.Title.Contains(title)).ToList();
        }

        public List<Book> SearchByAuthor(string author)
        {
            return books.Where(b => b.Author.Contains(author)).ToList();
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }
    }
}
