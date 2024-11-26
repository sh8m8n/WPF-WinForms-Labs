using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDataBase.DataBaseEntities
{
    internal class StudentDB
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string speciality { get; set; }
        public string studentgroup { get; set; }
    }
}
