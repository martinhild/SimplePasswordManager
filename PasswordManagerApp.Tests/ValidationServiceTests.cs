
using PasswordManagerApp.Services;
namespace PasswordManagerApp.Tests
{
    public class ValidationServiceTests
    {
        [Theory]
        [InlineData("", "abc123", "Notiz", "Benutzername leer.")]
        [InlineData("user", "", "Notiz", "Passwort leer.")]
        [InlineData("user", "abc123", "", "Beschreibung leer.")]
        [InlineData("user", "abc", "Notiz", "Passwort zu kurz (mind. 6 Zeichen).")]
        [InlineData("user", "abc123", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", "Beschreibung zu lang. (max. 40 Zeichen)")]
        public void IsValidEntry_InvalidInput_ReturnsFalseAndErrorMessage(
            string username, string password, string description, string expectedError)
        {
            // Act
            bool result = ValidationService.IsValidEntry(username, password, description, out string error);

            // Assert
            Assert.False(result);
            Assert.Equal(expectedError, error);
        }

        [Fact]
        public void IsValidEntry_ValidInput_ReturnsTrue()
        {
            bool result = ValidationService.IsValidEntry("user", "securePass123", "Beschreibung", out string error);

            Assert.True(result);
            Assert.Equal("", error);
        }
    }
}