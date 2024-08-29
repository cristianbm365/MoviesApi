using System;
using System.Collections.Generic;

namespace Movie.Domain.Entities;

public partial class User
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Salt { get; set; }

    public byte? Status { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Created { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modified { get; set; }

    public int? RoleId { get; set; }

    public virtual ICollection<MoviesSaved> MoviesSaveds { get; set; } = new List<MoviesSaved>();

    public virtual Role? Role { get; set; }
}
