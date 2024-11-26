using Entities;
using EntityFrameworkDataBase.DataBaseEntities;
using Interactors.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDataBase
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
            _context.students.Add(studentDB);
            _context.SaveChanges();
            return new Student(studentDB.id, studentDB.name,
                studentDB.speciality, studentDB.studentgroup);
        }

        public void Delete(int ID)
        {
            var studentDB = _context.students.Find(ID);
            if (studentDB != null)
            {
                _context.Remove(studentDB);
                _context.SaveChanges();
            }
        }

        public void Update(Student entity)
        {
            var studentDB = _context.students.Find(entity.ID);
            if(studentDB != null)
            {
                studentDB.name = entity.Name;
                studentDB.speciality = entity.Speciality;
                studentDB.studentgroup = entity.Group;

                _context.Update(studentDB);
                _context.SaveChanges();
            }
        }

        public Student Read(int ID)
        {
            foreach (var studentDB in _context.students)
            {
                if (studentDB.id == ID)
                {
                    return new Student(studentDB.id, studentDB.name,
                studentDB.speciality, studentDB.studentgroup);
                }
            }
            return null;
        }

        public IEnumerable<Student> ReadAll()
        {
            var s = _context.students;

            return _context.students
                .Select(s => new Student(s.id, s.name, s.speciality, s.studentgroup)).ToList();
        }
    }
}
