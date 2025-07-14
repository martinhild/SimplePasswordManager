
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

            using (var login = new LoginForm())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm());
                }
            }
        }
    }
}