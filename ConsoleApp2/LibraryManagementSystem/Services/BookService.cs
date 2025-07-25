using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ConsoleApp2.LibraryManagementSystem.Models;

namespace ConsoleApp2.LibraryManagementSystem.Services
{
    public class BookService
    {
         List<Book> books = new List<Book>();


        public void LoadBooksFromJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<Book> loadedBooks = JsonSerializer.Deserialize<List<Book>>(json);
                books.AddRange(loadedBooks);
                Console.WriteLine("Books Loaded from Json");
            }
            else
            {
                Console.WriteLine("File Not Found :" + filePath);
            }
        }

        public void ViewBooks()
        {
            Console.WriteLine("Books List : ");
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id}:{book.Title} by {book.Author}");
            }
        }
    }
}
