using System;
using System.Linq;
using BusinessLogic;
using ConsoleHistogram;
using LabLib;

namespace ConsoleView
{
    internal class Program
    {
        private static StudentManager studentManager = new StudentManager();

        static void Main(string[] args)
        {
            PrintMainMenu();
        }

        private static void PrintMainMenu()
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
                    break;
            }
        }

        private static void AddStudent()
        {
            Console.Clear();

            string name = ConsoleUser.GetString("Введите имя студента:");
            string speciality = ConsoleUser.GetString("Введите специальность студента:");
            string group = ConsoleUser.GetString("Введите группу студента:");

            studentManager.CreateStudent(name, speciality, group);

            PrintMainMenu();
        }

        private static void DeleteStudent()
        {
            Console.Clear();

            int id = ConsoleUser.GetInt("Введите id студента для удаления:");

            studentManager.DeleteStudent(id);

            PrintMainMenu();
        }

        private static void UpdateStudent()
        {
            Console.Clear();

            int id = ConsoleUser.GetInt("Введите ID студента");
            string name = ConsoleUser.GetString("Введите имя студента:");
            string speciality = ConsoleUser.GetString("Введите специальность студента:");
            string group = ConsoleUser.GetString("Введите группу студента:");

            StudentDTO[] students = studentManager.ReadAllStudents().ToArray();

            foreach(StudentDTO s in students)
            {
                if(s.ID == id)
                {
                    s.Name = name;
                    s.Speciality = speciality;
                    s.Group = group;
                    studentManager.UpdateStudent(s);
                    PrintMainMenu();
                    return;
                }
            }

            Console.WriteLine("Студента с таким ID не найдено");

            PrintMainMenu();
        }

        private static void PrintAllStudents()
        {
            Console.Clear();

            StudentDTO[] students = studentManager.ReadAllStudents().ToArray();

            foreach(StudentDTO s in students)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();

            PrintMainMenu();
        }

        private static void PrintHistogram()
        {
            Console.Clear();

            Histogram histogram = new Histogram() { Height = 20 };

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(histogram.GetHistogram(studentManager.GetSpecialitiesMembersCount()));
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();

            PrintMainMenu();
        }
    }
}
