using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2_3.Interfejsy;

namespace lab2_3.lab6
{
    public class Book : IEntity<int>, ICreated
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public DateTime CreatedDate { get; set; }

        public Book(int id, string title, string author, int year)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
            CreatedDate = DateTime.Now;
        }
    }

}
