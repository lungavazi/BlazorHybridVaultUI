
using VaultUI.Data.Dto;
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
        public async Task<LoginResponseDto?> LoginAsync(LoginRequestDto loginRequest)
        {
            return await _apiClient.PostAsync<LoginRequestDto, LoginResponseDto>("auth/login", loginRequest);
        }

        public async Task<IEnumerable<AccountDto>> GetAccountsAsync(string userName, string accountName)
        {
            var result = await _apiClient.GetAsync<IEnumerable<AccountDto>>($"accounts/{userName}?accountName={accountName}");
            return result ?? Enumerable.Empty<AccountDto>();
        }
        public async Task<IEnumerable<BeneficiaryDto>> GetBeneficiariesAsync(string userName, string beneficiaryName)
        {
            var result = await _apiClient.GetAsync<IEnumerable<BeneficiaryDto>>($"beneficiaries/{userName}?beneficiaryName={beneficiaryName}");
            return result ?? Enumerable.Empty<BeneficiaryDto>();
            
        }
        public async Task<DashboardDto> GetDashboardInfoAsync(string userName)
        {
            var result = await _apiClient.GetAsync< DashboardDto> ($"vaultdashboard/{userName}");
            return result ?? new DashboardDto();
        }
        public async Task<IEnumerable<PolicyDto>> GetPoliciesAsync(string userName, string policyName)
        {
            var result = await _apiClient.GetAsync<IEnumerable<PolicyDto>>($"insurances/{userName}?insuranceName={policyName}");
            return result ?? Enumerable.Empty<PolicyDto>();
        }
        public async Task<UserInfoDto> GetUserInfoAsync(string userName)
        {
            var result = await _apiClient.GetAsync<UserInfoDto>($"user/{userName}");
            return result ?? new UserInfoDto();
        }

        public async Task<long> PostPolicyAsync(InsuranceCreateDto insurance)
        {
            var result = await _apiClient.PostAsync<InsuranceCreateDto, long>( "insurance", insurance);
            return result;
        }

        public async Task<long> PostAccountAsync(AccountCreateDto account)
        {
            var result = await _apiClient.PostAsync<AccountCreateDto, long>("account", account);             
            return result;
        }

        public async Task<long> PostBeneficiaryAsync(BeneficiaryCreateDto beneficiary)
        {
            var result = await _apiClient.PostAsync<BeneficiaryCreateDto, long>("beneficiary", beneficiary);
            return result;
        }

        public async Task PutBeneficiaryAsync(long id, BeneficiaryUpdateDto beneficiaryUpdateDto)
        {
            await _apiClient.PutAsync($"beneficiary/{id}", beneficiaryUpdateDto);
        }
        public async Task PutAccountAsync(long id, AccountUpdateDto account)
        {
            await _apiClient.PutAsync($"account/{id}", account);
        }

        public async Task PutInsuranceAsync(long id, InsuranceUpdateDto insurance)
        {
            await _apiClient.PutAsync($"insurance/{id}", insurance);
        }

        public async Task DeleteBeneficiaryAsync(long id)
        {
            await _apiClient.DeleteAync<long>($"beneficiary/{id}");
        }

        public async Task DeleteAccountAsync(long id)
        {
            await _apiClient.DeleteAync<long>($"account/{id}");
        }

        public async Task DeleteInsuranceAsync(long id)
        {
            await _apiClient.DeleteAync<long>($"insurance/{id}");
        }

    }
}
