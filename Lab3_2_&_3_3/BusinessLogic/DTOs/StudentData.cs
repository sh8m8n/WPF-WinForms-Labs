namespace BusinessLogic.DTOs
{
    /// <summary>
    /// Простая структура данных предназначенная для запросов на создание студентов, не содержит ID
    /// </summary>
    public class StudentData
    {
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }
    }
}
