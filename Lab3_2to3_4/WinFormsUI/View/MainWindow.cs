using WinFormsUI.Presenters.Interfaces;
using WinFormsUI.ViewModels;

namespace WinFormsView.View
{
    public partial class MainWindow : Form, IStudentManagementView
    {
        public IStudentManagementController studentManagementController { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Render(MainWindowViewModel mainViewModel)
        {
            StudentsDataGrid.DataSource = mainViewModel.StudentsTable;

            StudentsChart.Series.Clear();
            foreach (var name in mainViewModel.SpecialitiesMemberCount.Keys)
            {
                StudentsChart.Series.Add(name);
            }
            foreach (var item in mainViewModel.SpecialitiesMemberCount)
            {
                StudentsChart.Series[item.Key].Points.Add(item.Value);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            StudentWindow studentWindow = new StudentWindow();
            studentWindow.FormClosing += AddFormClosing;
            studentWindow.ShowDialog();
        }

        private void AddFormClosing(object sender, FormClosingEventArgs e)
        {
            var f = sender as StudentWindow;

            studentManagementController.Add(f.NameStudent, f.Speciality, f.Group);
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (StudentsDataGrid.SelectedRows.Count > 0)
            {
                int id = 0;
                string name = string.Empty;
                string specialty = string.Empty;
                string group = string.Empty;

                DataGridViewRow selectedRow = StudentsDataGrid.SelectedRows[0];

                id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                name = selectedRow.Cells["Имя"].Value.ToString();
                specialty = selectedRow.Cells["Специальность"].Value.ToString();
                group = selectedRow.Cells["Группа"].Value.ToString();

                StudentWindow studentWindow = new StudentWindow(name, specialty, group);
                studentWindow.FormClosing += UpdateFormClosing;
                studentWindow.ShowDialog();
            }
        }

        private void UpdateFormClosing(object sender, FormClosingEventArgs e)
        {
            if (StudentsDataGrid.SelectedRows.Count > 0)
            {
                int id = 0;
                DataGridViewRow selectedRow = StudentsDataGrid.SelectedRows[0];
                id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                var f = sender as StudentWindow;


                studentManagementController.Update(id, f.NameStudent, f.Speciality, f.Group);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (StudentsDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = StudentsDataGrid.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                studentManagementController.Delete(id);
            }
        }
    }
}
