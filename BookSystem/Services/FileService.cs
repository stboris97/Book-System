using BookSystem.Interfaces;
using BookSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BookSystem.Services
{
    public class FileService : IFileService
    {
        public void WriteAllBooks(IEnumerable<IGrouping<string, Book>> groups, string fileName)
        {
            try
            {
                using (StreamWriter outputFile = new StreamWriter(fileName)) 
                {
                    foreach (var group in groups)
                    {
                        foreach (var book in group)
                        {
                            if (!string.IsNullOrEmpty(book.DisplayName) && !string.IsNullOrEmpty(book.ParentName) && book.Meta?.States.Count > 0)
                            {
                                outputFile.WriteLine("{" + book.ParentName + "} ");
                            
                                foreach(var state in book.Meta?.States)
                                {
                                    outputFile.WriteLine("{" + book.DisplayName + " " + state + "}" + "\n");
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
