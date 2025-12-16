using System;
using System.Collections.Generic;

namespace StreamSphereDb.Models;

public partial class Movie
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public DateOnly? ReleaseDate { get; set; }

    public virtual ICollection<ActorsInMovie> ActorsInMovies { get; set; } = new List<ActorsInMovie>();

    public virtual ICollection<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();
}
