using Interactors.DTOs;
using Interactors.Interfaces;
using Entities;
using System.Linq;

namespace Interactors
{
    public class StudentManagementUseCase : IStudentsManagementInputPort
    {
        public IRepository<Student> studentRepository;

        public IStudentManagementOutputPort presenter;

        public void CreateStudent(StudentPersonalData personalData)
        {
            var newStudent = studentRepository.Create();

            newStudent.Name = personalData.Name;
            newStudent.Speciality = personalData.Speciality;
            newStudent.Group = personalData.Group;

            studentRepository.Update(newStudent);

            PresentChanges();
        }

        public void ReadAllStudents()
        {
            PresentChanges();
        }

        public void DeleteStudent(int ID)
        {
            studentRepository.Delete(ID);

            PresentChanges();
        }

        public void UpdateStudent(int ID, StudentPersonalData newPersonalData)
        {
            var student = studentRepository.Read(ID);

            student.Name = newPersonalData.Name;
            student.Speciality = newPersonalData.Speciality;
            student.Group = newPersonalData.Group;

            studentRepository.Update(student);

            PresentChanges();
        }

        /// <summary>
        /// Обновляет данные о ВСЕХ студентах
        /// </summary>
        private void PresentChanges()
        {
            var studentList = studentRepository.ReadAll().Select(s =>
            {
                return new StudentDTO
                {
                    Name = s.Name,
                    Speciality = s.Speciality,
                    Group = s.Group
                };
            });
            presenter.Present(studentList);
        }
    }
}
