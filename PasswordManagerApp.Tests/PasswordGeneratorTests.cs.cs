
using PasswordManagerApp.Services;

namespace PasswordManagerApp.Tests
{
    public class PasswordGeneratorTests
    {        
        private PasswordGenerator _generator = new PasswordGenerator();

        [Fact]
        public void Generate_ReturnsPasswordWithCorrectLength()
        {
            string password = _generator.Generate(12, true, true, true);
            Assert.Equal(12, password.Length);  // Richtige Länge?
        }

        [Fact]
        public void Generate_WithOnlyLowercase_ReturnsCorrectLengthAndOnlyLowercase()
        {
            
            string result = _generator.Generate(length: 12, useUpper: false, useDigits: false, useSpecial: false);    
            
            Assert.Equal(12, result.Length);  // Richtige Länge?
            Assert.All(result, c => Assert.True(char.IsLower(c)));  // Alle elemente Kleinbuchstaben?
        }

        [Fact]
        public void Generate_WithUppercase_ContainsAtLeastOneUpper()
        {
            string result = _generator.Generate(length: 12, useUpper: true, useDigits: false, useSpecial: false);

            Assert.Contains(result, c => char.IsUpper(c));  //  Mindestens ein Großbuchstabe?
        }

        [Fact]
        public void Generate_WithDigitsAndSpecial_ContainsAtLeastOneDigitAndSpecial()
        {
            string result = _generator.Generate(12, useUpper: false, useDigits: true, useSpecial: true);

            Assert.Contains(result, c => char.IsDigit(c));  // Mindestens eine Zahl?
            Assert.Contains(result, c => "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~".Contains(c));
        }

        [Fact]
        public void Generate_TooShort_ThrowsArgumentException()
        {
            // 3 Zeichengruppen aktiviert, aber  Länge 2 ausgewählt.
            Assert.Throws<ArgumentException>(() => _generator.Generate(2, true, true, true));
        }

        [Theory]
        [InlineData(8, true, true, false)]
        [InlineData(16, true, true, true)]
        [InlineData(20, false, true, true)]
        public void Generate_ReturnsStringWithCorrectLength(int length, bool upper, bool digits, bool special)
        {
            string result = _generator.Generate(length, upper, digits, special);
            Assert.Equal(length, result.Length);  // Stimmen eingegebene und tatsächliche Länge überein?
        }

    }    

}