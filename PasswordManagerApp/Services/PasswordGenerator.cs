
using System.Security.Cryptography;

namespace PasswordManagerApp.Services
{
    public class PasswordGenerator
    {
        private static readonly char[] lower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private static readonly char[] upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static readonly char[] digits = "0123456789".ToCharArray();
        private static readonly char[] special = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~".ToCharArray();

        public string Generate(int length, bool useUpper, bool useDigits, bool useSpecial)
        {                        

            var poolList = new List<char>(lower);  // Pool der zu nutzenden Zeichen
            var buildPwList = new List<char>();  // Aufbau des Passworts
            int randomIndex;
            if (useUpper)
            {
                poolList.AddRange(upper);
                // Sicherstellen, dass mindestens ein Großbuchstabe enthalten ist
                randomIndex = RandomNumberGenerator.GetInt32(0, upper.Length);
                buildPwList.Add(upper[randomIndex]);
            }             
            if (useDigits)
            {                
                poolList.AddRange(digits);
                // Sicherstellen, dass mindestens eine Zahl enthalten ist
                randomIndex = RandomNumberGenerator.GetInt32(0, digits.Length);
                buildPwList.Add(digits[randomIndex]);
            }
            if (useSpecial)
            {
                poolList.AddRange(special);
                // Sicherstellen, dass mindestens ein Sonderzeichen enthalten ist
                randomIndex = RandomNumberGenerator.GetInt32(0, special.Length);
                buildPwList.Add(special[randomIndex]);
            }

            // Rest von buildPwList mit zufälligen Zeichen des Pools füllen
            int remainingChars = length - buildPwList.Count;
            if (length < buildPwList.Count)
                throw new ArgumentException("Länge muss mindestens der Anzahl der" +
                    "verwendeten Zeichenarten entsprechen.", nameof(length));

            for (int i = 0; i < remainingChars; i++)
            {
                randomIndex = RandomNumberGenerator.GetInt32(0, poolList.Count);
                buildPwList.Add(poolList[randomIndex]);
            }

            // jetzt muss buildPwList noch gemischt werden.
            var shuffled = buildPwList
                .OrderBy(_ => RandomNumberGenerator.GetInt32(0, buildPwList.Count))
                .ToArray();

            return new string(shuffled);
        }
    }
}
