using BookSystem.Interfaces;
using BookSystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;

namespace BookSystem.Services
{
    public  class BookService : IBookService
    {
        private string ApiBaseUrl { get; set; }

        public BookService()
        {
            ApiBaseUrl = Constants.BookApiBaseUrl;
        }

        public Books GetBooks()
        {
            try
            {
                Books books = new Books();
                using (var httpClient = new WebClient())
                {
                    var response = httpClient.DownloadString($"{ApiBaseUrl}/books");
                    books = JsonConvert.DeserializeObject<Books>(response);
                }
                return books;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Books FilterBooksByStates(Books books, List<string> states)
        {
            if (books == null)
            {
                return null;
            }

            return new Books()
            {
                BooksList = books?.BooksList.Where(b => b.Meta.States.Any(s => states.Contains(s)) && b.ParentName != null).ToList()
            };
        }

        public IEnumerable<IGrouping<string, Book>> GroupAndOrderBooksByParentName(Books books, bool byAsc = true)
        {
            if (books == null)
            {
                return null;
            }

            var groupedBooks = books?.BooksList.GroupBy(b => b.ParentName);

            return byAsc ? groupedBooks.OrderBy(g => g.Key) : groupedBooks.OrderByDescending(g => g.Key);
        }
    }
}
