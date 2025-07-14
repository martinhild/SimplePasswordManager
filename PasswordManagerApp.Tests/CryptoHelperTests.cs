
using PasswordManagerApp.Services;
using System.Security.Cryptography;
namespace PasswordManagerApp.Tests
{
    public class CryptoHelperTests
    {
        [Fact]
        public void EncryptDecrypt_ReturnsOriginalText()
        {
            string toEncrypt = "123: Ich bin unverschlüsselt!!!";
            string encryptionPassword = "Verschlüsselungs_Passwort_123";
            string encrypted = CryptoHelper.Encrypt(toEncrypt, encryptionPassword);
            string decrypted = CryptoHelper.Decrypt(encrypted, encryptionPassword);
            Assert.Equal(toEncrypt, decrypted);                
        }

        [Fact]
        public void Decrypt_WithWrongPassword_ThrowsException()
        {           
            string toEnrcypt = "Geheimer Text";
            string encryptionPassword = "Richtig123";
            string wrongEncryptionPassword = "Falsch456";

            string encrypted = CryptoHelper.Encrypt(toEnrcypt, encryptionPassword);

            Assert.Throws<CryptographicException>(() => CryptoHelper.Decrypt(encrypted, wrongEncryptionPassword));
        }
    }
}
