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

        public async Task<LoginResponseDto?> LoginAsync(LoginRequestDto loginRequest)
        {
            return await _vaultRepository.LoginAsync(loginRequest);
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
        public async Task<WillResponseDto?> GetWillAsync(string username)
        {
            return await _vaultRepository.GetWillAsync(username);
        }
        public async Task<long> CreateBeneficiaryAsync(BeneficiaryCreateDto beneficiary)
        {
            return await _vaultRepository.PostBeneficiaryAsync(beneficiary);
        }
        public async Task<long> CreateInsuranceAsync(InsuranceCreateDto insurance)
        {
            return await _vaultRepository.PostPolicyAsync(insurance);
        }
        public async Task<long> CreateAccountAsync(AccountCreateDto account)
        {
            return await _vaultRepository.PostAccountAsync(account);
        }
        public async Task UpdateBeneficiaryAsync(long id, BeneficiaryUpdateDto beneficiary)
        {
            await _vaultRepository.PutBeneficiaryAsync(id, beneficiary);
        }
        public async Task UpdateAccountAsync(long id, AccountUpdateDto account)
        {
            await _vaultRepository.PutAccountAsync(id, account);
        }
        public async Task UpdateInsuranceAsync(long id, InsuranceUpdateDto insurance)
        {
            await _vaultRepository.PutInsuranceAsync(id, insurance);
        }
        public async Task DeleteBeneficiaryAsync(long id)
        {
            await _vaultRepository.DeleteBeneficiaryAsync(id);
        }
        public async Task DeleteAccountAsync(long id)
        {
            await _vaultRepository.DeleteAccountAsync(id);
        }
        public async Task DeleteInsuranceAsync(long id)
        {
            await _vaultRepository.DeleteInsuranceAsync(id);
        }
        public async Task<SignUpResponseDto?> SignUpAsync(SignUpRequestDto signUpRequest)
        {
            return await _vaultRepository.SignUpAsync(signUpRequest);
        }
        public async Task<long> CreateUpdateWill(WillCreateRequestDto willCreateRequest)
        {
            return await _vaultRepository.CreateUpdateWill(willCreateRequest);
        }
    }
}
