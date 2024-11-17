﻿using ConsoleView.ViewModels;
using Interactors;
using Interactors.DTOs;
using Interactors.Interfaces;

namespace ConsoleView.Presenters
{
    public class ErrorPresenter : IErrorNotificationOutputPort
    {
        public IErrorWindowView errorWindow;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">Сообщение об ошибке</param>
        public void Present(ErrorData errorData)
        {
            ErrorWindowViewModel errorVM = new ErrorWindowViewModel(errorData.Message, errorData.PreventActions,
                System.ConsoleColor.DarkRed, System.ConsoleColor.Red);

            errorWindow.Render(errorVM);
        }
    }
}
