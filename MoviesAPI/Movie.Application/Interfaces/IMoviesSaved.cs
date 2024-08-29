using Movie.Domain.Entities.Models;

namespace Movie.Application.Interfaces
{
    public interface IMoviesSaved
    {
        Task<MoviesSaved> ObtenerPeliculas();
    }
}
