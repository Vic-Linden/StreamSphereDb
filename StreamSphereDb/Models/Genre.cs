using System;
using System.Collections.Generic;

namespace StreamSphereDb.Models;

public partial class Genre
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();

    public virtual ICollection<ShowGenre> ShowGenres { get; set; } = new List<ShowGenre>();
}
