
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2_3.Interfejsy;

namespace lab2_3.lab6
{
    public class Person : IEntity<int>, ICreated
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();
        public DateTime CreatedDate { get; set; }

        public Person(int id, string firstName, string lastName, int age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            CreatedDate = DateTime.Now;
        }
    }

}
