
namespace PasswordManagerApp.Models
{
    public class PasswordEntry
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string EncryptedPassword { get; set; } = string.Empty;
        
        // Optionale Parameter:
        public PasswordEntry(string username = "", string encryptedPassword = "",
            string description = "")
        {
            Username = username;
            EncryptedPassword = encryptedPassword;
            Description = description;

        }
    }

    
}
