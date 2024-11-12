using ConsoleView.ViewModels;
using Interactors;
using Interactors.DTOs;
using Interactors.Interfaces;

namespace ConsoleView.Presenters
{
    internal class ErrorPresenter : IErrorNotificationOutputPort
    {
        IErrorWindowView errorWindow;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">Сообщение об ошибке</param>
        public void Present(ErrorData errorData)
        {
            ErrorWindowViewModel errorVM = new ErrorWindowViewModel(errorData.Message, errorData.PreventActions,
                System.ConsoleColor.Red, System.ConsoleColor.DarkRed);

            errorWindow.Render(errorVM);
        }
    }
}
