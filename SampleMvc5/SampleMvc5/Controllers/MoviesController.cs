using SampleMvc5.Models;
using SampleMvc5.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMvc5.Controllers
{
    //[Authorize(Roles ="Admin, manager")] // or
    /* USE WHEN BOTH ROLES ARE NEEDED
    [Authorize(Roles = "Admin")]
    [Authorize(Roles = "manager")] */
    public class MoviesController : Controller
    {
        private ApplicationDbContext _dbContext;
        // GET: Customers
        public MoviesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // dispose/destroy _dbContext
        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }
        
        public ViewResult Index()
        {
            //var movies = GetMovies();
            var movies = _dbContext.Movies.Include("Genre").ToList();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie(){ Id = 1, Name="Matrix 4"},
                new Movie(){ Id = 2, Name="Iran Man 4"},
                new Movie(){ Id = 3, Name="Black Widow"},
            };
        }
        public ActionResult New()
        {
            var genre = _dbContext.Genres.ToArray();
            var MovieFormViewModel = new MovieFormViewModel
            {
                Movie = new Movie(),
                Genre = genre
            };
            return View("MovieForm", MovieFormViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var  movieViewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    Genre = _dbContext.Genres.ToArray()
                };
                return View("MovieForm", movieViewModel);

            }
            if (movie.Id == 0)
            {
                //Insert of new movie
                _dbContext.Movies.Add(movie);
                //movie.Genre = movie.Genre.Id;
                movie.DateAdded = DateTime.Parse(movie.DateAdded.ToString("yyyy-MM-dd")); ;
                movie.ReleaseDate = DateTime.Parse(movie.ReleaseDate.ToString("yyyy-MM-dd")); ;
                //movie.GenreIden = movie.Genre.Id;
            }
            else
            {
                //update
                var existingMovie = _dbContext.Movies.Include("Genre").FirstOrDefault(x => x.Id == movie.Id);
                if (existingMovie != null)
                {
                    existingMovie.Name = movie.Name;
                    existingMovie.DateAdded = movie.DateAdded;
                    existingMovie.ReleaseDate = movie.ReleaseDate;
                    existingMovie.NumberInStock = movie.NumberInStock;
                    existingMovie.GenreIden = movie.Genre.Id;
                }
            }
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Edit(int Id)
        {
            var movie = _dbContext.Movies.Include("Genre").FirstOrDefault(x => x.Id == Id);
            if (movie == null)
            {
                return HttpNotFound();

            }
            var movieViewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genre = _dbContext.Genres.ToArray()
            };
            return View("MovieForm", movieViewModel);
        }

        [AllowAnonymous]
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Iron Man - 4" };

            var customers = new List<Customer>
            {
                new Customer{Name = "John Rambo"},
                new Customer{Name = "Robert Downey" }
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}