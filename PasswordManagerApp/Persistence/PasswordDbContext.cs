
using Microsoft.EntityFrameworkCore;
using PasswordManagerApp.Models;
using System.Diagnostics;

namespace PasswordManagerApp.Persistence
{
    public class PasswordDbContext: DbContext
    {
        // Modelle festlegen, aus denen später Tabellen erzeugt werden.
        public DbSet<PasswordEntry> Entries { get; set; }
        public DbSet<MasterConfig> MasterConfigs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Relativer Pfad:
            var relativePath = Path.Combine("..", "..", "..", "..", "data", "passwords.db");

            optionsBuilder.UseSqlite($"Data Source={relativePath}");
        }
    }
}
