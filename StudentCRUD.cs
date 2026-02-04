using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _4_2_LMS_login
{
    public partial class StudentCRUD : Form
    {
        private BindingList<Student> students = new BindingList<Student>();
        private Random rnd = new Random();

        public StudentCRUD()
        {
            InitializeComponent();
        }

        private void StudentCRUD_Load(object sender, EventArgs e)
        {
            students = DummyStudentData.GenerateStudents(rnd.Next(5, 100));
            dataGridView1.DataSource = students;
        }

        private int GetNextStudentId()
        {
            if (students.Count == 0)
                return 1;

            return students.Max(s => s.Id) + 1;
        }

        private void AddStudent(string firstName, string lastName, float gpa)
        {
            var newStudent = new Student
            {
                Id = GetNextStudentId(),
                FirstName = firstName,
                LastName = lastName,
                GPA = gpa,

            };

            students.Add(newStudent);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent(
                txtFirst.Text,
                txtLast.Text,
                float.Parse(txtGPA.Text)

            );
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            var selected =dataGridView1.SelectedRows[0].DataBoundItem as Student;
            if (selected != null) students.Remove(selected);
        }
    }
}