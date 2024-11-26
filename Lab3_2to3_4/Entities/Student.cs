namespace Entities
{
    public class Student
    {
        public readonly int ID;

        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }

        public Student(int id)
        {
            ID = id;
        }

        public Student(int id, string name, string speciality, string studentGroup)
        {
            ID = id;
            Name = name;
            Speciality = speciality;
            Group = studentGroup;
        }
    }
}

