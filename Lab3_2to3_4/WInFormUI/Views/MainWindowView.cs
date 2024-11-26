using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUI.Presenters.Interfaces;
using WinFormsUI.ViewModels;

namespace WinFormsUI.Views
{
    public partial class MainWindowView : Form, IStudentManagementView
    {
        public IStudentManagementController studentManagementController { get; set; }

        public MainWindowView()
        {
            InitializeComponent();
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

        public void Render(MainWindowViewModel mainViewModel)
        {
            StudentsDataGrid.DataSource = mainViewModel.StudentsTable;

            Histogram histogram = new Histogram() { Height = 10, SummaryBulgingLength = 5 };
            Chart_txtBox.Text = histogram.GetHistogram(mainViewModel.SpecialitiesMemberCount);
        }
    }
}
