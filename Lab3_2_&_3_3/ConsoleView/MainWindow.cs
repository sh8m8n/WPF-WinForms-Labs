using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic;
using BusinessLogic.DTOs;
using LabLib;

namespace ConsoleView
{
    public class MainWindow
    {
        public IStudentManager studentManager { get; set; }
        private IDTOAssembler<StudentDTO, Student> StudentAssembler;

        private List<Student> students = new List<Student>();

        public MainWindow()
        {
            studentManager = new StudentManager();
            StudentAssembler = new StudentAssembler();
        }

        public void Show()
        {
            UpdateData();
            MainMenu();
        }

        private void UpdateData()
        {
            students = studentManager.ReadAll().Select(s => StudentAssembler.Create(s)).ToList();
        }

        private void MainMenu()
        {
            Console.Clear();

            int FunctionNumber = ConsoleUser.GetInt("Введите номер функции:\n" +
                "1)Добавить студента\n" +
                "2)Удалить студента\n" +
                "3)Изменить студента\n" +
                "4)Просмотреть всех студентов\n" +
                "5)Просмотреть гистограмму распределения студентов по специальностям");

            switch (FunctionNumber)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    DeleteStudent();
                    break;
                case 3:
                    UpdateStudent();
                    break;
                case 4:
                    PrintAllStudents();
                    break;
                case 5:
                    PrintHistogram();
                    break;
                default:
                    Console.WriteLine("Опции не существует");
                    Console.ReadKey();
                    MainMenu();
                    break;
            }
        }

        private void AddStudent()
        {
            StudentData studentData = new StudentData();

            studentData.Name = ConsoleUser.GetString("Введите имя студента:");
            studentData.Speciality = ConsoleUser.GetString("Введите специальность студента:");
            studentData.Group = ConsoleUser.GetString("Введите группу студента:");

            studentManager.Create(studentData);
            UpdateData();

            MainMenu();
        }

        private void DeleteStudent()
        {
            int id = ConsoleUser.GetInt("Введите id студента для удаления:");

            studentManager.Delete(id);
            UpdateData();

            MainMenu();
        }

        private void UpdateStudent()
        {
            int id = ConsoleUser.GetInt("Введите ID студента");

            StudentData studentData = new StudentData();
            studentData.Name = ConsoleUser.GetString("Введите имя студента:");
            studentData.Speciality = ConsoleUser.GetString("Введите специальность студента:");
            studentData.Group = ConsoleUser.GetString("Введите группу студента:");

            studentManager.Update(id, studentData);
            UpdateData();

            MainMenu();
        }

        private void PrintAllStudents()
        {
            Console.WriteLine(new String('—', Student.ToStringLength));

            foreach(Student s in students)
                Console.WriteLine(s.ToString());

            Console.WriteLine(new String('—', Student.ToStringLength));

            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
            MainMenu();
        }

        private void PrintHistogram()
        {
            Histogram histogram = new Histogram() { Height = 20, SummaryBulgingLength = 5};

            try
            {
                Console.WriteLine(histogram.GetHistogram(
                students.GroupBy(s => s.Speciality).ToDictionary(g => g.Key, g => g.Count())));
            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("отсутствуют данные");
            }

            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
            MainMenu();
        }
    }
}
