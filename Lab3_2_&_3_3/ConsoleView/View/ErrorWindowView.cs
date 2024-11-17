using ConsoleView.Presenters;
using ConsoleView.ViewModels;
using System;

namespace ConsoleView.View
{
    public class ErrorWindowView : IErrorWindowView
    {
        public const string ErrorTitle = "ОШИБКА:";
        public const string PressAnyKeyString = "нажмите любую клавишу...";
        public readonly int CountOfStringsInMessage = 4;

        public readonly int MinimumWindowWidth = 40;
        public readonly int MinimumWindowHeight = 10;

        public void Render(ErrorWindowViewModel viewModel)
        {
            if(!ValidateWindowSize())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Невозможно отобразить содержимое, увеличьте окно");
                return;
            }

            Console.Clear();

            //Ошибка
            Console.ForegroundColor = viewModel.MessageColor;
            
            Console.SetCursorPosition(Console.WindowWidth / 2 - ErrorTitle.Length / 2,
                Console.WindowHeight / 2 - CountOfStringsInMessage);
            Console.WriteLine(ErrorTitle);

            Console.SetCursorPosition(Console.WindowWidth / 2 - viewModel.Message.Length / 2,
                Console.WindowHeight / 2 - CountOfStringsInMessage + 1);
            Console.WriteLine(viewModel.Message.ToUpper());

            //Пояснения
            Console.ForegroundColor = viewModel.PreventActionsColor;

            Console.SetCursorPosition(Console.WindowWidth / 2 - viewModel.PreventActions.Length / 2,
                Console.WindowHeight / 2 - CountOfStringsInMessage + 3);
            Console.WriteLine(viewModel.PreventActions.ToLower());

            Console.SetCursorPosition(Console.WindowWidth / 2 - PressAnyKeyString.Length / 2,
                Console.WindowHeight / 2 - CountOfStringsInMessage + 4);
            Console.WriteLine(PressAnyKeyString);
        }

        /// <summary>
        /// true - все норм
        /// </summary>
        /// <returns>Правильность размеров окна</returns>
        private bool ValidateWindowSize()
        {
            if(Console.WindowWidth < MinimumWindowWidth || Console.WindowHeight < MinimumWindowHeight)
            {
                return false;
            }
            return true;
        }
    }
}
