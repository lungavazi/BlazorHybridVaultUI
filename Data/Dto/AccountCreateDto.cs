using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaultUI.Data.Dto
{
    public class AccountCreateDto
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public long BeneficiaryId { get; set; }
        public string AccountType { get; set; }
        public string AccountNo { get; set; }
        public DateTime DateOpened { get; set; }
    }
}
