using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(); //memory allocation, members get initialized to default values
            book1._BookId = 100;
            book1._BookName = "asp programming";
            Console.WriteLine($"Book details: {book1._BookId} , {book1._BookName}");

            book1.DisplayBook();
            Book book2 = new Book(101, "asp.net mvc", "xyz");
            book2.DisplayBook();
            

            /*book1.bookId = 101; //unique
            book1.bookName = "Learning C#";
            book1.bookAuthor = "Wrox";
            Console.WriteLine($"Book details: {book1.bookId} , {book1.bookName} , {book1.bookAuthor}");*/
            //Console.WriteLine(book1.ToString());
            Console.ReadLine();
        }
    }
}

