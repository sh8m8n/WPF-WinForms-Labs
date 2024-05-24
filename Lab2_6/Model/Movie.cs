namespace Model
{
    public class Movie
    {
        public string Title { get; private set; }
        public Genre Genre { get; private set; }
        public int Year { get; private set; }
        public float Rating { get; private set; }
        public string DirectorName { get; private set; }

        public Movie(string title, Genre genre, int year, int rating, string directorName)
        {
            Title = title;
            Genre = genre;
            Year = year;
            Rating = rating;
            DirectorName = directorName;
        }
    }
}