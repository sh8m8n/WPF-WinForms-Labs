using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleView.Presenters;
using ConsoleView.ViewModels;
using Interactors.DTOs;
using Interactors.Interfaces;
using System;

namespace ConsoleView.Controllers
{
    public class StudentManagementPresenter : IStudentManagementOutputPort
    {
        public IMainWindowView MainWindow { get; set; }

        public void Present(IEnumerable<StudentDTO> students)
        {
            MainWindowViewModel viewModel =
                new MainWindowViewModel(FormatHistogram(students), FormatTable(students), ConsoleColor.DarkBlue);

            MainWindow.Render(viewModel);
        }

        private string FormatHistogram(IEnumerable<StudentDTO> students)
        {
            Histogram histogram = new Histogram() { Height = 10, SummaryBulgingLength = 5};
            return histogram.GetHistogram(students.GroupBy(s => s.Speciality).ToDictionary(g => g.Key, g => g.Count()));
        }

        private string FormatTable(IEnumerable<StudentDTO> students)
        {
            StringBuilder sb = new StringBuilder();

            //Подсчет наидлиннейших атрибутов студента
            int maxIDLength = 0;
            int maxNameLength = 0;
            int maxSpecialityLength = 0;
            int maxGroupLength = 0;

            foreach (StudentDTO student in students)
            {
                if (student.ID.ToString().Length > maxIDLength)
                    maxIDLength = student.ID.ToString().Length;

                if (student.Name.Length > maxNameLength)
                    maxNameLength = student.Name.Length;

                if (student.Speciality.Length > maxSpecialityLength)
                    maxSpecialityLength = student.Speciality.Length;

                if (student.Group.Length > maxGroupLength)
                    maxGroupLength = student.Group.Length;
            }

            //Формат таблицы
            string horizontalLine =
                new string('-', maxIDLength + maxNameLength + maxSpecialityLength + maxGroupLength + 5);

            sb.Append(horizontalLine);

            foreach (StudentDTO student in students)
            {
                sb.Append(
                    $"\n|{student.ID}{new string(' ', maxIDLength - student.ID.ToString().Length)}" +
                    $"|{student.Name}{new string(' ', maxNameLength - student.Name.Length)}" +
                    $"|{student.Speciality}{new string(' ', maxSpecialityLength - student.Speciality.Length)}" +
                    $"|{student.Group}{new string(' ', maxGroupLength - student.Group.Length)}"
                    );
            }

            sb.Append(horizontalLine);

            return sb.ToString();
        }
    }
}
