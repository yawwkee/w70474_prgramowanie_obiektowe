using System;
using System.Collections.Generic;
using System.Linq;
using lab2_3.Interfejsy;

namespace lab2_3.lab6
{
    public class BookRepository : IBookRepository
    {
        private List<Book> data = new List<Book>
        {
            new Book
            {
                Id = 1,
                CreationTime = DateTime.Now,
                Title = "Potop",
                Author = "Henryk Sienkiewicz",
                PublishDate = new DateTime(1886, 1, 1)
            }
        };

        public void Create(Book entity)
        {
            entity.Id = data.Count + 1;
            data.Add(entity);
        }

        public void Update(Book entity)
        {
            var index = data.FindIndex(x => x.Id == entity.Id);
            if (index > -1)
            {
                data[index] = entity;
            }
        }

        public void Delete(int id)
        {
            data.RemoveAll(x => x.Id == id);
        }

        public Book Get(int id)
        {
            return data.Find(x => x.Id == id);
        }

        public IEnumerable<Book> GetAll()
        {
            return data;
        }

        public IEnumerable<Book> GetBooksByAuthor(string author)
        {
            return data.Where(x => x.Author == author);
        }

        public IEnumerable<Book> GetBooksByYear(int year)
        {
            return data.Where(x => x.PublishDate.Year == year);
        }
    }
}
