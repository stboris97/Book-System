using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSystem.Models
{
    public class DeepLink
    {
        [JsonProperty(PropertyName = "has_multi")]
        public bool HasMulti { get; set; }
        [JsonProperty(PropertyName = "is_supported")]
        public bool IsSupported { get; set; }
    }
}
