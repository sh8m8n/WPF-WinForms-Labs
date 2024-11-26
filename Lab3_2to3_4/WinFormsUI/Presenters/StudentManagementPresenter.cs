using Interactors.DTOs;
using Interactors.Interfaces;
using System.Data;
using WinFormsUI.Presenters.Interfaces;
using WinFormsUI.ViewModels;

namespace WinFormsUI.Presenters
{
    public class StudentManagementPresenter : IStudentManagementOutputPort, IStudentManagementController
    {
        public IStudentsManagementInputPort studentManager { get; set; }

        public IStudentManagementView view { get; set; }

        public void Present(IEnumerable<StudentDTO> students)
        {
            if (students == null)
            {
                return;
            }

            DataTable studentDataTable = new DataTable();
            studentDataTable.Columns.Add("ID", typeof(int));
            studentDataTable.Columns.Add("Имя", typeof(string));
            studentDataTable.Columns.Add("Специальность", typeof(string));
            studentDataTable.Columns.Add("Группа", typeof(string));

            foreach (StudentDTO student in students)
            {
                studentDataTable.Rows.Add(new object[] { student.ID, student.Name, student.Speciality, student.Group });
            }

            var specialityMemberCount = students.GroupBy(s => s.Speciality).ToDictionary(g => g.Key, g => g.Count());

            MainWindowViewModel vm = new MainWindowViewModel()
            {
                StudentsTable = studentDataTable,
                SpecialitiesMemberCount = specialityMemberCount,
            };

            view.Render(vm);
        }

        public void Add(string Name, string Speciality, string Group)
        {
            studentManager.CreateStudent(new StudentPersonalData
            {
                Name = Name,
                Speciality = Speciality,
                Group = Group
            });
        }

        public void Delete(int ID)
        {
            studentManager.DeleteStudent(ID);
        }

        public void Update(int ID, string Name, string Speciality, string Group)
        {
            studentManager.UpdateStudent(ID, new StudentPersonalData
            {
                Name = Name,
                Speciality = Speciality,
                Group = Group
            });
        }
    }
}
