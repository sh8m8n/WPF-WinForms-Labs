using System;

namespace ConsoleView.ViewModels
{
    public class ErrorWindowViewModel
    {
        public string Message { get; set; }
        public ConsoleColor MessageColor { get; set; }

        public string PreventActions { get; set; }
        public ConsoleColor PreventActionsColor { get; set; }

        public ErrorWindowViewModel(string message, string preventActions,
            ConsoleColor messageColor, ConsoleColor preventColor)
        {
            Message = message;
            MessageColor = messageColor;
            PreventActions = preventActions;
            PreventActionsColor = preventColor;
        }
    }
}
