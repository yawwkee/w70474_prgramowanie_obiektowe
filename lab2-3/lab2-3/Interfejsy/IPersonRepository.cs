using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2_3.lab6;

namespace lab2_3.Interfejsy
{
    public interface IPersonRepository : IBaseRepository<Person, int>
    {
        List<Book> GetBorrowedBook(int id);
        void BorrowBook(int id, Book book);
    }

}
