

namespace PasswordManagerApp.Services
{
    public class ValidationService
    {
        // Hilfsfunktion
        private static bool Error(string txt, out string errorMessage)
        {
            errorMessage = txt;
            return false;
        }

        // Validierungen
        public static bool IsValidEntry(string username, string password, string description, out string errorMessage)
        {
            // Default Error-Message
            errorMessage = "";

            // Leereingaben prüfen
            if (string.IsNullOrWhiteSpace(username))
                return Error("Benutzername leer.", out errorMessage);
            if (string.IsNullOrWhiteSpace(password))
                return Error("Passwort leer.", out errorMessage);
            if (string.IsNullOrWhiteSpace(description))
                return Error("Beschreibung leer.", out errorMessage);

            // Mindestlänge Passwort
            if (password.Length < 6)
                return Error("Passwort zu kurz (mind. 6 Zeichen).", out errorMessage);

            // Maximallänge Beschreibung
            if (description.Length > 40)
                return Error("Beschreibung zu lang. (max. 40 Zeichen)", out errorMessage);

            // Vallidierung positiv            
            return true;
        }
    }
}
