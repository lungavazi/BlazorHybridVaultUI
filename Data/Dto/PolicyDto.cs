using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VaultUI.Data.Dto
{
    public class PolicyDto
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
        [JsonPropertyName("beneficiaryId")]
        public long BeneficiaryId { get; set; }
        [JsonPropertyName("insuranceType")]
        public string InsuranceType { get; set; }
        [JsonPropertyName("insuranceNo")]
        public string InsuranceNo { get; set; }
        [JsonPropertyName("dateOpened")]
        public DateTime DateOpened { get; set; }
    }
}
