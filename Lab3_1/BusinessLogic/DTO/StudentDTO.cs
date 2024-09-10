namespace BusinessLogic
{
    public class StudentDTO
    {
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }
        public int ID { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Имя: {Name}, Специальность: {Speciality}, Группа {Group}";
        }
    }
}
