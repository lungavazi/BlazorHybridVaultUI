using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using VaultUI.Helpers;

namespace VaultUI.Data.Dto
{
    public class UserInfoDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
        [JsonPropertyName("idNumber")]
        public string IdNumber { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("surname")]
        public string Surname { get; set; }
        [JsonPropertyName("cellNo")]
        public string telephone { get; set; }
        [JsonPropertyName("subscribedPeriod")]
        public CycleType? SubscribedPeriod { get; set; }
        [JsonPropertyName("subscribedAt")]
        public DateTime? SubscribedAt { get; set; }
        [JsonPropertyName("isSubscribed")]
        public Boolean? IsSubscribed { get; set; }

    }
}
