namespace ConsoleView
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Speciality { get; set; }

        public string Group { get; set;}


        public static int ToStringLength
        {
            get
            {
                return maxIDlength + maxNamelength + maxSpecialitylength +
                    maxGrouplength + 5;
            }
        }

        private static int maxIDlength;
        private static int maxNamelength;
        private static int maxSpecialitylength;
        private static int maxGrouplength;

        public Student(int id, string name, string speciality, string group)
        {
            Id = id;
            Name = name;
            Speciality = speciality;
            Group = group;

            if(id.ToString().Length > maxIDlength)
                maxIDlength = id.ToString().Length;
            if(name.Length > maxNamelength)
                maxNamelength = name.Length;
            if(speciality.Length > maxSpecialitylength)
                maxSpecialitylength = speciality.Length;
            if(group.Length > maxGrouplength)
                maxGrouplength = group.Length;
        }

        public override string ToString()
        {
            return $"|{Id}{new string(' ', maxIDlength - Id.ToString().Length)}" +
                $"|{Name}{new string(' ', maxNamelength - Name.Length)}" +
                $"|{Speciality}{new string(' ', maxSpecialitylength - Speciality.Length)}" +
                $"|{Group}{new string(' ', maxGrouplength - Group.Length)}|";
        }
    }
}
