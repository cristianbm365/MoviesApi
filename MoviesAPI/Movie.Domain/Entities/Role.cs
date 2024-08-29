using System;
using System.Collections.Generic;

namespace Movie.Domain.Entities;

public partial class Role
{
    public int RoleId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? RegistrationDate { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
