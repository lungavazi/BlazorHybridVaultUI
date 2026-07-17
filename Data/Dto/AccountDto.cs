using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VaultUI.Data.Dto
{
    public class AccountDto
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("userId")]
        public long UserId { get; set; }
        [JsonPropertyName("beneficiaryIds")]
        public List<long> BeneficiaryIds { get; set; } = new List<long>();
        [JsonPropertyName("accountType")]
        public string AccountType { get; set; }
        [JsonPropertyName("accountNo")]
        public string AccountNo { get; set; }
        [JsonPropertyName("dateOpened")]
        public DateTime DateOpened { get; set; }
    }
}
