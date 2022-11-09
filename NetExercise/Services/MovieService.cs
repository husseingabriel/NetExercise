using NetExercise.Models;

namespace NetExercise.Services
{
    public class MovieService
    {
        public void Main()
        {
            GetAllMovies();
        }

        private void GetAllMovies()
        {
            var lordOfTheRingsActors = new List<ActorModel>();
            lordOfTheRingsActors.Add(new ActorModel()
            {
                Id = 1,
                FullName = "Ian Mckellen",
                Birthday = DateTime.Now,
                Gender = 'M'
            });
            lordOfTheRingsActors.Add(new ActorModel()
            {
                Id = 1,
                FullName = "Viggo Mortensen",
                Birthday = new DateTime(1958, 10, 20),
                Gender = 'M'
            });

            var movies = new List<MovieModel>();
            movies.Add(new MovieModel()
            {
                Id = 1,
                Name = "The Lord of The Ring",
                Description = "Action and adventure movie",
                ReleaseDate = new DateTime(1999, 5, 5),
                Rating = 5,
                Actors = lordOfTheRingsActors
            });
            movies.Add(new MovieModel()
            {
                Id = 2,
                Name = "Harry Potter",
                Description = "Adventure movie",
                ReleaseDate = new DateTime(2005, 10, 5),
                Rating = 5,
            });

            foreach (var movie in movies)
            {
                Console.WriteLine("All movies:");
                Console.WriteLine($"Movie:{movie.Name} | Release date: {movie.ReleaseDate.ToShortDateString()}");
                Console.ReadLine();
            }
        }

    }
}
