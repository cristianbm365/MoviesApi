using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Domain.Entities.Models
{
    [Table("MoviesSaved", Schema = "dbo")]
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
        public byte? Status { get; set; }
        public string Createdby { get; set; } = string.Empty;
        public DateTime? Created { get; set; }
        public string Modifiedby { get; set; } = string.Empty;
        public DateTime? Modified { get; set; }
        public int RoleId { get; set; }
        public virtual Roles Role { get; set; }
    }
}
