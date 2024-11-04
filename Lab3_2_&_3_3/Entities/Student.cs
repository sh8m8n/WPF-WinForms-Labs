namespace Entities
{
    public class Student : IEntity
    {
        public int ID { get; private set; }

        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }

        public Student(int id)
        {
            ID = id;
        }
    }
}
