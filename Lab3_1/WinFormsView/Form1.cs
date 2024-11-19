using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsView
{
    public partial class Form1 : Form
    {
        StudentManager StudentManager = new StudentManager();

        public List<StudentDTO> students;

        public Form1()
        {
            InitializeComponent();
            DataUpdate();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm(StudentManager);
            sf.ShowDialog();
            DataUpdate();
        }

        //private void modifyButton_Click(object sender, EventArgs e)
        //{
        //    StudentForm sf = new StudentForm(StudentManager, studentListBox.SelectedItem as StudentDTO);
        //    sf.ShowDialog();
        //    DataUpdate();
        //}

        private void DataUpdate()
        {
            studentListBox.Items.Clear();
            studentListBox.Items.AddRange(StudentManager.ReadAllStudents().ToArray());

            dataGridView1.DataSource = students;

            var chartData = StudentManager.GetSpecialitiesMembersCount();

            Chart1.Series.Clear();
            foreach (var name in chartData.Keys)
            {
                Chart1.Series.Add(name);
            }
            foreach (var item in chartData)
            {
                Chart1.Series[item.Key].Points.Add(item.Value);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(studentListBox.SelectedItem != null)
            {
                var s = studentListBox.SelectedItem as StudentDTO;
                StudentManager.DeleteStudent(s.ID);
                DataUpdate();
            }
        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
