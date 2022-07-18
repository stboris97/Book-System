using BookSystem.Interfaces;
using BookSystem.Models;
using BookSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Configuration;
using Xunit;

namespace BookSystem.Tests
{
    [TestClass]
    public class BookSystemTests
    {
        private readonly IBookService bookService;
        private readonly BookServiceMock bookServiceMock;
        public BookSystemTests()
        {
            bookService = new BookService();
            bookServiceMock = new BookServiceMock();
        }

        [TestMethod]
        public void GetBooksIsNotNullTest()
        {
            var result = bookService.GetBooks();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetBooksListTest()
        {
            var result = bookService.GetBooks();

            Assert.AreNotEqual(0, result.BooksList.Count);
        }

        [TestMethod]
        public void FilterBooksByStateIsNotNullTest()
        {
            var booksMock = bookServiceMock.GetBooksMock();
            var states = new List<string>() { "NY" };
            var result = bookService.FilterBooksByStates(booksMock, states);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void FilterBooksByStateResultCountTest()
        {
            var booksMock = bookServiceMock.GetBooksMock();
            var states = new List<string>() { "NJ" };
            var result = bookService.FilterBooksByStates(booksMock, states);

            Assert.AreEqual(2, result.BooksList.Count);
        }

        [TestMethod]
        public void GroupAndOrderBooksByParentNameIsNotNullTest()
        {
            var booksMock = bookServiceMock.GetBooksMock();
            var result = bookService.GroupAndOrderBooksByParentName(booksMock);

            Assert.IsNotNull(result);
        }

        
    }
}
