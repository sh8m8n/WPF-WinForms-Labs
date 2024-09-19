using System;
using BusinessLogic;
using System.Windows.Forms;

namespace WinFormsView
{
    public partial class StudentForm : Form
    {
        StudentManager studentManager;
        StudentDTO studentDTO;

        public StudentForm(StudentManager studentManager, StudentDTO student)
        {
            InitializeComponent();
            this.studentManager = studentManager;
            this.studentDTO = student;
        }

        public StudentForm(StudentManager studentManager)
        {
            InitializeComponent();
            this.studentManager = studentManager;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (studentDTO == null)
            {
                studentManager.CreateStudent(NameTextBox.Text,
                SpecialityTextBox.Text, GroupTextBox.Text);
                this.Close();
            }
            else
            {
                studentDTO.Name = NameTextBox.Text;
                studentDTO.Speciality = SpecialityTextBox.Text;
                studentDTO.Group = GroupTextBox.Text;
                studentManager.UpdateStudent(studentDTO);
                this.Close();
            }

        }
    }
}
