
using System.Security.Cryptography;
using System.Text;

namespace PasswordManagerApp.Services
{
    public class MasterPasswordService
    {
        private string GenerateSalt()
        {
            // Erzeuge ein Byte-Array der Länge x            
            byte[] saltBytes = new byte[16];
            // Fülle mit Zufallsdaten
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(saltBytes);
            // in String umwandeln
            return Convert.ToBase64String(saltBytes);
        }

        private string HashPassword(string pw, string salt)
        {
            // Salt wieder in Bytes zurückwandeln
            byte[] saltBytes = Convert.FromBase64String(salt);
            byte[] pwdBytes = Encoding.UTF8.GetBytes(pw);
            // zusammenfügen
            byte[] combined = saltBytes.Concat(pwdBytes).ToArray();
            // Hashen
            using var sha = SHA256.Create();
            byte[] hashBytes = sha.ComputeHash(combined);
            // Hash als Base64 zurückgeben.
            return Convert.ToBase64String(hashBytes);
        }
        public void SetMasterPassword(string pw)
        {
            if (string.IsNullOrWhiteSpace(pw))
                throw new ArgumentException("Masterpasswort darf nicht leer sein.", nameof(pw));

            string salt = GenerateSalt();
            string hash = HashPassword(pw, salt);
            var dbs = new DatabaseService();
            dbs.SaveMasterConfig(hash, salt);
        }

        public bool IsMasterPasswordSet()
        {           
            var masterconfig = new DatabaseService().GetMasterConfig();            
            return masterconfig != null
                && !string.IsNullOrWhiteSpace(masterconfig.Hash);
            // masterconfig != null und Hash ist nicht leer.
        }

        public bool VerifyMasterPassword(string pw)
        {
            var masterconfig = new DatabaseService().GetMasterConfig();
            if (masterconfig == null)
                return false;  
            // Hash neu berechnen mit dem alten Salt
            string hash = HashPassword(pw, masterconfig.Salt);
            return hash == masterconfig.Hash;
        }
    }
}
