namespace Interactors.DTOs
{
    /// <summary>
    /// Создается интеракторами, используется во внешних кругах
    /// </summary>
    public class StudentDTO
    {
        private int iD;
        private string name;
        private string speciality;
        private string group;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value ?? "Null"; }
        public string Speciality { get => speciality; set => speciality = value ?? "Null"; }
        public string Group { get => group; set => group = value ?? "Null"; }
    }
}
