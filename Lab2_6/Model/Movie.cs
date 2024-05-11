namespace Model
{
    public class Movie
    {
        public string Title { get; private set; }
        public Genre Genre { get; private set; }
        public int Year { get; private set; }
        public float Rating { get; private set; }

        public readonly Director Director;

        public Movie(string title, Genre genre, int year, int rating, Director director)
        {
            Title = title;
            Genre = genre;
            Year = year;
            Rating = rating;
            Director = director;
        }
    }
}