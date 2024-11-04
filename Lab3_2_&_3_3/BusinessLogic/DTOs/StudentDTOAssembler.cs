using BusinessLogic.Interfaces;
using Entities;

namespace BusinessLogic.DTOs
{
    public class StudentDTOAssembler : IDTOAssembler<Student, StudentDTO>
    {
        public StudentDTO Create(Student student)
        {
            return new StudentDTO
            {
                ID = student.ID,
                Name = student.Name,
                Speciality = student.Speciality,
                Group = student.Group,
            };
        }
    }
}
