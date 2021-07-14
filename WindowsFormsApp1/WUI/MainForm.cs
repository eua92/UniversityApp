using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1.WUI {

    public partial class MainForm : Form {

        private const string _JsonFile = "UniversityData.json";
        private University NewUniversity = new University();
        public Initialization NewInitialization = new Initialization();

        public Student SelectedStudent { get; set; }
        public Professor SelectedProfessor { get; set; }

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NewInitialization.InitializeData();
            NewUniversity = NewInitialization.NewUniversity;
            LoadData();
        }

        private void menuChooseAStudent_Click(object sender, EventArgs e)
        {
            LoadStudentForm();
        }

        private void menubtnChooseAProfessor_Click(object sender, EventArgs e)
        {
            LoadProfessorForm();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            Storage.SerializeToJson(NewUniversity, _JsonFile);
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChooseStudent_Click(object sender, EventArgs e)
        {
            LoadStudentForm();
        }

        private void btnChooseProfessor_Click(object sender, EventArgs e)
        {
            LoadProfessorForm();
        }

        private void ctrlAdd_Click(object sender, EventArgs e)
        {
            AddToSchedule();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveSchedule();
        }


        private void ctrlSelectedStudent_TextChanged(object sender, EventArgs e)
        {
            RefreshStudents();
        }

        private void ctrlSelectedProfessor_TextChanged(object sender, EventArgs e)
        {
            RefreshProfessors();
        }

        private void RefreshStudents()
        {
            if (ctrlSelectedStudent.Text == String.Empty)
            {
                SelectedStudent = null;
                FilterCourses();
            }
        }

        private void RefreshProfessors()
        {
            if (ctrlSelectedProfessor.Text == String.Empty)
            {
                SelectedProfessor = null;
                FilterCourses();
            }
        }

        private void LoadData()
        {
            NewUniversity = (University)Storage.DeserializeFromJson(NewUniversity, _JsonFile);
            LoadCourses();
            LoadSchedules();
        }

        private void LoadCourses()
        {
            dataGridViewCourses.DataSource = NewUniversity.Courses;
            dataGridViewCourses.Columns["ID"].Visible = false;
        }

        private void LoadSchedules()
        {
            dataGridViewSchedule.DataSource = NewUniversity.Schedules;
            dataGridViewSchedule.Columns["ID"].Visible = false;
        }

        private void AddToSchedule()
        {
            // TODO: 1. CANNOT ADD SAME STUDENT + PROFESSOR IN SAME DATE & HOUR

            // TODO: 2. EACH STUDENT CANNOT HAVE MORE THAN 3 COURSES PER DAY!

            // TODO: 3. A PROFESSOR CANNOT TEACH MORE THAN 4 COURSES PER DAY AND 40 COURSES PER WEEK

            try
            {
                if (SelectedStudent != null && SelectedProfessor != null)
                {
                    string selectedCourse = Convert.ToString(dataGridViewCourses.SelectedRows[0].Cells["Subject"].Value);
                    string selectedStudent = String.Format("{0} {1}", SelectedStudent.Name, SelectedStudent.Surname);
                    string selectedProfessor = String.Format("{0} {1}", SelectedProfessor.Name, SelectedProfessor.Surname);
                    DateTime selectedDate = ctrlDate.Value.Date + ctrlTime.Value.TimeOfDay;

                    Schedule newSchedule = new Schedule(selectedStudent, selectedProfessor, selectedCourse, selectedDate);

                    ValidateSchedule(newSchedule);
                }
                else
                {
                    MessageBox.Show("Please choose student and professor");
                }
                           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidateSchedule(Schedule newSchedule)
        {
            var dayOfWeek = newSchedule.Calendar.Date.DayOfWeek;
            var scheduleByWeek = FilterScheduleByWeek(newSchedule, Convert.ToInt32(dayOfWeek));
            var scheduleByDay = NewUniversity.Schedules.ToList()
                .FindAll(item => item.Calendar.Date == newSchedule.Calendar.Date);


            if (NewUniversity.Schedules.Any(item => item.Student == newSchedule.Student 
                && item.Calendar == newSchedule.Calendar))
            {
                MessageBox.Show("You can't add the same student in the same date & hour");
            }
            else if (NewUniversity.Schedules.Any(item => item.Professor == newSchedule.Professor
                && item.Calendar == newSchedule.Calendar))
            {
                MessageBox.Show("You can't add the same professor in the same date & hour");
            }
            else if (scheduleByDay.Count(item => item.Student == newSchedule.Student) >= 3)
            {
                MessageBox.Show("A student cannot have more than 3 courses per day");
            }
            else if (scheduleByDay.Count(item => item.Professor == newSchedule.Professor) >= 4)
            {
                MessageBox.Show("A professor cannot have more than 4 courses per day");
            }
            else if (scheduleByWeek.Count(item => item.Professor == newSchedule.Professor) >= 40)
            {
                MessageBox.Show("A professor cannot teach more than 40 courses per week");
            }
            else if (dayOfWeek.ToString() == "Saturday" || dayOfWeek.ToString() == "Sunday" )
            {
                MessageBox.Show("You can't add classes on weekends!");
            }
            else
            {
                NewUniversity.Schedules.Add(newSchedule);

                MessageBox.Show("Schedule succesfully added!");
            }
        }

        private List<Schedule> FilterScheduleByWeek(Schedule newSchedule, int dayOfWeek)
        {
            DateTime dayStart = newSchedule.Calendar.Date.AddDays(0-dayOfWeek);
            DateTime dayEnd = newSchedule.Calendar.Date.AddDays(6-dayOfWeek);
            List<Schedule> schedulesByWeek = NewUniversity.Schedules.ToList()
                .FindAll(item => item.Calendar.Date >= dayStart &&
                         item.Calendar.Date <= dayEnd);
            return schedulesByWeek;
        }

        private void FilterCourses()
        {
            List<Course> filteredCoursesByStudent = new List<Course>();
            List<Course> filteredCoursesByProfessor = new List<Course>();

            List<Course> filteredCourses = new List<Course>();

            if (SelectedStudent == null && SelectedProfessor == null)
            {
                dataGridViewCourses.DataSource = NewUniversity.Courses;
            }
            else if (SelectedStudent != null && SelectedProfessor == null)
            {
                SelectedStudent.Courses.ForEach(category => filteredCoursesByStudent.AddRange(NewUniversity.Courses.FindAll(x => x.Category == category)));
                dataGridViewCourses.DataSource = filteredCoursesByStudent;
            }
            else if (SelectedStudent == null && SelectedProfessor != null)
            {
                SelectedProfessor.Courses.ForEach(category => filteredCoursesByProfessor.AddRange(NewUniversity.Courses.FindAll(x => x.Category == category)));
                dataGridViewCourses.DataSource = filteredCoursesByProfessor;
            }
            else
            {
                SelectedStudent.Courses.ForEach(category => filteredCoursesByStudent.AddRange(NewUniversity.Courses.FindAll(x => x.Category == category)));
                SelectedProfessor.Courses.ForEach(category => filteredCoursesByProfessor.AddRange(NewUniversity.Courses.FindAll(x => x.Category == category)));
                filteredCourses = filteredCoursesByStudent.FindAll(x => x.Category == filteredCoursesByProfessor[0].Category);
                dataGridViewCourses.DataSource = filteredCourses;
            }
        }


        private void RemoveSchedule()
        {
            if (dataGridViewSchedule.Rows.Count == 1)
            {
                MessageBox.Show("Please add a schedule");
            } else
            {
                var selectedSchedule = dataGridViewSchedule.SelectedRows[0].DataBoundItem as Schedule;
                NewUniversity.Schedules.Remove(NewUniversity.Schedules.First(x => x.ID == selectedSchedule.ID));
            }
           
        }
    

        private void LoadStudentForm()
        {
            StudentForm studentForm = new StudentForm();
            studentForm.NewUniversity = NewUniversity;
            DialogResult result = studentForm.ShowDialog();
            switch (result)
            {
                case DialogResult.Cancel:
                    SelectedStudent = studentForm.SelectedStudent;
                    ctrlSelectedStudent.Text = String.Format("{0} {1}", SelectedStudent.Name, SelectedStudent.Surname);
                    FilterCourses();
                    break;
                default:
                    break;
            }
        }

        private void LoadProfessorForm()
        {
            ProfessorForm professorForm = new ProfessorForm();
            professorForm.NewUniversity = NewUniversity;
            DialogResult result = professorForm.ShowDialog();
            switch (result)
            {
                case DialogResult.Cancel:
                    SelectedProfessor = professorForm.SelectedProfessor;
                    ctrlSelectedProfessor.Text = String.Format("{0} {1}", SelectedProfessor.Name, SelectedProfessor.Surname);
                    FilterCourses();
                    break;
                default:
                    break;
            }
        }
    }
}

