using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Domain.Entities.Models
{
    [Table("Roles", Schema = "dbo")]
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }
        public string Name { get; set; } = string.Empty;

        public virtual List<Users> Users { get; set; }
    }
}
