namespace VaultUI.Data.Dto
{
    public class SignUpRequestDto
    {
        public string Username { get; set; } = string.Empty;
        public string IdNumber { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string CellPhone { get; set; } = string.Empty;
    }

    public class SignUpResponseDto
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}