using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_Variant6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string subject = "";
            if (rbMath.Checked) subject = "Математика";
            else if (rbPhysics.Checked) subject = "Фізика";
            else if (rbProg.Checked) subject = "Програмування";
            else
            {
                MessageBox.Show("Будь ласка, оберіть предмет!");
                return;
            }

            double grade = 0;

            if (checkBoxFile.Checked)
            {
                string path = "grade.txt";
                if (!System.IO.File.Exists(path))
                {
                    MessageBox.Show("Файл grade.txt не знайдено. Покладіть його у папку bin\\Debug");
                    return;
                }
                string text = System.IO.File.ReadAllText(path).Trim();
                bool ok = double.TryParse(text, out grade);
                if (!ok)
                {
                    MessageBox.Show("У файлі некоректне число");
                    return;
                }
                textBoxGrade.Text = grade.ToString();
            }
            else
            {
                bool ok = double.TryParse(textBoxGrade.Text, out grade);
                if (!ok)
                {
                    MessageBox.Show("Введіть коректну оцінку числом");
                    return;
                }
            }

            if (grade < 0 || grade > 100)
            {
                MessageBox.Show("Оцінка має бути від 0 до 100");
                return;
            }

            string verdict = "";
            switch (true)
            {
                case true when grade >= 90:
                    verdict = "Відмінно";
                    break;
                case true when grade >= 75:
                    verdict = "Добре";
                    break;
                case true when grade >= 60:
                    verdict = "Задовільно";
                    break;
                default:
                    verdict = "Незадовільно";
                    break;
            }

            string result = $"Предмет: {subject}\nОцінка: {grade}\nВисновок: {verdict}";
            labelResult.Text = result;
            System.IO.File.WriteAllText("result.txt", result);
        }

        private void checkBoxFile_CheckedChanged(object sender, EventArgs e)
        {
            textBoxGrade.Visible = !checkBoxFile.Checked;
            labelInput.Visible = !checkBoxFile.Checked;
        }
    }
}
