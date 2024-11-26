using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI.Views
{
    public partial class StudentWindow : Form
    {
        public string NameStudent { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }

        public StudentWindow()
        {
            InitializeComponent();
        }

        public StudentWindow(string name, string speciality, string group)
        {
            InitializeComponent();
            Name_txtBox.Text = name;
            Spec_txtBox.Text = speciality;
            Group_txtBox.Text = group;
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            NameStudent = Name_txtBox.Text;
            Speciality = Spec_txtBox.Text;
            Group = Group_txtBox.Text;

            this.Close();
        }
    }
}
