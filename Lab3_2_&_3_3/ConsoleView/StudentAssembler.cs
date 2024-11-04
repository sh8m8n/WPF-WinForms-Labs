using BusinessLogic;
using BusinessLogic.DTOs;

namespace ConsoleView
{
    public class StudentAssembler : IDTOAssembler<StudentDTO, Student>
    {
        public Student Create(StudentDTO entity)
        {
            return new Student(entity.ID, entity.Name, entity.Speciality, entity.Group);
        }
    }
}
