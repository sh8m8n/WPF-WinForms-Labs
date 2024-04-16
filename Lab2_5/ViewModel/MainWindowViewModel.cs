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
        public ObservableCollection<Discipline> Disciplines = new ObservableCollection<Discipline>();

        public Discipline SelectedDiscipline { get; set; }

        public string Title { get; set; }
        public string TeacherName { get; set; }
        public Difficulty Difficulty { get; set; }
        public DateTime ExamDate { get; set; }

        public RelayCommand AddCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }

        public MainWindowViewModel()
        {
            AddCommand = new RelayCommand(AddDiscipline);
            DeleteCommand = new RelayCommand(DeleteDiscipline, () => SelectedDiscipline != null);
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
