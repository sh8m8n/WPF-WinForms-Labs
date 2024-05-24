using CommunityToolkit.Mvvm.Input;
using Model;
using System.Collections.ObjectModel;

namespace ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<Movie> sortedMovies = new ObservableCollection<Movie>();
        private ObservableCollection<Director> sortedDirectors = new ObservableCollection<Director>();
        private Movie selectedMovie;
        private List<Movie> Movies { get; set; } = new List<Movie>();
        private List<Director> Directors { get; set; } = new List<Director>();
        private string directorName;
        private string title;

        public ObservableCollection<Movie> SortedMovies
        {
            get => sortedMovies; set
            {
                sortedMovies = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Director> SortedDirectors
        {
            get => sortedDirectors; set
            {
                sortedDirectors = value;
                OnPropertyChanged();
            }
        }

        public Movie SelectedMovie
        {
            get { return selectedMovie; }
            set
            {
                selectedMovie = value;
                DeleteCommand.NotifyCanExecuteChanged();
            }
        }

        public string DirectorName
        {
            get { return directorName; }
            set
            {
                directorName = value;
                AddCommand.NotifyCanExecuteChanged();
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                AddCommand.NotifyCanExecuteChanged();
            }
        }

        public int Year { get; set; }
        public Genre[] Genres { get; set; } = { Genre.Comedy, Genre.Fantasy, Genre.Drama };
        public Genre SelectedGenre { get; set; }
        public int Rating { get; set; }

        public Genre SelectedGenreSort { get; set; }
        public int StartYearSort { get; set; }
        public int EndYearSort { get; set; }


        public RelayCommand DeleteCommand { get; set; }
        public RelayCommand AddCommand { get; set; }
        public RelayCommand GenreSortingCommand { get; set; }
        public RelayCommand YearSortingCommand { get; set; }
        public RelayCommand AscendingRatingSortCommand { get; set; }
        public RelayCommand DescendingRatingSortCommand { get; set; }
        public RelayCommand ResetSortCommand { get; set; }

        public MainWindowViewModel()
        {
            DeleteCommand = new RelayCommand(DeleteMovie, () => SelectedMovie != null);
            AddCommand = new RelayCommand(AddMovie, CanAddMovie);
            GenreSortingCommand = new RelayCommand(GenreSort);
            YearSortingCommand = new RelayCommand(YearSort);
            AscendingRatingSortCommand = new RelayCommand(AscendingRatingSort);
            DescendingRatingSortCommand = new RelayCommand(DescendingRatingSort);
            ResetSortCommand = new RelayCommand(ResetSort);
        }

        /// <summary>
        /// Отменяет все фильтры и сортировки
        /// </summary>
        private void ResetSort()
        {
            SortedMovies = new ObservableCollection<Movie>(Movies);
            SortedDirectors = new ObservableCollection<Director>(Directors);
        }

        private void DescendingRatingSort()
        {
            var s = SortedMovies.OrderByDescending(m => m.Rating);
            SortedMovies = new ObservableCollection<Movie>(s);
        }

        private void AscendingRatingSort()
        {
            SortedMovies = new ObservableCollection<Movie>(SortedMovies.OrderBy(m => m.Rating));
        }

        private void YearSort()
        {
            var sortedMovies = from Movie in SortedMovies
                               where Movie.Year >= StartYearSort && Movie.Year < EndYearSort
                               orderby Movie.Year
                               select Movie;
            SortedMovies = new ObservableCollection<Movie>(sortedMovies);
        }

        private void GenreSort()
        {
            var sortedMovies = from Movie in SortedMovies
                               where Movie.Genre == SelectedGenreSort
                               orderby Movie.Genre
                               select Movie;
            SortedMovies = new ObservableCollection<Movie>(sortedMovies);

            UpdateSortedDirectors();
        }

        /// <summary>
        /// Обновляет колллекцию отсортированных директоров на основе отсортированных фильмов
        /// </summary>
        private void UpdateSortedDirectors()
        {
            SortedDirectors.Clear();

            foreach (Director director in Directors)
            {
                foreach (Movie movie in SortedMovies)
                {
                    if (director.Movies.Contains(movie))
                    {
                        SortedDirectors.Add(director);
                        break;
                    }
                }
            }
        }

        private bool CanAddMovie()
        {
            if (String.IsNullOrEmpty(Title) || String.IsNullOrEmpty(DirectorName))
                return false;
            return true;
        }

        /// <summary>
        /// Добавляет фильм существующему режиссеру или создает нового
        /// </summary>
        private void AddMovie()
        {
            Movie movie = new Movie(Title, SelectedGenre, Year, Rating, directorName);
            Movies.Add(movie);
            SortedMovies.Add(movie);

            foreach (var director in Directors)
            {
                if (director.Name == DirectorName)
                {
                    director.AddFilm(movie);
                    SortedDirectors = new ObservableCollection<Director>(SortedDirectors); //bruh
                    return;
                }
            }

            Director newDirector = new Director(DirectorName);
            newDirector.AddFilm(movie);
            Directors.Add(newDirector);
            SortedDirectors.Add(newDirector);
        }

        /// <summary>
        /// Удаляет фильм и режиссера если у него не осталось фильмов
        /// </summary>
        private void DeleteMovie()
        {
            for (int i = 0; i < Directors.Count; i++)
            {
                if (Directors[i].Name == SelectedMovie.DirectorName)
                {
                    Directors[i].RemoveFilm(selectedMovie);
                    SortedDirectors = new ObservableCollection<Director>(SortedDirectors); //bruh

                    if (Directors[i].Movies.Count == 0)
                    {
                        Directors.Remove(Directors[i]);
                        SortedDirectors.Remove(SortedDirectors[i]);
                    }
                }
            }
            Movies.Remove(SelectedMovie);
            SortedMovies.Remove(SelectedMovie);
        }
    }
}
