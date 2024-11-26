using System.Data;

namespace WinFormsUI.ViewModels
{
    public class MainWindowViewModel
    {
        public DataTable StudentsTable { get; set; }

        public Dictionary<string, int> SpecialitiesMemberCount { get; set; }
    }
}
