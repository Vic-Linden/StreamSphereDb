using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StreamSphereDb.Models;

namespace StreamSphereDb.Data;

public partial class StreamSphereDbContext : DbContext
{
    public StreamSphereDbContext()
    {
    }

    public StreamSphereDbContext(DbContextOptions<StreamSphereDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<ActorsInEpisode> ActorsInEpisodes { get; set; }

    public virtual DbSet<ActorsInMovie> ActorsInMovies { get; set; }

    public virtual DbSet<Episode> Episodes { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<MovieGenre> MovieGenres { get; set; }

    public virtual DbSet<Show> Shows { get; set; }

    public virtual DbSet<ShowGenre> ShowGenres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=V-LINDÉN;Database=StreamSphereDb;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Actor__3214EC071010A7AF");

            entity.ToTable("Actor");

            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
        });

        modelBuilder.Entity<ActorsInEpisode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ActorsIn__3214EC078409C62B");

            entity.ToTable("ActorsInEpisode");

            entity.HasOne(d => d.Actor).WithMany(p => p.ActorsInEpisodes)
                .HasForeignKey(d => d.ActorId)
                .HasConstraintName("FK_Actor_ActorsInEpisode");

            entity.HasOne(d => d.Episode).WithMany(p => p.ActorsInEpisodes)
                .HasForeignKey(d => d.EpisodeId)
                .HasConstraintName("FK_Episode_ActorsInEpisode");
        });

        modelBuilder.Entity<ActorsInMovie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ActorsIn__3214EC07D8670B45");

            entity.ToTable("ActorsInMovie");

            entity.HasOne(d => d.Actor).WithMany(p => p.ActorsInMovies)
                .HasForeignKey(d => d.ActorId)
                .HasConstraintName("FK_Actor_ActorsInMovie");

            entity.HasOne(d => d.Movie).WithMany(p => p.ActorsInMovies)
                .HasForeignKey(d => d.MovieId)
                .HasConstraintName("FK_Movie_ActorsInMovie");
        });

        modelBuilder.Entity<Episode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Episode__3214EC07B684C60A");

            entity.ToTable("Episode");

            entity.Property(e => e.Episode1).HasColumnName("Episode");
            entity.Property(e => e.Title).HasMaxLength(100);

            entity.HasOne(d => d.Show).WithMany(p => p.Episodes)
                .HasForeignKey(d => d.ShowId)
                .HasConstraintName("FK_Show_Episode");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Genre__3214EC073DA84512");

            entity.ToTable("Genre");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movie__3214EC07CA9B7027");

            entity.ToTable("Movie");

            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<MovieGenre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MovieGen__3214EC073207B254");

            entity.ToTable("MovieGenre");

            entity.HasOne(d => d.Genre).WithMany(p => p.MovieGenres)
                .HasForeignKey(d => d.GenreId)
                .HasConstraintName("FK_Genre_MovieGenre");

            entity.HasOne(d => d.Movie).WithMany(p => p.MovieGenres)
                .HasForeignKey(d => d.MovieId)
                .HasConstraintName("FK_Movie_MovieGenre");
        });

        modelBuilder.Entity<Show>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Show__3214EC07802FCBB9");

            entity.ToTable("Show");

            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<ShowGenre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ShowGenr__3214EC0756459304");

            entity.ToTable("ShowGenre");

            entity.HasOne(d => d.Genre).WithMany(p => p.ShowGenres)
                .HasForeignKey(d => d.GenreId)
                .HasConstraintName("FK_Genre_ShowGenre");

            entity.HasOne(d => d.Show).WithMany(p => p.ShowGenres)
                .HasForeignKey(d => d.ShowId)
                .HasConstraintName("FK_Show_ShowGenre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
