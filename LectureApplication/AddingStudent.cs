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
    public partial class AddingStudent : Form
    {
        public AddingStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            int age = 0;
            int id = 0;
            int grade = 0;

            try
            {
                age = int.Parse(textBoxAge.Text);
                id = int.Parse(textBoxGrade.Text);
                grade = int.Parse(textBoxID.Text);
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так. Попробуйте снова!", "Ошибка!");
            }

            string country = textBoxCountry.Text;
            string region = textBoxRegion.Text;
            string city = textBoxCity.Text;
            string street = textBoxStreet.Text;

            Address address = new Address(country, region, city, street);
            Student std = new Student(name, surname, age, id, grade, address);

            for (int i = 0; i < TeacherList.teachers.Count; i++)
            {
                if (comboBoxTeacher.SelectedItem.ToString() == TeacherList.teachers[i].Name + " " + TeacherList.teachers[i].Surname)
                {
                    TeacherList.teachers[i].Add(std);
                }
            }

            MessageBox.Show("OK", "Результат");
            this.Close();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTeacher_Click(object sender, EventArgs e)
        {
            (sender as ComboBox).Items.Clear();

            for (int i = 0; i < TeacherList.teachers.Count; i++)
            {
                (sender as ComboBox).Items.Add(TeacherList.teachers[i].Name + " " + TeacherList.teachers[i].Surname);
            }
        }

        private void AddressGB_Enter(object sender, EventArgs e)
        {

        }
    }
}
