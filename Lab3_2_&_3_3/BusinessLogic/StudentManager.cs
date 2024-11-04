using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class StudentManager : IStudentManager
    {
        private IRepository<Student> repository;
        public IRepositoryFactory<Student> studentRepositoryFactory
        {   
            get => repositoryFactory1;
            set
            {
                repositoryFactory1 = value;
                repository = studentRepositoryFactory.CreateInstance();
            }
        }

        private StudentDTOAssembler studentDTOAssembler;
        private IRepositoryFactory<Student> repositoryFactory1;

        public StudentManager()
        {
            studentDTOAssembler = new StudentDTOAssembler();
        }

        public void Create(StudentData studentData)
        {
            Student newStudent = repository.Create();

            newStudent.Name = studentData.Name;
            newStudent.Speciality = studentData.Speciality;
            newStudent.Group = studentData.Group;

            repository.Update(newStudent);
        }

        public StudentDTO Read(int id)
        {
            return studentDTOAssembler.Create(repository.Read(id));
        }

        public IEnumerable<StudentDTO> ReadAll()
        {
            return repository.ReadAll().Select(s => studentDTOAssembler.Create(s));
        }

        public void Update(int id, StudentData newData)
        {
            Student student = repository.Read(id);

            student.Name = newData.Name;
            student.Speciality = newData.Speciality;
            student.Group = newData.Group;

            repository.Update(student);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
