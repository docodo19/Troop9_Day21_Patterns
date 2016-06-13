using Patterns.Models;
using Patterns.Repositories;
using Patterns.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.Services
{
    public class MovieService : IMovieService
    {
        private IGenericRepository _repo;
        public MovieService(IGenericRepository repo)
        {
            _repo = repo;
        }

        public List<Movie> GetMovies()
        {
            var movies = _repo.Query<Movie>().ToList();
            return movies;
        }

        public MovieVM GetMovie(int id)
        {
            var movie = _repo.Query<Movie>().Select(m => new MovieVM
            {
                Id = m.Id,
                Title = m.Title
            }).FirstOrDefault();

            return movie;
        }

        public void SaveMovie(Movie movie)
        {
            _repo.Add(movie);
        }

        public void DeleteMovie(int id)
        {
            var movieToDelete = _repo.Query<Movie>().FirstOrDefault(m => m.Id == id);
            _repo.Delete(movieToDelete);
        }
    }
}
