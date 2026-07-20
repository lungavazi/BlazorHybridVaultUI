using VaultUI.Data.Dto;

namespace VaultUI.Repository
{
    public interface IVaultRepository
    {
        Task<LoginResponseDto?> LoginAsync(LoginRequestDto loginRequest);
        Task<IEnumerable<PolicyDto>> GetPoliciesAsync(string userName, string policyName);
        Task<IEnumerable<BeneficiaryDto>> GetBeneficiariesAsync(string userName, string beneficiaryName);
        Task<IEnumerable<AccountDto>> GetAccountsAsync(string userName, string accountName);
        Task<UserInfoDto> GetUserInfoAsync(string userName);
        Task<DashboardDto> GetDashboardInfoAsync(string userName);
        Task<long> PostPolicyAsync(InsuranceCreateDto insurance);
        Task<long> PostBeneficiaryAsync(BeneficiaryCreateDto beneficiRY);
        Task<long> PostAccountAsync(AccountCreateDto account);
        Task PutBeneficiaryAsync(long id, BeneficiaryUpdateDto beneficiry);
        Task PutAccountAsync(long id, AccountUpdateDto account);
        Task PutInsuranceAsync(long id, InsuranceUpdateDto insurance);
        Task DeleteBeneficiaryAsync(long id);
        Task DeleteAccountAsync(long id);
        Task DeleteInsuranceAsync(long id);
        Task<SignUpResponseDto?> SignUpAsync(SignUpRequestDto signUpRequest);
        Task<long> CreateUpdateWill(WillCreateRequestDto willCreateDto);
        Task<WillResponseDto> GetWillAsync(string userName);

        // Subscription endpoints
        Task<long> SubscribeAsync(SubscriptionCreateDto subscription);
        Task UnsubscribeAsync(string userName);
    }
}