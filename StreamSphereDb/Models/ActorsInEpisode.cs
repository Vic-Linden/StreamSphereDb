using System;
using System.Collections.Generic;

namespace StreamSphereDb.Models;

public partial class ActorsInEpisode
{
    public int Id { get; set; }

    public int? ActorId { get; set; }

    public int? EpisodeId { get; set; }

    public virtual Actor? Actor { get; set; }

    public virtual Episode? Episode { get; set; }
}
