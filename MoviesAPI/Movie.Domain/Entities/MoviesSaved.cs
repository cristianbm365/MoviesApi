using System;
using System.Collections.Generic;

namespace Movie.Domain.Entities;

public partial class MoviesSaved
{
    public int Id { get; set; }

    public int PeliculaId { get; set; }

    public string Nombre { get; set; } = null!;

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
