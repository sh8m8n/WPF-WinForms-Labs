using Interactors.DTOs;
using Interactors.Interfaces;
using Entities;

namespace Interactors
{
    public class StudentManagementUseCase : IStudentsManagementInputPort
    {
        private IRepository<Student> studentRepository;

        public IRepositoryFactory<IRepository<Student>> repositoryFactory
        {
            get => repositoryFactory1;
            set
            {
                repositoryFactory1 = value;
                studentRepository = repositoryFactory.Create();
            }
        }

        public IStudentManagementOutputPort presenter;
        private IRepositoryFactory<IRepository<Student>> repositoryFactory1;

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

            if (student == null)
                return;

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
                    ID = s.ID,
                    Name = s.Name,
                    Speciality = s.Speciality,
                    Group = s.Group
                };
            });
            presenter.Present(studentList);
        }
    }
}
