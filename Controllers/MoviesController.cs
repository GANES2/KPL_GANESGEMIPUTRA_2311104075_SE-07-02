
using Microsoft.AspNetCore.Mvc;
using modul9_2311104075.Models;

namespace modul9_2311104075.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> Movies = new List<Movie>
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", new List<string> { "Tim Robbins", "Morgan Freeman" }, "Two imprisoned men bond over a number of years."),
            new Movie("The Godfather", "Francis Ford Coppola", new List<string> { "Marlon Brando", "Al Pacino" }, "The aging patriarch of an organized crime dynasty transfers control to his reluctant son."),
            new Movie("The Dark Knight", "Christopher Nolan", new List<string> { "Christian Bale", "Heath Ledger" }, "Batman battles the Joker, a criminal mastermind.")
        };

        [HttpGet]
        public IActionResult GetMovies()
        {
            return Ok(Movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovie(int id)
        {
            if (id < 0 || id >= Movies.Count)
                return NotFound();
            
            return Ok(Movies[id]);
        }

        [HttpPost]
        public IActionResult AddMovie([FromBody] Movie movie)
        {
            Movies.Add(movie);
            return CreatedAtAction(nameof(GetMovie), new { id = Movies.Count - 1 }, movie);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            if (id < 0 || id >= Movies.Count)
                return NotFound();
            
            Movies.RemoveAt(id);
            return NoContent();
        }
    }
}
