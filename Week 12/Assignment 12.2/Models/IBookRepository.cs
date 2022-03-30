using System.Collections.Generic;

namespace Assignment12._2._2.Models
{
    //step 2 create interface for basic CRUD
    public interface IBookRepository
    {
        List<Book> Books { get; set;  }
        List<Book> InitializeData();
        Book GetBookById(int? id);
    }
}
