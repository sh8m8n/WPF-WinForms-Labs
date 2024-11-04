using BusinessLogic.DTOs;
using System.Collections.Generic;
using Entities;
using BusinessLogic.Interfaces;

namespace BusinessLogic
{
    public interface IStudentManager
    {
        IRepositoryFactory<Student> studentRepositoryFactory { get; set; }

        void Create(StudentData studentData);

        StudentDTO Read(int id);

        IEnumerable<StudentDTO> ReadAll();

        void Update(int id, StudentData newData);

        void Delete(int id);
    }
}