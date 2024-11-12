﻿namespace Interactors.DTOs
{
    /// <summary>
    /// Создается интеракторами, используется во внешних кругах
    /// </summary>
    public class StudentDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }
    }
}