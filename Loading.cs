using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinoRemont
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        

        /// <summary>
        /// Метод добавления в скрол бар какого-то значения
        /// </summary>
        /// <param name="Percent"></param>
        private void plus(Int32 Percent)
        {
            progressBar1.Value = Percent;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            plus(30);
            //Проверка версии системы
            int Major = Environment.OSVersion.Version.Major;
            int Minor = Environment.OSVersion.Version.Minor;
            if ((!(Major >= 6)) && !((Minor >= 0)))
            {
                MessageBox.Show("Ваша система не подходит для работы с этим ПО");
                Application.Exit();
            }
            else plus(45);

            string path = Application.StartupPath;
            //Проверка наличия dll
            if (System.IO.File.Exists(path +"\\" +"Microsoft.Office.Interop.Excel.dll") == false)
            {
                MessageBox.Show("Отсутсвует Microsoft.Office.Interop.Excel.dll");
                Application.Exit();
            }
            plus(60);
            if (System.IO.File.Exists(path + "\\" + "Microsoft.Office.Interop.Word.dll") == false)
            {
                MessageBox.Show("Отсутсвует Microsoft.Office.Interop.Word.dll");
                Application.Exit();
            }
            plus(70);
            if (System.IO.File.Exists(path + "\\" + "itextsharp.dll") == false)
            {
                MessageBox.Show("Отсутсвует itextsharp.dll");
                Application.Exit();
            }
            plus(80);

            timer1.Enabled = true;
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 2;
            if (progressBar1.Value >= 99)
            {
                this.Visible = false;
                timer1.Enabled = false;
            }
                
        }
    }
}
