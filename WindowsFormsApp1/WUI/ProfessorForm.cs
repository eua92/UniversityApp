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
        public Professor SelectedProfessor { get; set; }

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

        private void ProfessorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        private void LoadData()
        {         
            dataGridViewProfessors.DataSource = NewUniversity.Professors;
            dataGridViewProfessors.Columns["ID"].Visible = false;
        }   

        private void CloseForm()
        {
            SelectedProfessor = dataGridViewProfessors.SelectedRows[0].DataBoundItem as Professor;
            Close();
        }     
    }
}
