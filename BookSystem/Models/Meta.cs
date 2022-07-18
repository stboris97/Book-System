using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSystem.Models
{
    public class Meta
    {
        [JsonProperty(PropertyName = "logos")]
        public Logos Logos{ get; set; }
        [JsonProperty(PropertyName = "states")]
        public List<string> States { get; set; }
        [JsonProperty(PropertyName = "website")]
        public string Website { get; set; }
        [JsonProperty(PropertyName = "deeplink")]
        public DeepLink DeepLink { get; set; }
        [JsonProperty(PropertyName = "is_legal")]
        public bool IsLegal { get; set; }
        [JsonProperty(PropertyName = "is_preferred")]
        public bool IsPreferred { get; set; }
        [JsonProperty(PropertyName = "primary_color")]
        public string PrimaryColor { get; set; }
        [JsonProperty(PropertyName = "betsync_status")]
        public string BetsyncStatus { get; set; }
        [JsonProperty(PropertyName = "secondary_color")]
        public string SecondaryColor { get; set; }
        [JsonProperty(PropertyName = "is_fastbet_enabled_app")]
        public bool IsFastbetEnabledApp { get; set; }
        [JsonProperty(PropertyName = "is_fastbet_enabled_web")]
        public bool IsFastbetEnabledWeb { get; set; }
    }
}
