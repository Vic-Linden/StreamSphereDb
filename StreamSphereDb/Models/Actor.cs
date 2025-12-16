using System;
using System.Collections.Generic;

namespace StreamSphereDb.Models;

public partial class Actor
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public virtual ICollection<ActorsInEpisode> ActorsInEpisodes { get; set; } = new List<ActorsInEpisode>();

    public virtual ICollection<ActorsInMovie> ActorsInMovies { get; set; } = new List<ActorsInMovie>();
}
