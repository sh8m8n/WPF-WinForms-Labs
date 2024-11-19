namespace WinFormsView.Presenter
{
    public interface IStudentManagementController
    {
        void Add(string Name ,string Speciality, string Group);

        void Delete(int ID);

        void Update(int ID, string Name, string Speciality, string Group);
    }
}
