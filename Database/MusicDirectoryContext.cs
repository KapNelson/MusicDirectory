using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MusicDirectory
{
    public partial class MusicDirectoryContext : DbContext
    {
        public MusicDirectoryContext()
            : base("MusicDirectoryContext")
        {
        }

        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<Alyubomin> Alyubomin { get; set; }
        public virtual DbSet<Band> Band { get; set; }
        public virtual DbSet<Disk> Disk { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Mixed> Mixed { get; set; }
        public virtual DbSet<Musician> Musician { get; set; }
        public virtual DbSet<MusInstruments> MusInstruments { get; set; }
        public virtual DbSet<Performer> Performer { get; set; }
        public virtual DbSet<Track> Track { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Participation> Participation { get; set; }
        public virtual DbSet<PlayOn> PlayOn { get; set; }
        public virtual DbSet<Solo> Solo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Disk>()
                .HasOptional(e => e.Alyubomin)
                .WithRequired(e => e.Disk);

            modelBuilder.Entity<Disk>()
                .HasMany(e => e.Mixed)
                .WithRequired(e => e.Disk)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Track)
                .WithRequired(e => e.Genre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Performer>()
                .HasOptional(e => e.Band)
                .WithRequired(e => e.Performer);

            modelBuilder.Entity<Performer>()
                .HasMany(e => e.Track)
                .WithRequired(e => e.Performer)
                .WillCascadeOnDelete(false);
        }
    }
}
