
using PasswordManagerApp;

namespace SimplePasswordManager
{
    internal static class Program
    {

        // The main entry point for the application:

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Datenbank und Tabellen sicherstellen
            using (var context = new PasswordManagerApp.Persistence.PasswordDbContext())
            {
                context.Database.EnsureCreated();
            }

            using (var login = new LoginForm())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    string masterPassword = login.Tag as string ?? throw new Exception("Kein Passwort übergeben.");
                    Application.Run(new MainForm(masterPassword));
                }
            }
        }

    }
}