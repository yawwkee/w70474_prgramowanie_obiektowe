using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3.Interfejsy
{
    public interface IPersonRepository : IBaseRepository<Person, int>
    {
        IEnumerable<Book> GetBorrowedBooks(int personId);
        void AddBookToPerson(int personId, Book book);
    }

}
