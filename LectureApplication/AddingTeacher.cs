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
    public partial class AddingTeacher : Form
    {
        public AddingTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            int age = 0;
            int id = 0;

            try
            {
                age = int.Parse(textBoxAge.Text);
                id = int.Parse(textBoxID.Text);
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
            Teacher tcher = new Teacher(name, surname, age, id, address);
            TeacherList.teachers.Add(tcher);

            MessageBox.Show("OK", "Результат");
            this.Close();
        }

        private void AddingTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}
