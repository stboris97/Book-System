using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSystem.Models
{
    public class Logos
    {
        [JsonProperty(PropertyName = "promo")]
        public string Promo { get; set; }
        [JsonProperty(PropertyName = "primary")]
        public string Primary { get; set; }
        [JsonProperty(PropertyName = "thumbnail")]
        public string Thumbnail { get; set; }
        [JsonProperty(PropertyName = "betslip_carousel")]
        public string BetslipCarousel { get; set; }
    }
}
