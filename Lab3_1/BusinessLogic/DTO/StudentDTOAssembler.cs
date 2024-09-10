using Model;

namespace BusinessLogic
{
    public static class StudentDTOAssembler 
    {
        /// <summary>
        /// Создает обьект StudentDTO на основе Student
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public static StudentDTO WriteDTO(Student student)
        {
            return new StudentDTO()
            {
                Name = student.Name,
                Speciality = student.Speciality,
                Group = student.Group,
                ID = student.ID
            };
        }

        /// <summary>
        /// Создает обьект Student на основе StudentDTO
        /// </summary>
        /// <param name="studentDTO"></param>
        /// <returns></returns>
        public static Student ReadDTO(StudentDTO studentDTO)
        {
            return new Student(studentDTO.ID, studentDTO.Name, studentDTO.Speciality, studentDTO.Group);
        }
    }
}
