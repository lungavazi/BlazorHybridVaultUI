using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaultUI.Data.Dto
{
    public class InsuranceCreateDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public long BeneficiaryId { get; set; }
        public string InsuranceType { get; set; }
        public string InsuranceNo { get; set; }
        public DateTime DateOpened { get; set; }
    }
}
