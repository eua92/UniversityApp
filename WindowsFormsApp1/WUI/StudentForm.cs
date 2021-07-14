using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1
{
    public partial class StudentForm : Form
    {
        public University NewUniversity = new University();
        public Student SelectedStudent { 
            get => dataGridViewStudents.SelectedRows[0].DataBoundItem as Student; 
            set => SelectedStudent = value; }

        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FindCourses();
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        private void LoadData()
        {
            dataGridViewStudents.DataSource = NewUniversity.Students;
            dataGridViewStudents.Columns["ID"].Visible = false;
            dataGridViewStudents.Columns["BirthDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            FindCourses();
        }

        private void CloseForm()
        {
            Close();
        }

        private void FindCourses()
        {
            string courses = "";
            foreach (var item in SelectedStudent.Courses)
            {
                courses += String.Format("{0}, ", item);
            }

            ctrlCourses.Text = courses.Substring(0, courses.Length - 2);
        }
    }
}
