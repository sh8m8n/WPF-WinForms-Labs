using CommunityToolkit.Mvvm.Input;
using Model;
using System;
using System.Collections.ObjectModel;

namespace ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ObservableCollection<Discipline> Disciplines { get; set; }

        private Discipline selectedDiscipline;

        public Discipline SelectedDiscipline
        {
            get { return selectedDiscipline; }
            set
            {
                selectedDiscipline = value;
                DeleteCommand.NotifyCanExecuteChanged();
            }
        }

        private string title;

        public string Title 
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                AddCommand.NotifyCanExecuteChanged();
            }
        }

        private string teacherName;

        public string TeacherName
        {
            get
            {
                return teacherName;
            }
            set
            {
                teacherName = value;
                AddCommand.NotifyCanExecuteChanged();
            }
        }

        public Difficulty[] Difficulties { get; set; }
        public Difficulty Difficulty { get; set; }
        public DateTime ExamDate { get; set; } = DateTime.Now;

        public RelayCommand AddCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }

        public MainWindowViewModel()
        {
            Disciplines = new ObservableCollection<Discipline>();

            Difficulties = new Difficulty[] { Difficulty.Easy, Difficulty.Normal, Difficulty.Hard};

            AddCommand = new RelayCommand(AddDiscipline, AddCommandCanExecute);
            DeleteCommand = new RelayCommand(DeleteDiscipline, () => SelectedDiscipline != null);
            DeleteCommand.NotifyCanExecuteChanged();
        }

        private bool AddCommandCanExecute()
        {
            if(!String.IsNullOrEmpty(Title) && !String.IsNullOrEmpty(TeacherName))
                return true;
            else
                return false;
        }

        private void AddDiscipline()
        {
            Disciplines.Add(new Discipline(Title, TeacherName, ExamDate, Difficulty));
        }

        private void DeleteDiscipline()
        {
            Disciplines.Remove(SelectedDiscipline);
        }
    }
}
