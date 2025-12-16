using System;
using System.Collections.Generic;
using System.Text;
using StreamSphereDb.Models;

namespace StreamSphereDb
{
    internal class Menu
    {
        public void MainMenu()
        {
            bool isRunning = true;
            while (isRunning) 
            {
                Console.WriteLine();
                Console.WriteLine("Choose an option."); 
                Console.WriteLine("1. Show all Movies.");
                Console.WriteLine("2. Show all Actors.");
                Console.WriteLine("3. Show all Shows.");
                Console.WriteLine("4. Filter movies by actor.");
                Console.WriteLine("5. Filter movies based on Genre.");
                Console.WriteLine("6. ");
                Console.WriteLine("7. ");
                Console.WriteLine("8. ");
                Console.WriteLine("9. ");
                Console.WriteLine("10. Exit.");
                string? choice = Console.ReadLine();

                switch (choice) 
                {
                    case "1":
                        PrintAll.ShowAllMovies();
                        break;

                    case "2":
                        PrintAll.ShowAllActors();
                        break;

                    case "3":
                        PrintAll.ShowAllShow();
                        break;

                    case "4":
                        PrintAll.ShowMoviesByActor();
                        break;

                    case "5":

                        break;

                    case "10":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again!");
                        break;
                }
            }
           

        }
    }
}
