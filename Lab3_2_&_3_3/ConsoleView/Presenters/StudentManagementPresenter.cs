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
        private const string ZeroMembersReport = "Студентов нет";

        public IMainWindowView MainWindow { get; set; }

        public void Present(IEnumerable<StudentDTO> students)
        {
            MainWindowViewModel viewModel =
                new MainWindowViewModel(FormatTable(students), FormatHistogram(students), ConsoleColor.DarkCyan);

            MainWindow.Render(viewModel);
        }

        private string FormatHistogram(IEnumerable<StudentDTO> students)
        {
            if (students.Count() == 0)
            {
                return ZeroMembersReport;
            }

            Histogram histogram = new Histogram() { Height = 10, SummaryBulgingLength = 5};
            return histogram.GetHistogram(students.GroupBy(s => s.Speciality).ToDictionary(g => g.Key, g => g.Count()));
        }

        private string FormatTable(IEnumerable<StudentDTO> students)
        {
            if(students.Count() == 0)
            {
                return ZeroMembersReport;
            }

            StringBuilder sb = new StringBuilder();

            //Подсчет наидлиннейших атрибутов студента
            //Стандартные зачения - длины названий атрибутов
            int maxIDLength = 2; 
            int maxNameLength = 3;
            int maxSpecialityLength = 5;
            int maxGroupLength = 6;

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
            string UpperHorizontalLine =
                $"┌{new string('─', maxIDLength + maxNameLength + maxSpecialityLength + maxGroupLength + 3)}┐";
            string MediumHorizontalLine =
                $"├{new string('─', maxIDLength + maxNameLength + maxSpecialityLength + maxGroupLength + 3)}┤";
            string LowerHorizontalLine =
                $"└{new string('─', maxIDLength + maxNameLength + maxSpecialityLength + maxGroupLength + 3)}┘";

            sb.Append(UpperHorizontalLine);
            sb.Append($"\n│ID{new string(' ', maxIDLength - 2)}│Имя{new string(' ', maxNameLength - 3)}│" +
                $"Спец.{new string(' ', maxSpecialityLength - 5)}│Группа{new string(' ', maxGroupLength - 6)}│\n");
            sb.Append(MediumHorizontalLine);

            foreach (StudentDTO student in students)
            {
                sb.Append(
                    $"\n│{student.ID}{new string(' ', maxIDLength - student.ID.ToString().Length)}" +
                    $"│{student.Name}{new string(' ', maxNameLength - student.Name.Length)}" +
                    $"│{student.Speciality}{new string(' ', maxSpecialityLength - student.Speciality.Length)}" +
                    $"│{student.Group}{new string(' ', maxGroupLength - student.Group.Length)}│"
                    );
            }

            sb.Append($"\n{LowerHorizontalLine}");

            return sb.ToString();
        }
    }
}
