using System;
using System.Collections.Generic;
using System.Text;
using StreamSphereDb.Data;
using StreamSphereDb.Models;
using Microsoft.EntityFrameworkCore;


namespace StreamSphereDb
{
    internal static class PrintAll
    {

        public static void ShowAllMovies() 
        { 
            StreamSphereDbContext DbContext = new StreamSphereDbContext();

            foreach (Movie movie in DbContext.Movies) 
            {
                Console.WriteLine(movie.Title);
            }
        }

        public static void ShowAllActors()
        {
            StreamSphereDbContext DbContext = new StreamSphereDbContext();

            foreach (Actor actor in DbContext.Actors)
            {
                Console.WriteLine(actor.FirstName + " " + actor.LastName);
            }
        }

        public static void ShowAllShow()
        {
            StreamSphereDbContext DbContext = new StreamSphereDbContext();

            foreach (Show show in DbContext.Shows)
            {
                Console.WriteLine(show.Title);
            }
        }

        public static void ShowMoviesByActor() 
        {
            StreamSphereDbContext DbContext = new StreamSphereDbContext();

            Console.WriteLine("Skriv in förnamn på en skådespelare nedan: ");
            string choice = Console.ReadLine();

            var filteredActor = DbContext.ActorsInMovies
                                .Include(a => a.Actor)
                                .Include(a => a.Movie)
                                .Where(a => a.Actor.FirstName == choice).ToList();

            foreach (var movie in filteredActor) 
            {
                Console.WriteLine(movie.Movie.Title);
            }
        }

        public static void ShowMoviesByRomance()
        {
            StreamSphereDbContext DbContext = new StreamSphereDbContext();

            // var romanceMovies = DbContext.Genres.Where(g => g.Name == "Romance").Include(mg => mg.MovieGenres.Include(m => m.Movies));


        }

        



}
   
}
