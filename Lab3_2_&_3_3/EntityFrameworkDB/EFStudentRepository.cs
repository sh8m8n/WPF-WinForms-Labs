using System.Collections.Generic;
using System.Linq;
using Interactors.Interfaces;
using Entities;

namespace EntityFrameworkDB
{
    public class EFStudentRepository : IRepository<Student>
    {
        private readonly ApplicationDbContext _context;

        internal EFStudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Student Create()
        {
            var studentDB = new StudentDB(); // ID будет присвоен при добавлении в базу
            _context.Students.Add(studentDB);
            _context.SaveChanges();
            return new Student(studentDB.StudentID, studentDB.Name, 
                studentDB.Speciality, studentDB.Group);
        }

        public void Delete(int ID)
        {
            var student = Read(ID);
            if (student != null)
            {
                _context.Students.Remove(new StudentDB
                {
                    StudentID = student.ID,
                    Name = student.Name,
                    Group = student.Group,
                    Speciality = student.Speciality
                });
                _context.SaveChanges();
            }
        }

        public void Update(Student entity)
        {
            _context.Students.Update(new StudentDB
            {
                StudentID = entity.ID,
                Name = entity.Name,
                Group = entity.Group,
                Speciality = entity.Speciality
            });
        }

        public Student Read(int ID)
        {
            foreach (var studentDB in _context.Students)
            {
                if (studentDB.StudentID == ID)
                {
                    return new Student(studentDB.StudentID, studentDB.Name,
                studentDB.Speciality, studentDB.Group);
                }
            }
            return null;
        }

        public IEnumerable<Student> ReadAll()
        {
            return _context.Students
                .Select(s => new Student(s.StudentID, s.Name, s.Speciality, s.Group)).ToList();
        }
    }
}
