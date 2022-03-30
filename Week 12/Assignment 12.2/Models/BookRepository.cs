using System.Collections.Generic;

namespace Assignment12._2._2.Models
{
    //step 3 - create repository class to utilize interface
    public class BookRepository : IBookRepository
    {
        public List<Book> Books { get; set; }

        public Book GetBookById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return Books.Find(x => x.Id == id);
            }
        }

        public List<Book> InitializeData()
        {
            Books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Name = "Harry Potter and the Sorcerer's Stone",
                    Author = "JK Rowling",
                    Description = "The first novel in the Harry Potter series and Rowling's debut novel, it follows Harry Potter, a young wizard who discovers his magical heritage on his eleventh birthday, when he receives a letter of acceptance to Hogwarts School of Witchcraft and Wizardry. Harry makes close friends and a few enemies during his first year at the school, and with the help of his friends, he faces an attempted comeback by the dark wizard Lord Voldemort, who killed Harry's parents, but failed to kill Harry when he was just 15 months old.",
                    ImageName = "sorcerersStone.jpg"
                },
                new Book()
                {
                    Id = 2,
                    Name = "Harry Potter and the Chamber of Secrets",
                    Author = "JK Rowling",
                    Description = "The second novel in the Harry Potter series, following Harry's second year at Hogwarts School of Witchcraft and Wizardry, during which a series of messages on the walls of the school's corridors warn that the Chamber of Secrets has been opened and that the heir of Slytherin would kill all pupils who do not come from all-magical families. These threats are found after attacks that leave residents of the school petrified. Throughout the year, Harry and his friends Ron and Hermione investigate the attacks.",
                    ImageName = "chamberSecrets.jpg"
                },new Book()
                {
                    Id = 3,
                    Name = "Harry Potter and the Prisoner of Azkaban",
                    Author = "JK Rowling",
                    Description = "This book follows Harry Potter, a young wizard, in his third year at Hogwarts School of Witchcraft and Wizardry. Along with friends Ronald Weasley and Hermione Granger, Harry investigates Sirius Black, an escaped prisoner from Azkaban, the wizard prison, believed to be one of Lord Voldemort's old allies.",
                    ImageName = "prisonerAzkaban.jpg"
                },new Book()
                {
                    Id = 4,
                    Name = "Harry Potter and the Goblet of Fire",
                    Author = "JK Rowling",
                    Description = "The fourth novel in the Harry Potter series. It follows Harry Potter, a wizard in his fourth year at Hogwarts School of Witchcraft and Wizardry, and the mystery surrounding the entry of Harry's name into the Triwizard Tournament, in which he is forced to compete.",
                    ImageName = "gobletFire.jpg"
                },new Book()
                {
                    Id = 5,
                    Name = "Harry Potter and the Order of the Phoenix",
                    Author = "JK Rowling",
                    Description = "The fifth novel in the Harry Potter series. It follows Harry Potter's struggles through his fifth year at Hogwarts School of Witchcraft and Wizardry, including the surreptitious return of the antagonist Lord Voldemort, O.W.L. exams, and an obstructive Ministry of Magic.",
                    ImageName = "orderPhoenix.jpg"
                },new Book()
                {
                    Id = 6,
                    Name = "Harry Potter and the Half Blood Prince",
                    Author = "JK Rowling",
                    Description = "The sixth and penultimate novel in the Harry Potter series. Set during Harry Potter's sixth year at Hogwarts, the novel explores the past of the boy wizard's nemesis, Lord Voldemort, and Harry's preparations for the final battle against Voldemort alongside his headmaster and mentor Albus Dumbledore.",
                    ImageName = "halfbloodPrince.jpg"
                },new Book()
                {
                    Id = 7,
                    Name = "Harry Potter and the Deathly Hallows",
                    Author = "JK Rowling",
                    Description = "The seventh and final novel of the main Harry Potter series. The novel chronicles the events directly following Harry Potter and the Half-Blood Prince and the final confrontation between the wizards Harry Potter and Lord Voldemort.",
                    ImageName = "deathlyHallows.jpg"
                }
            };
            return Books;
        }
    }
}
