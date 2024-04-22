using CommunityToolkit.Mvvm.Input;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ObservableCollection<Discipline> Disciplines { get; set; }

        private Discipline selectedDiscipline;

        public Discipline SelectedDiscipline
        {
            get { return selectedDiscipline; }
            set { selectedDiscipline = value; }
        }

        public string Title { get; set; }
        public string TeacherName { get; set; }
        public Difficulty[] Difficulties { get; set; }
        public Difficulty Difficulty { get; set; }
        public DateTime ExamDate { get; set; } = DateTime.Now;

        public RelayCommand AddCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }

        public MainWindowViewModel()
        {
            Disciplines = new ObservableCollection<Discipline>();

            Difficulties = new Difficulty[] { Difficulty.Easy, Difficulty.Normal, Difficulty.Hard};

            AddCommand = new RelayCommand(AddDiscipline);
            DeleteCommand = new RelayCommand(DeleteDiscipline); //, () => SelectedDiscipline != null);
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
