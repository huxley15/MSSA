using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Demo1
{
    
    //a structure is a value type user defined complex data structure that may represent real life object
    //and its a collection of basic data types like int, string, float
    struct Book
    {
        //member fields
        /*public int bookId;
        public string bookName;
        public string bookAuthor; */

        private int bookId;
        private string bookName;
        private string bookAuthor;
        //a constructor is a special function having the same name of the struct/class
        //which intializes the data memebers and allocates memory
        
        //1st way
        public Book(int id,string name, string author)
        {
            //initialization of the data members
            this.bookId = id;
            this.bookName = name;
            this.bookAuthor = author;
        }

        public string _BookName
        {
            get
            {
                return this.bookName;
            }
            //for a read only property, remove the set block
            set
            {
                //validations
                this.bookName = value;
            }
        }

        public string _BookAuthor
        {
            get
            {
                return this.bookAuthor;
            }
            set
            {
                this.bookName = value;
            }
        }
        public int _BookId
        {
            get
            {
                return this.bookId;
            }
            set
            {
                if (value >= 100)
                {
                    this.bookId = value;
                }
            }
        }
        public void DisplayBook()
        {
            Console.WriteLine($"Book details: {this.bookId}, {this.bookName}, {this.bookAuthor}"); 
        }
    }
}
