using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Random random;

        public Form()
        {
            InitializeComponent();
            random = new Random();
        }


        private void button_Click(object sender, EventArgs e)
        {
            //if (btnCatchMe.Location.X < ClientSize.Width && btnCatchMe.Location.Y < ClientSize.Height)
            //{
            //    btnCatchMe.Location = new Point(random.Next(this.Width), random.Next(this.Height));
            //}

            //var result = MessageBox.Show("Test", "Message", MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            //if (result == DialogResult.Yes)
            //{
            //    MessageBox.Show("Да");
            //}
            //else if (result == DialogResult.No)
            //{
            //    MessageBox.Show("Нет");
            //}
            //else
            //{
            //    MessageBox.Show("Закрыл");
            //}

            





        }

        private void Form_Load(object sender, EventArgs e)
        {

            //string str1 = "Hello";
            //string str2 = "My name Aliaksandr";
            //string str3 = "I from Minsk";
            //int lenght = str1.Length + str2.Length + str3.Length;

            //MessageBox.Show(str1);
            //MessageBox.Show(str2);
            //MessageBox.Show(str3);
            //MessageBox.Show("Количество символов: " + lenght);

            int minNumber = 0;
            int maxNumber = 10;
            int searchNumber;

            while (true)
            {
                var result = MessageBox.Show("Search number ", "Число меньше " + maxNumber / 2, MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    maxNumber = maxNumber / 2;
                }
                else if (result == DialogResult.No)
                {
                    minNumber = maxNumber / 2;
                }
                else
                {
                    MessageBox.Show("Загаданное число: " + minNumber);
                    break;
                }
            }
        }
    }
}
