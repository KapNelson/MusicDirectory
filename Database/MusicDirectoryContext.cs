using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MusicDirectory.Database
{
    public partial class MusicDirectoryContext : DbContext
    {
        public MusicDirectoryContext()
            : base("name=MusicDirectoryContext")
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
        public virtual DbSet<Style> Style { get; set; }
        public virtual DbSet<Track> Track { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .Property(e => e.AlbumTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Band>()
                .HasMany(e => e.Musician)
                .WithMany(e => e.Band)
                .Map(m => m.ToTable("Participation").MapLeftKey("ID_Artist").MapRightKey("ID_Musician"));

            modelBuilder.Entity<Disk>()
                .Property(e => e.Manufacturer)
                .IsUnicode(false);

            modelBuilder.Entity<Disk>()
                .Property(e => e.DiscName)
                .IsUnicode(false);

            modelBuilder.Entity<Disk>()
                .HasOptional(e => e.Alyubomin)
                .WithRequired(e => e.Disk);

            modelBuilder.Entity<Disk>()
                .HasMany(e => e.Mixed)
                .WithRequired(e => e.Disk)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genre>()
                .Property(e => e.GenreName)
                .IsUnicode(false);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Track)
                .WithRequired(e => e.Genre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Musician>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<MusInstruments>()
                .Property(e => e.MusInstrumentName)
                .IsUnicode(false);

            modelBuilder.Entity<MusInstruments>()
                .HasMany(e => e.Musician)
                .WithMany(e => e.MusInstruments)
                .Map(m => m.ToTable("PlayOn").MapLeftKey("MusInstrumentName").MapRightKey("ID_Musician"));

            modelBuilder.Entity<Performer>()
                .Property(e => e.ArtistName)
                .IsUnicode(false);

            modelBuilder.Entity<Performer>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Performer>()
                .Property(e => e.StyleName)
                .IsUnicode(false);

            modelBuilder.Entity<Performer>()
                .HasOptional(e => e.Band)
                .WithRequired(e => e.Performer);

            modelBuilder.Entity<Performer>()
                .HasMany(e => e.Track)
                .WithRequired(e => e.Performer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Style>()
                .Property(e => e.StyleName)
                .IsUnicode(false);

            modelBuilder.Entity<Style>()
                .HasMany(e => e.Performer)
                .WithRequired(e => e.Style)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Track>()
                .Property(e => e.NameOfTrack)
                .IsUnicode(false);

            modelBuilder.Entity<Track>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<Track>()
                .Property(e => e.GenreName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
