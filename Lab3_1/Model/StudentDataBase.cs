using System.Collections.Generic;
using System.Linq;

namespace Model
{
    public class StudentDataBase : IStudentDB
    {
        private List<Student> _students = new List<Student>();
        private int lastID = 0;

        /// <summary>
        /// Добавляет студента в базу данных
        /// </summary>
        /// <param name="student"></param>
        public void Create(string name, string speciality, string group)
        {
            _students.Add(new Student(lastID, name, speciality, group));
            lastID++;
        }

        /// <summary>
        /// Удаляет студента из базы данных
        /// </summary>
        /// <param name="student"></param>
        public void Delete(int id)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i].ID ==id)
                {
                    _students.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Возвращает копию первого вхождения
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Student Read(int id)
        {
            return _students.Where(s => s.ID == id).FirstOrDefault().Clone() as Student;
        }

        /// <summary>
        /// Возвращает копии всех студентов из базы данных
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Student> ReadAll()
        {
            return _students.Select(s => s.Clone() as Student);
        }

        /// <summary>
        /// Обновляет поля указанного студента
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Update(Student student)
        {
            foreach (var s in _students)
            {
                if (s.Equals(student) )
                {
                    s.Name = student.Name;
                    s.Speciality = student.Speciality;
                    s.Group = student.Group;
                }
            }
        }
    }
}
