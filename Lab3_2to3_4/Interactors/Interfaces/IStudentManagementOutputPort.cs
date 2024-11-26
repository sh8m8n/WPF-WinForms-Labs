using Interactors.DTOs;

namespace Interactors.Interfaces
{
    public interface IStudentManagementOutputPort
    {
        void Present(IEnumerable<StudentDTO> students);
    }
}
