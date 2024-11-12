using ConsoleView.Presenters;
using ConsoleView.ViewModels;
using System;

namespace ConsoleView.View
{
    public class ErrorWindow : IErrorWindowView
    {
        public void Render(ErrorWindowViewModel viewModel)
        {
            Console.Clear();

            Console.ForegroundColor = viewModel.MessageColor;
            Console.WriteLine("\tОШИБКА:");
            Console.WriteLine(viewModel.Message.ToUpper());

            Console.ForegroundColor = viewModel.PreventActionsColor;
            Console.WriteLine(viewModel.PreventActions.ToLower());
            Console.WriteLine("нажмите любую клавишу...");
        }
    }
}
