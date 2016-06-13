using System.Collections.Generic;
using Patterns.Models;

namespace Patterns.Services
{
    public interface IMovieService
    {
        void DeleteMovie(int id);
        List<Movie> GetMovies();
        void SaveMovie(Movie movie);
    }
}