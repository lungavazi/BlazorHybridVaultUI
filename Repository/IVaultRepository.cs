using VaultUI.Data.Dto;

namespace VaultUI.Repository
{
    public interface IVaultRepository
    {
        Task<IEnumerable<PolicyDto>> GetPoliciesAsync(string userName, string policyName);
        Task<IEnumerable<BeneficiaryDto>> GetBeneficiariesAsync(string userName, string beneficiaryName);
        Task<IEnumerable<AccountDto>> GetAccountsAsync(string userName, string accountName);
        Task<UserInfoDto> GetUserInfoAsync(string userName);    
        Task<DashboardDto> GetDashboardInfoAsync(string userName);    
    }
}