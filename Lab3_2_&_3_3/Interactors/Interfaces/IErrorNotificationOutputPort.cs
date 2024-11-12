using Interactors.DTOs;

namespace Interactors.Interfaces
{
    public interface IErrorNotificationOutputPort
    {
        void Present(ErrorData errorData);
    }
}
