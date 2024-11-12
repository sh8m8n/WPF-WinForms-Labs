using Interactors.DTOs;

namespace Interactors.Interfaces
{
    public interface IErrorNotificationInputPort
    {
        void NotificateError (ErrorData errorData);
    }
}
