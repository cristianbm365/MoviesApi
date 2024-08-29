using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Domain.Entities.Models
{
    [Table("MoviesSaved", Schema = "dbo")]
    public class MoviesSaved
    {
        [Key]
        public int Id { get; set; }
        public int PeliculaId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public virtual Users Users { get; set; }
    }
}
