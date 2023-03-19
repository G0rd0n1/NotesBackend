using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace NotesBackend.Model
{

        //Database context class to configure context options
        public class NotesDbContext : DbContext
        {
            public NotesDbContext(DbContextOptions options) : base(options)
            {
            }

            //Represents entities in database with getters and setters
            public DbSet<Notes> Notes { get; set; }

            //Specifies database provider and connection string
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=gglassessment.database.windows.net;Initial Catalog=Notes;User ID=Uwais;Password=p@ssword123");
            }

        }
    }


