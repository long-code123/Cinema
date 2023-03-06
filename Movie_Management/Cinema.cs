using System;
using System.Collections.Generic;
using System.Linq;
using ManageMovie.Classes;
using ManageMovie.Interface;

namespace Movie_Management
{
    public class Cinema : IMovie
    {
        public List<Movie> Movies = new List<Movie>();

        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }

        public string SearchMovieByID(int id)
        {
            Movie movie = Movies.FirstOrDefault(i => i.IdFilm.Equals(id));
            if (movie != null)
            {
                return movie.ViewInforMovies();

            }

            return "The is no movie have this id";
        }

        public string ViewInforMovies()
        {
            string resu = "";
            foreach (var m in Movies)
            {
                resu = resu + m.ViewInforMovies();
            }

            return resu;
        }
        public void DeleteMovieByID(int id)
        {
            Movie movie = Movies.FirstOrDefault(i => i.IdFilm.Equals(id));
            {
                if (movie != null)
                {
                    Movies.Remove(movie);
                    Console.WriteLine("Remove successfully!");
                }
                else
                {
                    Console.WriteLine("Please re-enter!!!");
                }

            }
        }
        public bool UpdateMovieByID(int id)
        {
            Movie movie = Movies.FirstOrDefault(i => i.IdFilm.Equals(id));
            if (movie != null)
            {
                Console.Write("Enter Name: ");
                movie.Name = Console.ReadLine();
                Console.Write("Enter Kind: ");
                movie.Kind = Console.ReadLine();
                Console.Write("Enter Director: ");
                movie.Director = Console.ReadLine();
                Console.Write("Enter Film Duration: ");
                movie.FilmDuration = Console.ReadLine();
                Console.Write("Enter Release Date: ");
                movie.ReleaseDate = Console.ReadLine();
                Console.Write("Enter Tomato Rate: ");
                movie.TomatoRate = double.Parse(Console.ReadLine());
                Console.WriteLine("Update successfully!");
                return true;
            }

            return false;
        }
    }
}