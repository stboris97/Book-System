using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSystem.Models
{
    public class Book
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }
        [JsonProperty(PropertyName = "abbr")]
        public string Abbr { get; set; }
        [JsonProperty(PropertyName = "source_name")]
        public string SourceName { get; set; }
        [JsonProperty(PropertyName = "meta")]
        public Meta Meta { get; set; }
        [JsonProperty(PropertyName = "parent_name")]
        public string ParentName { get; set; }
        [JsonProperty(PropertyName = "book_parent_id")]
        public string BookParentId { get; set; }
        [JsonProperty(PropertyName = "affiliate_id")]
        public string AffiliateId { get; set; }
    }
}
