using System.Collections.ObjectModel;

namespace Model
{
    public class Director
    {
        private readonly ObservableCollection<Movie> movies = new ObservableCollection<Movie>();
        public readonly ReadOnlyObservableCollection<Movie> Movies;

        public int MovieCount => movies.Count;
        public float AverageRating { get; private set; }
        public int StartActivityYear { get; private set; }
        public int EndActivityYear { get; private set; }
        public string Name { get; private set; }

        public Director(string name)
        {
            Movies = new ReadOnlyObservableCollection<Movie>(movies);
            Name = name;
        }

        /// <summary>
        /// Добавляет фильм в коллекцию и обновляет статистику
        /// </summary>
        /// <param name="movie"></param>
        public void AddFilm(Movie movie)
        {
            movies.Add(movie);

            float sumRating = 0;
            foreach (Movie m in Movies)
            {
                sumRating += m.Rating;
            }
            AverageRating = sumRating / MovieCount;

            if(movie.Year < StartActivityYear)
            {
                StartActivityYear = movie.Year;
            }
            else if(movie.Year > EndActivityYear)
            {
                EndActivityYear = movie.Year;
            }
        }

        /// <summary>
        /// Добавляет фильм в коллекцию и обновляет статистику
        /// </summary>
        /// <param name="movie"></param>
        public void RemoveFilm(Movie movie)
        {
            movies.Remove(movie);

            float sumRating = 0;
            foreach (Movie m in Movies)
            {
                sumRating += m.Rating;
                if(m.Year < StartActivityYear)
                {
                    StartActivityYear = m.Year;
                }
                else if (m.Year > EndActivityYear)
                {
                    EndActivityYear = m.Year;
                }
            }
            AverageRating = sumRating / MovieCount;
        }
    }
}
