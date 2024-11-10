using ConsoleView;
using BusinessLogic;
using RAMDataBase;
using Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.DTOs;
using DapperDataBase;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleViewDapperDemo();
        }

        static void ConsoleViewDapperDemo()
        {
            MainWindow mainWindow = new MainWindow();

            mainWindow.studentManager.studentRepositoryFactory = new DapperStudentRepoFactory();

            //Заполнение тестовыми данными
            for (int i = 0; i < 10; i++)
            {
                StudentData s = new StudentData();
                s.Name = $" Газманов2-{i}";
                s.Speciality = "ИБ";
                s.Group = "1";

                mainWindow.studentManager.Create(s);
            }

            for (int i = 0; i < 19; i++)
            {
                StudentData s = new StudentData();
                s.Name = $" Газманов-{i}";
                s.Speciality = "ИСИТ";
                s.Group = "1";

                mainWindow.studentManager.Create(s);
            }

            for (int i = 0; i < 15; i++)
            {
                StudentData s = new StudentData();
                s.Name = $" Газманов3-{i}";
                s.Speciality = "САС";
                s.Group = "1";

                mainWindow.studentManager.Create(s);
            }

            for (int i = 0; i < 6; i++)
            {
                StudentData s = new StudentData();
                s.Name = $" Газманов4-{i}";
                s.Speciality = "ГУГ";
                s.Group = "1";

                mainWindow.studentManager.Create(s);
            }

            mainWindow.Show();
        }

        static void ConsoleViewRamDatabaseDemo()
        {
            MainWindow mainWindow = new MainWindow();

            mainWindow.studentManager.studentRepositoryFactory = new StudentRepositoryFactory();

            //Заполнение тестовыми данными
            for (int i = 0; i < 10; i++)
            {
                StudentData s = new StudentData();
                s.Name = $" Газманов2-{i}";
                s.Speciality = "ИБ";
                s.Group = "1";

                mainWindow.studentManager.Create(s);
            }

            for (int i = 0; i < 19; i++)
            {
                StudentData s = new StudentData();
                s.Name = $" Газманов-{i}";
                s.Speciality = "ИСИТ";
                s.Group = "1";

                mainWindow.studentManager.Create(s);
            }

            for (int i = 0; i < 15; i++)
            {
                StudentData s = new StudentData();
                s.Name = $" Газманов3-{i}";
                s.Speciality = "САС";
                s.Group = "1";

                mainWindow.studentManager.Create(s);
            }

            for (int i = 0; i < 6; i++)
            {
                StudentData s = new StudentData();
                s.Name = $" Газманов4-{i}";
                s.Speciality = "ГУГ";
                s.Group = "1";

                mainWindow.studentManager.Create(s);
            }

            mainWindow.Show();
        }

        static void ConsoleViewRamDatabase()
        {
            MainWindow mainWindow = new MainWindow();

            mainWindow.studentManager.studentRepositoryFactory = new StudentRepositoryFactory();

            mainWindow.Show();
        }
    }
}
