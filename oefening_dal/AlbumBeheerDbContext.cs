using Microsoft.EntityFrameworkCore;
using oefening_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oefening_dal;

public class AlbumBeheerDbContext : DbContext
    {
    public DbSet<Albums> Albums { get; set; }
    public DbSet<Reeksen> Reeksen { get; set; }
    public DbSet<Genres> Genres { get; set; }
    public DbSet<ReeksenGenres> ReeksenGenres { get; set; }
    public DbSet<Reekstypes> Reekstypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=AlbumBeheerDB;Trusted_Connection=True;");
    }
}

