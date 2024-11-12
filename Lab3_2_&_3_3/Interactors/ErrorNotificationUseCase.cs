using Interactors.DTOs;
using Interactors.Interfaces;

namespace Interactors
{
    public class ErrorNotificationUseCase : IErrorNotificationInputPort
    {
        public IErrorNotificationOutputPort presenter;

        public void NotificateError(ErrorData errorData)
        {
            presenter.Present(errorData);  
        }
    }
}
