using System;
using System.Collections.Generic;

namespace StreamSphereDb.Models;

public partial class ShowGenre
{
    public int Id { get; set; }

    public int? ShowId { get; set; }

    public int? GenreId { get; set; }

    public virtual Genre? Genre { get; set; }

    public virtual Show? Show { get; set; }
}
