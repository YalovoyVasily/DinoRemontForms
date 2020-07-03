using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DinoRemont
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        //Выход из окна
        private void BtLeave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "DinoRemont", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //Глобальное событие на любую кнопку
        private void back_Color(object sender, EventArgs e)
        {
            if (sender is TextBox)
                (sender as TextBox).BackColor = Color.White;
        }
        bool hide = false;
        private void BtEnter_Click(object sender, EventArgs e)
        {
            //Проверка на заполнение полей ввода
            switch (TextBox_Login.Text == "")
            {
                case true:
                    TextBox_Login.BackColor = Color.Red;
                    break;
                case false:
                    switch (TextBox_Password.Text == "")
                    {
                        case true:
                            TextBox_Password.BackColor = Color.Red;
                            break;
                        case false:
                            Function_Class function = new Function_Class();
                            //Прохождение авторизации
                            function.Authorization(TextBox_Login.Text,
                                TextBox_Password.Text);
                            switch (Program.intID == "")
                            {
                                //Не верно введёные данные
                                case true:
                                    MessageBox.Show("Введённые данные не верны! " +
                                        "Повторите ввод!",
                                               "DinoRemont", MessageBoxButtons.OK,
                                               MessageBoxIcon.Error);
                                    TextBox_Login.Clear();
                                    TextBox_Password.Clear();
                                    TextBox_Login.Focus();
                                    break;
                                case false:
                                    if (checkBox_KnowMe.Checked)
                                    {
                                        RegistryKey registry = Registry.CurrentUser;
                                        //Создаёт папку в выбраном коревом каталоге рееста ОС
                                        RegistryKey key = registry.CreateSubKey("DinoRemont");
                                        //Запись в реестр зашифрованных данных
                                        key.SetValue("Login", Cipher(TextBox_Login.Text, "Гамбургёр").ToString());
                                        key.SetValue("Password", Cipher(TextBox_Password.Text, "Гамбургёр").ToString());

                                    }
                                    Employee employee = new Employee();
                                    employee.Show(this);
                                    this.Visible = false;
                                    Hide();
                                    hide = true;
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {

            Program.GoodBye = true;
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "DinoRemont", MessageBoxButtons.YesNo);
                if ((result == DialogResult.Yes) & (Program.GoodBye == false))
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            Program.GoodBye = false;
        }
        Boolean load = true;
        Loading loading = new Loading();
        private void Authorization_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
            loading.Show(this);
            
            RegistryKey registry = Registry.CurrentUser;
            //Создаёт папку в выбраном коревом каталоге рееста ОС
            RegistryKey key = registry.CreateSubKey("DinoRemont");
            try
            {
                //Пытаюсь получить значения из переменных в реестре
                Program.RedColor = Convert.ToInt32(key.GetValue("RedColor"));
                Program.GreenColor = Convert.ToInt32(key.GetValue("GreenColor"));
                Program.BlueColor = Convert.ToInt32(key.GetValue("BlueColor"));
                checkBox_KnowMe.Checked = Convert.ToBoolean(key.GetValue("KnowMe").ToString());
                Program.Welcome = Convert.ToBoolean(key.GetValue("Welcome").ToString());
            }
            catch
            {
                Program.RedColor = 255;
                Program.GreenColor = 255;
                Program.BlueColor = 128;
                key.SetValue("RedColor", Program.RedColor);
                key.SetValue("GreenColor", Program.GreenColor);
                key.SetValue("BlueColor", Program.BlueColor);
            }
            if (Program.RedColor == 0 & Program.GreenColor == 0 & Program.BlueColor == 0)
            {
                Program.RedColor = 255;
                Program.GreenColor = 255;
                Program.BlueColor = 128;
            }
            
            BackColor = Color.FromArgb(Program.RedColor, Program.GreenColor, Program.BlueColor);
            if (checkBox_KnowMe.Checked)
            {
                try
                {
                    TextBox_Login.Text = Cipher(key.GetValue("Login").ToString(), "Гамбургёр");
                    TextBox_Password.Text = Cipher(key.GetValue("Password").ToString(), "Гамбургёр");
                }
                catch
                { }
                 
            }
            load = false;
        }

        /// <summary>
        ///Генератор повторения секретного ключа
        /// </summary>
        /// <param name="s">Секретный ключ</param>
        /// <param name="n">Длина текста</param>
        /// <returns></returns>
        private string GetRepeatKey(string s, int n)
        {
            var r = s;
            while (r.Length < n)
            {
                r += r;
            }

            return r.Substring(0, n);
        }

        /// <summary>
        /// Метод шифрования/дешифрования
        /// </summary>
        /// <param name="text">Текст, над которым надо произвести операцию</param>
        /// <param name="secretKey">Секретный ключ</param>
        /// <returns></returns>
        private string Cipher(string text, string secretKey)
        {
            var currentKey = GetRepeatKey(secretKey, text.Length);
            var res = string.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                res += ((char)(text[i] ^ currentKey[i])).ToString();
            }

            return res;
        }
        
        private void checkBox_KnowMe_CheckedChanged(object sender, EventArgs e)
        {
            if (load == true) return;
            RegistryKey registry = Registry.CurrentUser;
            //Создаёт папку в выбраном коревом каталоге рееста ОС
            RegistryKey key = registry.CreateSubKey("DinoRemont");
            //Запись в реестр зашифрованных данных
            key.SetValue("KnowMe", checkBox_KnowMe.Checked.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (loading.Visible == true) this.Visible = false;
            else this.Visible = true;


            if (this.Visible == false) timer1.Enabled = true;
            if (hide == true)
            {
                this.Visible = false;
                timer1.Enabled = false;
            }
        }
    }
}