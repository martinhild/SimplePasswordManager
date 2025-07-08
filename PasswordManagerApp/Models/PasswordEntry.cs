
namespace PasswordManagerApp.Models
{
    public class PasswordEntry
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string EncryptedPassword { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
