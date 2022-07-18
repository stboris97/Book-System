using BookSystem.Interfaces;
using BookSystem.Models;
using BookSystem.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BookSystem.Test")]
namespace BookSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
              .AddSingleton<IBookService, BookService>()
              .AddSingleton<IFileService, FileService>()
              .BuildServiceProvider();

            var bookService = serviceProvider.GetService<IBookService>();
            
            var books = bookService.GetBooks();
            
            var states = new List<string>() { "CO", "NJ" };
            
            var filteredBooks = bookService.FilterBooksByStates(books, states);

            var groupedBooks = bookService.GroupAndOrderBooksByParentName(filteredBooks);
            
            var fileService = serviceProvider.GetService<IFileService>();
            fileService.WriteAllBooks(groupedBooks, "C:/Users/Boris/Desktop/git book system/exportData.txt");
        }
    }
}
