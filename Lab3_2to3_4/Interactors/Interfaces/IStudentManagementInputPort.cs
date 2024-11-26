using Interactors.DTOs;

namespace Interactors.Interfaces
{
    public interface IStudentsManagementInputPort
    {
        void CreateStudent(StudentPersonalData personalData);

        void ReadAllStudents();

        void DeleteStudent(int ID);

        /// <summary>
        /// Меняет данные студента с указанным ID
        /// </summary>
        /// <param name="ID">айди студента для обновления</param>
        /// <param name="newPersonalData">новые персональные данные</param>
        void UpdateStudent(int ID, StudentPersonalData newPersonalData);
    }
}
