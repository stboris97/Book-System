using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSystem.Models
{
    public class Books
    {
        [JsonProperty(PropertyName = "books")]
        public List<Book> BooksList { get; set; }
    }
}
