using System.Text.Json.Serialization;

namespace VaultUI.Data.Dto
{
    public class VaultDashBoardDto
    {
        [JsonPropertyName("accountCount")]
        public int AccountCount { get; set; }
        [JsonPropertyName("beneficiaryCount")]
        public int BeneficiaryCount { get; set; }
        [JsonPropertyName("policyCount")]
        public int PolicyCount { get; set; }
        [JsonPropertyName("othertCount")]
        public int OtherCount { get; set; }
    }
}
