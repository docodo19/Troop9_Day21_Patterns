using System.Collections.Generic;
using Patterns.Models;
using Patterns.ViewModels;

namespace Patterns.Services
{
    public interface IMovieService
    {
        void DeleteMovie(int id);
        List<Movie> GetMovies();
        void SaveMovie(Movie movie);
        MovieVM GetMovie(int id);
    }
}