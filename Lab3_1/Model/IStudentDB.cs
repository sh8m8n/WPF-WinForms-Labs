using System.Collections.Generic;

namespace Model
{
    public interface IStudentDB
    {
        void Create(string name, string speciality, string group);

        Student Read(int id);

        IEnumerable<Student> ReadAll();

        void Update(Student student);

        void Delete(int id);
    }
}
