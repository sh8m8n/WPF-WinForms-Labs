using Model;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class StudentManager
    {
        private IStudentDB studentsData = new StudentDataBase();

        public StudentManager()
        {
            //Заполнение данными
            for (int i = 0; i < 10; i++)
            {
                studentsData.Create($" Газманов2-{i}", "ИБ", "1");
            }

            for (int i = 0; i < 19; i++)
            {
                studentsData.Create($"Газманов{i}", "ИСИТ", "1");
            }

            for (int i = 0; i < 15; i++)
            {
                studentsData.Create($"Газманов-3{i}", "САС", "1");
            }

            for (int i = 0; i < 6; i++)
            {
                studentsData.Create($"Газманов-4{i}", "ВАЗ", "1");
            }


        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Key:Специальность Value:Количество последователей</returns>
        public Dictionary<string, int> GetSpecialitiesMembersCount()
        {
            return studentsData.ReadAll().GroupBy(s => s.Speciality).ToDictionary(g => g.Key, g => g.Count());
        }

        /// <summary>
        /// Создает нового студента в базе данных
        /// </summary>
        /// <param name="name"></param>
        /// <param name="speciality"></param>
        /// <param name="group"></param>
        public void CreateStudent(string name, string speciality, string group)
        {
            studentsData.Create(name, speciality, group);
        }

        /// <summary>
        /// Возвращает студента
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StudentDTO ReadStudent(int id)
        {
            return StudentDTOAssembler.WriteDTO(studentsData.Read(id));
        }

        /// <summary>
        /// Возвращает всех студентов
        /// </summary>
        /// <returns></returns>
        public IEnumerable<StudentDTO> ReadAllStudents()
        {
            return studentsData.ReadAll().Select(s => StudentDTOAssembler.WriteDTO(s));
        }

        /// <summary>
        /// Обновляет поля студента
        /// </summary>
        /// <param name="studentDTO"></param>
        public void UpdateStudent(StudentDTO studentDTO)
        {
            studentsData.Update(StudentDTOAssembler.ReadDTO(studentDTO));
        }

        /// <summary>
        /// Удаляет студента
        /// </summary>
        /// <param name="studentDTO"></param>
        public void DeleteStudent(int id)
        {
            studentsData.Delete(id);
        }
    }
}
