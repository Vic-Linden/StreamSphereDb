using System;
using System.Collections.Generic;

namespace StreamSphereDb.Models;

public partial class Show
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public DateOnly? ReleaseDate { get; set; }

    public virtual ICollection<Episode> Episodes { get; set; } = new List<Episode>();

    public virtual ICollection<ShowGenre> ShowGenres { get; set; } = new List<ShowGenre>();
}
