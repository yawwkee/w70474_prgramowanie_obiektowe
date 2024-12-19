﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2_3.Interfejsy;
using lab2_3.lab6;


    namespace Lab2.Lab6
    {
        public class PersonRepository : IPersonRepository
    {
            private List<Person> data = new List<Person>();

            public void Create(Person input)
            {
                input.Id = data.Count + 1;
                data.Add(input);
            }

            public Person Get(int id)
            {
                return data.Find(x => x.Id == id);
            }

        public IEnumerable<Person> GetAll()
        {
            return data;
        }

        public void Update(Person input)
            {
                var index = data.FindIndex(x => x.Id == input.Id);
                if (index > -1)
                    data[index] = input;
            }

            public void Delete(int id)
            {
                data.RemoveAll(x => x.Id == id);
            }

            public void BorrowBook(int id, Book book)
            {
                var person = Get(id);
                if (person == null)
                    return;

                person.BorrowedBooks.Add(book);
            }

            public List<Book> GetBorrowedBook(int id)
            {
                return Get(id).BorrowedBooks;
            }
        }
    }

