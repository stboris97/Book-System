using BookSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookSystem.Interfaces
{
    public interface IFileService
    {
        public void WriteAllBooks(IEnumerable<IGrouping<string, Book>> groupings, string fileName);
    }
}
