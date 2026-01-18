using System.Text.Json.Serialization;

namespace VaultUI.Data.Dto
{
    public class BeneficiaryDto
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("userId")]
        public long UserId { get; set; }
        [JsonPropertyName("relationship")]
        public string Relationship { get; set; }
        [JsonPropertyName("cellNo")]
        public string CellNo { get; set; }
        [JsonPropertyName("secondaryTelephone")]
        public string SecondaryTelephone { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("secondaryEmail")]
        public string SecondaryEmail { get; set; }
        [JsonPropertyName("address")]
        public string Address { get; set; }
        [JsonPropertyName("dateOfBirth")]
        public string DateOfBirth { get; set; }
    }
}
