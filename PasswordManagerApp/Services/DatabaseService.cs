
using PasswordManagerApp.Models;
using PasswordManagerApp.Persistence;
using Microsoft.EntityFrameworkCore;

namespace PasswordManagerApp.Services
{
    public class DatabaseService
    {
        public void InitializeDatabase()
        {
            // Stelle sicher, dass der data-Ordner existiert
            var dbPath = System.IO.Path.Combine("..", "..", "..", "..", "data");
            if (!System.IO.Directory.Exists(dbPath))
                System.IO.Directory.CreateDirectory(dbPath);

            // Wende alle Migrationen an
            using var ctx = new PasswordDbContext();
            ctx.Database.Migrate();
        }

        // CRUD-Methoden:

        public void CreateEntry(PasswordEntry entry)
        {
            if (entry == null)
                throw new ArgumentNullException(nameof(entry));   
            
            using var ctx = new PasswordDbContext();
            ctx.Entries.Add(entry);
            ctx.SaveChanges();
        }

        public List<PasswordEntry> GetAllEntries()
        {
            using var ctx = new PasswordDbContext();
            return ctx.Entries.ToList();
        }

        public PasswordEntry GetEntryById(int id)
        {
            using var ctx = new PasswordDbContext();
            return ctx.Entries.Find(id); // liefert null, wenn nicht gefunden
        }

        public void UpdateEntry(PasswordEntry entry)
        {
            if (entry == null)
                throw new ArgumentNullException(nameof(entry));
            
            using var ctx = new PasswordDbContext();
            ctx.Update(entry);
            ctx.SaveChanges();
        }

        public void DeleteEntry(int id)
        {
            using var ctx = new PasswordDbContext();
            var entry = ctx.Entries.Find(id);
            if (entry != null)
            {
                ctx.Remove(entry);
                ctx.SaveChanges();
            }
        }

        public MasterConfig GetMasterConfig()
        {
            using var ctx = new PasswordDbContext();
            return ctx.MasterConfigs.FirstOrDefault(); // liefert Null, wenn nicht gefunden
        }

        public void SaveMasterConfig(string hash, string salt)
        {
            using var ctx = new PasswordDbContext();
            var masterconfig = ctx.MasterConfigs.FirstOrDefault();
            if (masterconfig == null)
            {
                masterconfig = new MasterConfig { Hash = hash, Salt = salt };
                ctx.MasterConfigs.Add(masterconfig);
            }
            else
            {
                masterconfig.Hash = hash;
                masterconfig.Salt = salt;
            }            
            ctx.SaveChanges();
        }
    }
}