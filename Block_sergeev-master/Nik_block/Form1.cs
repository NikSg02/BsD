using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tinker_quest; // связывание формы 1 и 2

namespace Nik_block
{
    public partial class Form1 : Form
    {
        int time = 0;
        int counter = 0;
        int lim = 3;
        int timeleft = 60;
        string tb;
        public Form1()
        {

            InitializeComponent();
            TimeS.Text = "Авторизация";

        }


        private void button1_Click(object sender, EventArgs e)
        {

            

            if (counter == lim)
            {

                LoginB.Enabled = false; //блокируем текстбокс
                PasswordB.Enabled = false; //блокируем текстбокс
                button1.Enabled = false; //блокируем кнопку
                timer1.Start();
                counter = 0;

            }
            if (LoginB.Text == "1111" && PasswordB.Text == "1111") // проверяем логин и пароль
            {
                tb = "Вы вошли ";
                MessageBox.Show(tb);

                Form2 newForm = new Form2();     // вызов второго окна приложения
                newForm.Show();
                this.Hide();

            }
            else if (counter < lim)
            {
                counter++;
                tb = "Неверный логин или пароль. у вас осталось " + (3 - counter).ToString() + " попыток входа";
                MessageBox.Show(tb);
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            timeleft = timeleft -1;
            TimeS.Text = "Время до разблокировки:" + timeleft.ToString() + "секунд";
            time++;

            if (timeleft <= 0)
            {
                LoginB.Enabled = Enabled; //разблокируем текстбокс
                PasswordB.Enabled = Enabled; //разблокируем текстбокс
                button1.Enabled = Enabled; //разблокируем кнопку
                timer1.Stop();
                timeleft = 60;
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
