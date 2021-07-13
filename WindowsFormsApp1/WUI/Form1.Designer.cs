
namespace WindowsFormsApp1.WUI {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ctrlAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.ctrlDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.ctrlTime = new System.Windows.Forms.DateTimePicker();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuChooseAStudent = new System.Windows.Forms.Button();
            this.menubtnChooseAProfessor = new System.Windows.Forms.Button();
            this.menuExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChooseStudent = new System.Windows.Forms.Button();
            this.btnChooseProfessor = new System.Windows.Forms.Button();
            this.ctrlSelectedStudent = new System.Windows.Forms.TextBox();
            this.ctrlSelectedProfessor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlAdd
            // 
            this.ctrlAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlAdd.Location = new System.Drawing.Point(745, 376);
            this.ctrlAdd.Name = "ctrlAdd";
            this.ctrlAdd.Size = new System.Drawing.Size(140, 35);
            this.ctrlAdd.TabIndex = 8;
            this.ctrlAdd.Text = "Add  Schedule";
            this.ctrlAdd.UseVisualStyleBackColor = true;
            this.ctrlAdd.Click += new System.EventHandler(this.ctrlAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(932, 376);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(152, 35);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove Schedule";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ctrlDate
            // 
            this.ctrlDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDate.Location = new System.Drawing.Point(238, 382);
            this.ctrlDate.Name = "ctrlDate";
            this.ctrlDate.Size = new System.Drawing.Size(300, 29);
            this.ctrlDate.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(271, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(324, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "University Courses Scheduler";
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(238, 179);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCourses.Size = new System.Drawing.Size(861, 160);
            this.dataGridViewCourses.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Courses";
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(238, 465);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(861, 160);
            this.dataGridViewSchedule.TabIndex = 22;
            // 
            // ctrlTime
            // 
            this.ctrlTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ctrlTime.Location = new System.Drawing.Point(578, 382);
            this.ctrlTime.Name = "ctrlTime";
            this.ctrlTime.ShowUpDown = true;
            this.ctrlTime.Size = new System.Drawing.Size(115, 29);
            this.ctrlTime.TabIndex = 23;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.menuChooseAStudent);
            this.panelMenu.Controls.Add(this.menubtnChooseAProfessor);
            this.panelMenu.Controls.Add(this.menuExit);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.menuSave);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 651);
            this.panelMenu.TabIndex = 24;
            // 
            // menuChooseAStudent
            // 
            this.menuChooseAStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuChooseAStudent.Location = new System.Drawing.Point(0, 81);
            this.menuChooseAStudent.Name = "menuChooseAStudent";
            this.menuChooseAStudent.Size = new System.Drawing.Size(220, 60);
            this.menuChooseAStudent.TabIndex = 4;
            this.menuChooseAStudent.Text = "Choose A Student";
            this.menuChooseAStudent.UseVisualStyleBackColor = true;
            this.menuChooseAStudent.Click += new System.EventHandler(this.menuChooseAStudent_Click);
            // 
            // menubtnChooseAProfessor
            // 
            this.menubtnChooseAProfessor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menubtnChooseAProfessor.Location = new System.Drawing.Point(0, 147);
            this.menubtnChooseAProfessor.Name = "menubtnChooseAProfessor";
            this.menubtnChooseAProfessor.Size = new System.Drawing.Size(220, 60);
            this.menubtnChooseAProfessor.TabIndex = 3;
            this.menubtnChooseAProfessor.Text = "Choose A Professor";
            this.menubtnChooseAProfessor.UseVisualStyleBackColor = true;
            this.menubtnChooseAProfessor.Click += new System.EventHandler(this.menubtnChooseAProfessor_Click);
            // 
            // menuExit
            // 
            this.menuExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuExit.Location = new System.Drawing.Point(0, 279);
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(220, 60);
            this.menuExit.TabIndex = 2;
            this.menuExit.Text = "Exit";
            this.menuExit.UseVisualStyleBackColor = true;
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 80);
            this.panel2.TabIndex = 1;
            // 
            // menuSave
            // 
            this.menuSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSave.Location = new System.Drawing.Point(0, 213);
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(220, 60);
            this.menuSave.TabIndex = 0;
            this.menuSave.Text = "Save";
            this.menuSave.UseVisualStyleBackColor = true;
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 80);
            this.panel1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Select Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(574, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Select Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(241, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Schedules";
            // 
            // btnChooseStudent
            // 
            this.btnChooseStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseStudent.Location = new System.Drawing.Point(238, 94);
            this.btnChooseStudent.Name = "btnChooseStudent";
            this.btnChooseStudent.Size = new System.Drawing.Size(170, 35);
            this.btnChooseStudent.TabIndex = 29;
            this.btnChooseStudent.Text = "Choose a Student";
            this.btnChooseStudent.UseVisualStyleBackColor = true;
            this.btnChooseStudent.Click += new System.EventHandler(this.btnChooseStudent_Click);
            // 
            // btnChooseProfessor
            // 
            this.btnChooseProfessor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseProfessor.Location = new System.Drawing.Point(699, 92);
            this.btnChooseProfessor.Name = "btnChooseProfessor";
            this.btnChooseProfessor.Size = new System.Drawing.Size(170, 35);
            this.btnChooseProfessor.TabIndex = 30;
            this.btnChooseProfessor.Text = "Choose a Professor";
            this.btnChooseProfessor.UseVisualStyleBackColor = true;
            this.btnChooseProfessor.Click += new System.EventHandler(this.btnChooseProfessor_Click);
            // 
            // ctrlSelectedStudent
            // 
            this.ctrlSelectedStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSelectedStudent.Location = new System.Drawing.Point(414, 98);
            this.ctrlSelectedStudent.Name = "ctrlSelectedStudent";
            this.ctrlSelectedStudent.Size = new System.Drawing.Size(209, 29);
            this.ctrlSelectedStudent.TabIndex = 31;
            this.ctrlSelectedStudent.TextChanged += new System.EventHandler(this.ctrlSelectedStudent_TextChanged);
            // 
            // ctrlSelectedProfessor
            // 
            this.ctrlSelectedProfessor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSelectedProfessor.Location = new System.Drawing.Point(875, 98);
            this.ctrlSelectedProfessor.Name = "ctrlSelectedProfessor";
            this.ctrlSelectedProfessor.Size = new System.Drawing.Size(209, 29);
            this.ctrlSelectedProfessor.TabIndex = 33;
            this.ctrlSelectedProfessor.TextChanged += new System.EventHandler(this.ctrlSelectedProfessor_TextChanged);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1115, 651);
            this.Controls.Add(this.ctrlSelectedProfessor);
            this.Controls.Add(this.ctrlSelectedStudent);
            this.Controls.Add(this.btnChooseProfessor);
            this.Controls.Add(this.btnChooseStudent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.ctrlTime);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.ctrlDate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.ctrlAdd);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "University App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ctrlAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DateTimePicker ctrlDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.DateTimePicker ctrlTime;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button menuSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menubtnChooseAProfessor;
        private System.Windows.Forms.Button menuExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChooseStudent;
        private System.Windows.Forms.Button btnChooseProfessor;
        private System.Windows.Forms.TextBox ctrlSelectedStudent;
        private System.Windows.Forms.TextBox ctrlSelectedProfessor;
        private System.Windows.Forms.Button menuChooseAStudent;
    }
}