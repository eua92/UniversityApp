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
    public partial class ProfessorForm : Form
    {
        public University NewUniversity = new University();
        public Professor SelectedProfessor { 
            get => dataGridViewProfessors.SelectedRows[0].DataBoundItem as Professor;  
            set => SelectedProfessor = value; }

        public ProfessorForm()
        {
            InitializeComponent();
        }

        private void ProfessorForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void dataGridViewProfessors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FindCourses();
        }

        private void ProfessorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        private void LoadData()
        {         
            dataGridViewProfessors.DataSource = NewUniversity.Professors;
            dataGridViewProfessors.Columns["ID"].Visible = false;
            dataGridViewProfessors.Columns["BirthDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            FindCourses();
        }   

        private void CloseForm()
        {          
            Close();
        }

        private void FindCourses()
        {
            string courses = "";
            foreach (var item in SelectedProfessor.Courses)
            {
                courses += String.Format("{0}", item);
            }

            ctrlCourses.Text = courses;
        }      
    }
}
