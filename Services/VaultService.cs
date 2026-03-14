
using System.Runtime.CompilerServices;
using VaultUI.Data.Dto;
using VaultUI.Repository;

namespace VaultUI.Services
{
    public class VaultService 
    {
        private readonly IVaultRepository _vaultRepository;

        public VaultService(IVaultRepository vaultRepository)
        {
            _vaultRepository = vaultRepository;
        }

        public async Task<IEnumerable<PolicyDto>> GetPoliciesAsync(string username, string policyName)
        {
            return await _vaultRepository.GetPoliciesAsync(username, policyName);
        }
        public async Task<IEnumerable<AccountDto>> GetAccoutsAsync(string username, string accountName)
        {
            return await _vaultRepository.GetAccountsAsync(username, accountName);
        }
        public async Task<IEnumerable<BeneficiaryDto>> GetBeneficiariesAsync(string username, string beneficiaryName)
        {
            return await _vaultRepository.GetBeneficiariesAsync(username, beneficiaryName);
        }
        public async Task<UserInfoDto> GetUserInfoAsync(string username)
        {
            return await _vaultRepository.GetUserInfoAsync(username);
        }
        public async Task<DashboardDto> GetDashboardAsync(string username)
        {
            return await _vaultRepository.GetDashboardInfoAsync(username);
        }
    }
}
