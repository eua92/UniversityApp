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
        public Student SelectedStudent { get; set; }

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

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        private void LoadData()
        {
            dataGridViewStudents.DataSource = NewUniversity.Students;
            dataGridViewStudents.Columns["ID"].Visible = false;          
        }
      
        private void CloseForm()
        {
            SelectedStudent = dataGridViewStudents.SelectedRows[0].DataBoundItem as Student;
            Close();
        }
    }
}
