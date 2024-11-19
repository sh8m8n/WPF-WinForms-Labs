using System.Collections.Generic;
using System.Data;

namespace WinFormsView.ViewModels
{
    public class MainWindowViewModel
    {
        public DataTable StudentsTable { get; set; }

        public Dictionary<string, int> SpecialitiesMemberCount { get; set; }
    }
}
