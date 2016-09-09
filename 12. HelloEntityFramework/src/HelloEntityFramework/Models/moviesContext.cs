using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HelloEntityFramework.Models
{
    public partial class moviesContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=tcp:visug-djohnnie.database.windows.net,1433;Initial Catalog=movies;Persist Security Info=False;User ID=djohnnie;Password=visug1234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genres>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.HasIndex(e => e.GenreId)
                    .HasName("IX_Movies_GenreId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Movies)
                    .HasForeignKey(d => d.GenreId);
            });
        }

        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
    }
}