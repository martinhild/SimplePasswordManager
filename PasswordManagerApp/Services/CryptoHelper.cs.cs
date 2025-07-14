
using System.Security.Cryptography;
using System.Text;
namespace PasswordManagerApp.Services
{
    public static class CryptoHelper
    {
        /// <summary>
        /// Verschlüsselt einen Text mit AES-256.
        /// 1. Salt erzeugen - verhindert Rainbow-Angriffe
        /// 2. PBKDF2 - leitet AES-Key aus Passwort + Salt ab
        /// 3. IV erzeugen - macht Verschlüsselung zufällig
        /// 4. Klartext - AES - CryptoStream - MemoryStream
        /// 5. Salt + IV + Ciphertext - kombiniert
        /// 6. Rückgabe: Base64-String zur Speicherung
        /// </summary>
        public static string Encrypt(string toEncrypt, string password)
        {
            // 1. Salt erzeugen (für Key-Derivation)
            byte[] salt = new byte[16];            
            using (var rng = RandomNumberGenerator.Create())
                rng.GetBytes(salt);

            // 2. Key ableiten (PBKDF2 mit SHA256)
            using var rfc = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256);
            byte[] aesKey = rfc.GetBytes(32);

            // 3. IV erzeugen (für AES)
            byte[] iv = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
                rng.GetBytes(iv);

            // 4. AES konfigurieren
            using var aes = Aes.Create();
            aes.Key = aesKey;
            aes.IV = iv;

            // 5. Klartext verschlüsseln → cipherBytes
            using var ms = new MemoryStream();
            using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
            {
                byte[] plainBytes = Encoding.UTF8.GetBytes(toEncrypt);
                cs.Write(plainBytes, 0, plainBytes.Length);
                cs.FlushFinalBlock();
            }
            byte[] cipherBytes = ms.ToArray();

            // 6. Salt + IV + Cipher zusammenfügen
            byte[] result = new byte[salt.Length + iv.Length + cipherBytes.Length];
            Buffer.BlockCopy(salt, 0, result, 0, salt.Length);
            Buffer.BlockCopy(iv, 0, result, salt.Length, iv.Length);
            Buffer.BlockCopy(cipherBytes, 0, result, salt.Length + iv.Length, cipherBytes.Length);

            // 7. Base64 für Speicherung
            return Convert.ToBase64String(result);
        }

        /// <summary>
        /// Entschlüsselt einen mit AES-256 verschlüsselten Base64-String.
        /// 1. Base64 dekodieren - Salt, IV und Cipher extrahieren
        /// 2. PBKDF2 (Key-Derivation) mit Salt + Passwort
        /// 3. AES konfigurieren mit Key + IV
        /// 4. Entschlüsseln über CryptoStream
        /// 5. Rückgabe: UTF-8 Klartext
        /// </summary>
        public static string Decrypt(string toDecrypt, string password)
        {
            // 1. Base64 dekodieren und Bestandteile extrahieren
            byte[] data = Convert.FromBase64String(toDecrypt);
            byte[] salt = data[0..16]; 
            byte[] iv = data[16..32]; 
            byte[] cipherBytes = data[32..]; 

            // 2. Key aus Passwort + Salt ableiten
            using var rfc = new Rfc2898DeriveBytes(password, salt, 100_000, HashAlgorithmName.SHA256);
            byte[] aesKey = rfc.GetBytes(32);

            // 3. AES konfigurieren mit Schlüssel + IV
            using var aes = Aes.Create();
            aes.Key = aesKey;
            aes.IV = iv;

            // 4. Entschlüsselung per CryptoStream
            using var ms = new MemoryStream(cipherBytes);
            using var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read);
            using var reader = new StreamReader(cs, Encoding.UTF8);
            string decrypted = reader.ReadToEnd();
            
            return decrypted;
        }
    }
}
