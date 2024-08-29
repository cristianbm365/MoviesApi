using Microsoft.AspNetCore.Mvc;
using Movie.Application.Interfaces;

namespace Movie.API.Controllers.Movies
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesSaved _moviesSaved;

        public MoviesController(IMoviesSaved moviesSaved)
        {
            _moviesSaved = moviesSaved;
        }
        [HttpPost]
        [Route("ObtenerPeliculas")]
        public async Task<ActionResult> ObtenerPeliculas()
        {
            var peliculas = await _moviesSaved.ObtenerPeliculas();

            return Ok(peliculas);
        }
    }
}
