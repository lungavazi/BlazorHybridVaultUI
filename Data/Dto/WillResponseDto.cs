using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaultUI.Data.Dto
{
    public record WillResponseDto
    {
        public long Id { get; set; }
        //public long UserId { get; set; }
        public string Draft { get; set; } = string.Empty;
        //public DateTime DateCreated { get; set; }
        //public DateTime DateModified { get; set; }
        public IEnumerable<WillBeneficiaryResponseDto> Beneficiaries { get; set; } = Enumerable.Empty<WillBeneficiaryResponseDto>();
    }
        public record WillBeneficiaryResponseDto
    {
        public long BeneficiaryId { get; set; }
        public decimal Percentage { get; set; }
    }
}
