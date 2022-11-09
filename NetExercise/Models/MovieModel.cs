namespace NetExercise.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public List<ActorModel> Actors { get; set; }
    }
}
