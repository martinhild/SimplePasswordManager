namespace PasswordManagerApp.Models
{
    public class MasterConfig
    {
        public int Id { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }
    }
}
