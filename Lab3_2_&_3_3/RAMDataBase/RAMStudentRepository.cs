using Entities;
using Interactors.Interfaces;
using System.Collections.Generic;

namespace RAMDataBase
{
    internal class RAMStudentRepository : IRepository<Student>
    {
        private List<Student> students = new List<Student>();
        private int LastID = 0;

        public Student Create()
        {
            Student student = new Student(LastID);
            LastID++;

            students.Add(student);
            
            return student;
        }

        public Student Read(int id)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].ID == id)
                    return students[i];
            }

            return null;
        }

        public IEnumerable<Student> ReadAll()
        {
            return students;
        }

        public void Update(Student entity)
        {
            foreach (Student student in students)
            {
                if(student.ID == entity.ID)
                {
                    student.Name = entity.Name;
                    student.Speciality = entity.Speciality;
                    student.Group = entity.Group;
                }    
            }
        }

        public void Delete(int id)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].ID == id)
                    students.Remove(students[i]);
            }
        }
    }
}
