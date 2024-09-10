using System;

namespace Model
{
    public class Student : ICloneable
    {
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }
        public readonly int ID;


        public Student(int id, string name, string speciality, string group)
        {
            ID = id;
            Name = name;
            Speciality = speciality;
            Group = group;
        }


        public object Clone() => MemberwiseClone();

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if(this.GetType() != obj.GetType()) return false;

            Student student = obj as Student;
            if(ID != student.ID) return false;

            return true;
        }

        public override int GetHashCode()
        {
            return ID;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Имя: {Name}, Специальность: {Speciality}, Группа {Group}";
        }

        public static bool operator ==(Student a, Student b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Student a, Student b)
        {
            return !a.Equals(b);
        }
    }
}
