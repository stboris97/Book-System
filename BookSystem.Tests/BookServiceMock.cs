using BookSystem.Interfaces;
using BookSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookSystem.Tests
{
    public class BookServiceMock
    {
        private readonly Books books;

        public BookServiceMock()
        {
            books = new Books();
            books.BooksList = new List<Book>();
            books.BooksList.Add(new Book()
            {
                Id = "1",
                Abbr = "A2",
                AffiliateId = "1",
                BookParentId = "5",
                DisplayName = "BookOne",
                Meta = new Meta()
                {
                    BetsyncStatus = "status",
                    DeepLink = new DeepLink()
                    {
                        HasMulti = true,
                        IsSupported = true
                    },
                    IsFastbetEnabledApp = true,
                    IsFastbetEnabledWeb = true,
                    IsLegal = false,
                    IsPreferred = false,
                    PrimaryColor = "green",
                    SecondaryColor = "red",
                    States = new List<string>()
                    {
                        "NY",
                        "NJ",
                        "AZ"
                    },
                    Website = "www.book.com",
                    Logos = new Logos()
                    {
                        BetslipCarousel = "nono",
                        Primary = "Yea",
                        Promo = "Promotion",
                        Thumbnail = "picture"
                    }

                },
                ParentName = "Parent Name of book",
                SourceName = "Source Nmae of book"
            });
            books.BooksList.Add(new Book()
            {
                Id = "2",
                Abbr = "A3",
                AffiliateId = "2",
                BookParentId = "6",
                DisplayName = "BookTwo",
                Meta = new Meta()
                {
                    BetsyncStatus = "status2",
                    DeepLink = new DeepLink()
                    {
                        HasMulti = true,
                        IsSupported = false
                    },
                    IsFastbetEnabledApp = true,
                    IsFastbetEnabledWeb = false,
                    IsLegal = true,
                    IsPreferred = false,
                    PrimaryColor = "blue",
                    SecondaryColor = "yellow",
                    States = new List<string>()
                    {
                        "NJ",
                        "AZ"
                    },
                    Website = "www.book2.com",
                    Logos = new Logos()
                    {
                        BetslipCarousel = "what",
                        Primary = "no yes",
                        Promo = "Promotion 2",
                        Thumbnail = "picture 2"
                    }

                },
                ParentName = "Parent Name of book 2",
                SourceName = "Source Nmae of book 2"
            });
            books.BooksList.Add(new Book()
            {
                Id = "3",
                Abbr = "A5",
                AffiliateId = "3",
                BookParentId = "7",
                DisplayName = "BookThree",
                Meta = new Meta()
                {
                    BetsyncStatus = "status3",
                    DeepLink = new DeepLink()
                    {
                        HasMulti = false,
                        IsSupported = true
                    },
                    IsFastbetEnabledApp = false,
                    IsFastbetEnabledWeb = true,
                    IsLegal = true,
                    IsPreferred = false,
                    PrimaryColor = "blue",
                    SecondaryColor = "red",
                    States = new List<string>()
                    {
                        "CA",
                        "OC"
                    },
                    Website = "www.book3.com",
                    Logos = new Logos()
                    {
                        BetslipCarousel = "what",
                        Primary = "no yeasdass",
                        Promo = "Promotion 3",
                        Thumbnail = "picture 3"
                    }

                },
                ParentName = "Parent Name of book 3",
                SourceName = "Source Nmae of book 3"
            });
        }

        public Books GetBooksMock()
        {
           return books;
        }
    }
}
