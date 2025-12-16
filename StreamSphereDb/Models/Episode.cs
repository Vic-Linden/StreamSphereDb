using System;
using System.Collections.Generic;

namespace StreamSphereDb.Models;

public partial class Episode
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? Episode1 { get; set; }

    public DateOnly? ReleaseDate { get; set; }

    public int? Season { get; set; }

    public int? ShowId { get; set; }

    public virtual ICollection<ActorsInEpisode> ActorsInEpisodes { get; set; } = new List<ActorsInEpisode>();

    public virtual Show? Show { get; set; }
}
