using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectureApplication
{
    public partial class Form1 : Form
    {
        DataTable dt_Students;
        DataTable dt_Teachers;
        DataTable dt_Stat;

        List<Student> studentsList = new List<Student>();
        List<Teacher> teachersList = new List<Teacher>();

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < TeacherList.teachers.Count; i++)
            {

                if (comboBox.SelectedItem.ToString() == TeacherList.teachers[i].Name + " " + TeacherList.teachers[i].Surname)
                {
                    List<Student> std = GetStudentsList();
                    dt_Stat = new DataTable();

                    dt_Stat.Columns.Add("Имя");
                    dt_Stat.Columns.Add("Фамилия");
                    dt_Stat.Columns.Add("Возраст");
                    dt_Stat.Columns.Add("ID");
                    dt_Stat.Columns.Add("Оценка");

                    dt_Stat.Columns.Add("Страна");
                    dt_Stat.Columns.Add("Регион");
                    dt_Stat.Columns.Add("Город");
                    dt_Stat.Columns.Add("Улица");


                    foreach (Student var in std)
                    {
                        dt_Stat.Rows.Add(var.Name, var.Surname, var.Age, var.ID, var.Grade, var.Adress.Country, var.Adress.Region, var.Adress.City, var.Adress.Street);
                    }

                    dataGridView3.DataSource = dt_Stat;
                }

            }
        }

        private void CreateTable()
        {
            if (dt_Students == null)
            {
                dt_Students = new DataTable();

                dt_Students.Columns.Add("Имя");
                dt_Students.Columns.Add("Фамилия");
                dt_Students.Columns.Add("Возраст");
                dt_Students.Columns.Add("ID");
                dt_Students.Columns.Add("Оценка");
                dt_Students.Columns.Add("Страна");
                dt_Students.Columns.Add("Регион");
                dt_Students.Columns.Add("Город");
                dt_Students.Columns.Add("Улица");
            }
            else
            {
                dt_Students.Clear();
            }

            foreach (Student i in studentsList)
            {
                dt_Students.Rows.Add(i.Name, i.Surname, i.Age, i.ID, i.Grade, i.Adress.Country, i.Adress.Region, i.Adress.City, i.Adress.Street);
            }

            dataGridView2.DataSource = dt_Students;
        }

        private void CreateTable(List<Teacher> teachers)
        {
            if (dt_Teachers == null)
            {
                dt_Teachers = new DataTable();

                dt_Teachers.Columns.Add("Имя");
                dt_Teachers.Columns.Add("Фамилия");
                dt_Teachers.Columns.Add("Возраст");
                dt_Teachers.Columns.Add("ID");

                dt_Teachers.Columns.Add("Страна");
                dt_Teachers.Columns.Add("Регион");
                dt_Teachers.Columns.Add("Город");
                dt_Teachers.Columns.Add("Улица");
            }
            else
            {
                dt_Teachers.Clear();
            }


            foreach (Teacher i in teachers)
            {
                dt_Teachers.Rows.Add(i.Name, i.Surname, i.Age, i.ID, i.Adress.Country, i.Adress.Region, i.Adress.City, i.Adress.Street);
            }

            dataGridView1.DataSource = dt_Teachers;
        }

        private List<Student> GetStudentsList()
        {
            List<Student> var = new List<Student>();

            for (int i = 0; i < TeacherList.teachers.Count; i++)
            {
                List<Student> list = TeacherList.teachers[i].getList();

                for (int j = 0; j < list.Count; j++)
                {
                    var.Add(list[j]);
                }
            }

            return var;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTable(TeacherList.teachers);
            studentsList = GetStudentsList();
            CreateTable();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch ((sender as ToolStripMenuItem).Tag)
            {
                case "refresh":
                    CreateTable(TeacherList.teachers);
                    studentsList = GetStudentsList();
                    CreateTable();
                    break;
                case "student":
                    AddingStudent addStudent = new AddingStudent();
                    addStudent.ShowDialog();
                    break;
                case "teacher":
                    AddingTeacher addTeacher = new AddingTeacher();
                    addTeacher.ShowDialog();
                    break;
            }
        }

        private void comboBox_Click(object sender, EventArgs e)
        {
            (sender as ComboBox).Items.Clear();

            for (int i = 0; i < TeacherList.teachers.Count; i++)
            {
                (sender as ComboBox).Items.Add(TeacherList.teachers[i].Name + " " + TeacherList.teachers[i].Surname);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
