using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaultUI.Data.Dto
{
    public class WillCreateRequestDto
    {
        public long? Id { get; set; }
        public string? Username { get; set; }
        public string? InstitutionName { get; set; }
        public string? InstitutionAddress { get; set; }
        public string? ContactName { get; set; }
        public string? ContactRole { get; set; }
        public string? ContactPhone { get; set; }
        public string? ContactEmail { get; set; }
        public string? Notes { get; set; }
    }


  
}
