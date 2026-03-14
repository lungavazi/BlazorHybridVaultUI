
using VaultUI.Data.Dto;
using VaultUI.Helpers;
using VaultUI.Http;

namespace VaultUI.Repository
{
    public class VaultRepository : IVaultRepository
    {
        private readonly ApiClient _apiClient;

        public VaultRepository(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }
        public async Task<IEnumerable<AccountDto>> GetAccountsAsync(string userName, string accountName)
        {
            var url = $"accounts/{userName}?accountName={accountName}";

            var result = await _apiClient.GetAsync<IEnumerable<AccountDto>>(url);

            return result ?? Enumerable.Empty<AccountDto>();
        }
        public async Task<IEnumerable<BeneficiaryDto>> GetBeneficiariesAsync(string userName, string beneficiaryName)
        {
            var url = $"beneficiaries/{userName}?beneficiaryName={beneficiaryName}";

            var result = await _apiClient.GetAsync<IEnumerable<BeneficiaryDto>>(url);

            return result ?? Enumerable.Empty<BeneficiaryDto>();
            
        }
        public async Task<DashboardDto> GetDashboardInfoAsync(string userName)
        {var url = $"vaultdashboard/{userName}";

            var result = await _apiClient.GetAsync< DashboardDto> (url);

            return result ?? new DashboardDto();
        }
        public async Task<IEnumerable<PolicyDto>> GetPoliciesAsync(string userName, string policyName)
        {
            var url = $"insurances/{userName}?insuranceName={policyName}";

            var result = await _apiClient.GetAsync<IEnumerable<PolicyDto>>(url);

            return result ?? Enumerable.Empty<PolicyDto>();
        }
        public async Task<UserInfoDto> GetUserInfoAsync(string userName)
        {
            var url = $"user/{userName}";

            var result = await _apiClient.GetAsync<UserInfoDto>(url);

            return result ?? new UserInfoDto();
        }

        public async Task<long> PostPolicyAsync(InsuranceCreateDto insurance)
        {
            var result = await _apiClient.PostAsync<InsuranceCreateDto, long>(
                "insurance", insurance);

            return result;
        }

        public async Task<long> PostAccountAsync(AccountCreateDto account)
        {
            var result = await _apiClient.PostAsync<AccountCreateDto, long>(
                "account", account);

            return result;
        }

        public async Task<long> PostBeneficiaryAsync(BeneficiaryCreateDto beneficiary)
        {
            var result = await _apiClient.PostAsync<BeneficiaryCreateDto, long>(
                "beneficiary", beneficiary);

            return result;
        }
    }
}
