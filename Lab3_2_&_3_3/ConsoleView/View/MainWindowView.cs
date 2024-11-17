using ConsoleView.Presenters;
using ConsoleView.ViewModels;
using System;

namespace ConsoleView.View
{
    public class MainWindowView : IMainWindowView
    {
        public void Render(MainWindowViewModel viewModel)
        {
            Console.Clear();


            //Команды
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
                $"Список доступных команд / шаблон ввода:" +
                $"\n\tДобавить студента : 1 (Name) (Group) (Speciality)" +
                $"\n\tУдалить студента : 2 (ID)" +
                $"\n\tИзменить студента : 3 (ID) (New Name) (New Group) (New Speciality)");


            //Гистограмма
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\n\n{viewModel.StudentHistogram}");


            //Таблица
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n\n{viewModel.StudentSheet}");
        }
    }
}
