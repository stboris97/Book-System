using BookSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem.Interfaces
{
    public interface IBookService
    {
        public Books GetBooks();
        public Books FilterBooksByStates(Books books, List<string> states);
        public IEnumerable<IGrouping<string, Book>> GroupAndOrderBooksByParentName(Books books, bool byAsc = true);
    }
}
