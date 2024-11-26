using ConsoleUI.Presenters.Interfaces;
using ConsoleUI.ViewModels;

namespace ConsoleUI.View
{
    public class MainWindowView : IMainWindowView
    {
        private readonly int CommandsSummaryHeight = 4;
        private readonly string CommandAskString = ">";

        public void Render(MainWindowViewModel viewModel)
        {
            Console.Clear();


            //Команды
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
                $"Список доступных команд / шаблон ввода:" +
                $"\n\tДобавить студента : add (Name) (Group) (Speciality)" +
                $"\n\tУдалить студента : delete (ID)" +
                $"\n\tИзменить студента : update (ID) (New Name) (New Group) (New Speciality)");

            //Ввод команды

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{CommandAskString}");

            //Гистограмма
            Console.ForegroundColor = viewModel.HistogramColor;
            Console.WriteLine($"\n\n{viewModel.StudentHistogram}");


            //Таблица
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n\n{viewModel.StudentSheet}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(CommandAskString.Length, CommandsSummaryHeight + 1);
        }
    }
}
