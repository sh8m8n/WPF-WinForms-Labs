using Interactors.DTOs;
using System.Collections.Generic;

namespace Interactors.Interfaces
{
    public interface IStudentManagementOutputPort
    {
        void Present(IEnumerable<StudentDTO> students);
    }
}
