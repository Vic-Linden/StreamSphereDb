using StreamSphereDb.Models;
using StreamSphereDb.Data;
using Microsoft.EntityFrameworkCore;

namespace StreamSphereDb
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //StreamSphereDbContext DbContext = new StreamSphereDbContext();

            //foreach (Movie movie in DbContext.Movies) 
            //{
            //    Console.WriteLine(movie.Title);
            //}

            //var filteredMovies = DbContext.Movies.Where(m => m.Title == "Pulp Fiction").ToList();
            //foreach (Movie movie in filteredMovies) 
            //{
            //    Console.WriteLine(movie.Title);
            //}

            Menu menu = new Menu();
            menu.MainMenu();

        }
    }
}
