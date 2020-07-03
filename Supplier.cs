using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinoRemont
{
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }
        
        Int32 ID_Record;
        //Запрос на получение данных из базы данных
        String Query = DBConnection.qrSupplier;


        /// <summary>
        /// Переход по страницам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox_Employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.WindowX = Left;
            Program.WindowY = Top;
            switch (ListBox_Employee.SelectedItem.ToString())
            {

                case ("Таблица сотрудников"):
                    Employee employee = new Employee();
                    employee.Show(this);
                    Hide();
                    employee.Left = Program.WindowX;
                    employee.Top = Program.WindowY;
                    break;
                case ("Таблица должностей"):
                    Position a = new Position();
                    a.Show(this);
                    Hide();
                    a.Left = Program.WindowX;
                    a.Top = Program.WindowY;
                    break;
                case ("Таблица заказов"):
                    Order b = new Order();
                    b.Show(this);
                    Hide();
                    b.Left = Program.WindowX;
                    b.Top = Program.WindowY;
                    break;
                case ("Таблица банков"):
                    Bank c = new Bank();
                    c.Show(this);
                    Hide();
                    c.Left = Program.WindowX;
                    c.Top = Program.WindowY;
                    break;
                case ("Таблица поставщиков"):
                    Supplier d = new Supplier();
                    d.Show(this);
                    Hide();
                    d.Left = Program.WindowX;
                    d.Top = Program.WindowY;
                    break;
                case ("Таблица аккаунтов"):
                    Account f = new Account();
                    f.Show(this);
                    Hide();
                    f.Left = Program.WindowX;
                    f.Top = Program.WindowY;
                    break;
            }

        }

        /// <summary>
        /// При загрузке окна происходит заполнение DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Employee_Load(object sender, EventArgs e)
        {
            //Положение формы
            if (Program.WindowX == 0 & Program.WindowY == 0)
            {
                Program.WindowX = Left;
                Program.WindowY = Top;
            }

            RegistryKey registry = Registry.CurrentUser;
            //Создаёт папку в выбраном коревом каталоге рееста ОС
            RegistryKey key = registry.CreateSubKey("DinoRemont");
            try
            {
                //Пытаюсь получить значения из переменных в реестре
                Program.RedColor = Convert.ToInt32(key.GetValue("RedColor"));
                Program.GreenColor = Convert.ToInt32(key.GetValue("GreenColor"));
                Program.BlueColor = Convert.ToInt32(key.GetValue("BlueColor"));
            }
            catch
            {
                Program.RedColor = 255;
                Program.GreenColor = 255;
                Program.BlueColor = 128;
            }
            BackColor = Color.FromArgb(Program.RedColor, Program.GreenColor, Program.BlueColor);

            dgvFill(Query, DataGridView_Employee);
            //Прячем ID в таблице
            DataGridView_Employee.Columns[0].Visible = false;
            DataGridView_Employee.Columns[6].Visible = false;

            dgvConfiguration(DataGridView_Employee);
            cbFill();
        }

        /// <summary>
        /// Заполнение ComboBox названиями должностей по их ID в таблице
        /// </summary>
        private void cbFill()
        {
            Table_Class table = new Table_Class(DBConnection.qrBank);
            cbBank.DataSource = table.table;
            cbBank.DisplayMember = "Название";
            cbBank.ValueMember = "ID_Bank";
        }

        /// <summary>
        /// Конфигурирование объект класса DataGridView
        /// </summary>
        /// <param name="dgw"></param>
        private void dgvConfiguration(DataGridView dgv)
        {
            //Запрет на редактирование
            dgv.ReadOnly = true;
            //Запрет на добавление новых строк
            dgv.AllowUserToAddRows = false;
            //Запрет на изменение ширины и длины
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            //Отключение заголовка строк
            dgv.RowHeadersVisible = false;
            //Отключение выбора нескольких строк
            dgv.MultiSelect = false;
        }

        /// <summary>
        /// Заполнение DataGridView данными по запросу
        /// </summary>
        /// <param name="qr">Запрос</param>
        /// <param name="dgw">Объект класса DataGridView</param>
        private void dgvFill(string qr, DataGridView dgv)
        {
            
                Table_Class table = new Table_Class(qr);
                dgv.DataSource = table.table;
            
        }

        

        

        // Добавление информации в таблицу
        private void Button_Add_Click(object sender, EventArgs e)
        {
            Procedure_Class procedure = new Procedure_Class();
            ArrayList array = new ArrayList();
            array.Add(tbLast_Name.Text);
            array.Add(tbName.Text);
            array.Add(tbMiddle_Name.Text);
            array.Add(cbBank.SelectedValue);
            procedure.procedure_Execution("Supplier_insert", array);
            Employee_Load(sender, e);
        }


        private void DataGridView_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Чтобы программа не крашилась при сортировке в таблице используется try-catch
            try
            {
                //Получение ID записи
                ID_Record = Convert.ToInt32(DataGridView_Employee.Rows[e.RowIndex].Cells[0].Value);
                //Запись  в тексбоксы
                tbLast_Name.Text = DataGridView_Employee.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbName.Text = DataGridView_Employee.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbMiddle_Name.Text = DataGridView_Employee.Rows[e.RowIndex].Cells[3].Value.ToString();


            }
            catch { };
        }

        private void Button_Correct_Click(object sender, EventArgs e)
        {
            Procedure_Class procedure = new Procedure_Class();
            //ArrayList, который надо заполнять строго в порядке,
            //указанном в процедуре, так как если поменять местами,
            //то данные могут не туда добавиться
            ArrayList array = new ArrayList();
            array.Add(ID_Record);
            array.Add(tbLast_Name.Text);
            array.Add(tbName.Text);
            array.Add(tbMiddle_Name.Text);
            array.Add(cbBank.SelectedValue);
            procedure.procedure_Execution("Supplier_update", array);
            Employee_Load(sender, e);
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "DinoRemont", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Procedure_Class procedure = new Procedure_Class();
                ArrayList array = new ArrayList();
                array.Add(ID_Record);
                procedure.procedure_Execution("Supplier_delete", array);
                //Проверка на существование записи после "удаления"
                Function_Class function = new Function_Class();
                function.Record_Checking(ID_Record, "Supplier");
                Employee_Load(sender, e);
            }
            
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            //Поиск по всем ячейчам таблицы, подойдёт для каждой
                for (Int32 Column = 0; Column < DataGridView_Employee.ColumnCount; Column++)
                {
                    for (Int32 Row = 0; Row < DataGridView_Employee.RowCount; Row++)
                    {
                        if (DataGridView_Employee.Rows[Row].Cells[Column].Value.ToString().IndexOf(TextBox_Search.Text) > -1)
                        {
                            DataGridView_Employee.Rows[Row].Cells[Column].Selected = true;
                            return;
                        }
                            
                    }
                }
            
            
        }

        private void CheckBox_Filter_CheckedChanged(object sender, EventArgs e)
        {
            //Фильтрация, суть которой в поиске совпадений в таблице в бд
            switch(CheckBox_Filter.Checked)
            {
                case (true):
                    dgvFill(Query + string.Format("where [Name_Supplier] like '%{0}%' " +
                                "or" + "[INN_Supplier] like '%{0}%' " +
                                "or" + "[KPP_Supplier] like '%{0}%'", TextBox_Search.Text), DataGridView_Employee);
                    break;
                case (false):
                    dgvFill(Query, DataGridView_Employee);
                    break;
            }
        }

        private void TextBox_Search_TextChanged(object sender, EventArgs e)
        {
            if (CheckBox_Filter.Checked)
                CheckBox_Filter_CheckedChanged(sender, e);
        }

        private void DataGridView_Employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "DinoRemont", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Button_Exit_Click(sender, e);
        }

        private void Button_Print_Click(object sender, EventArgs e)
        {
            Document_Class document = new Document_Class();
            //SQL запрос
            string qr = Query;
            //убираю ключи из запроса
            qr = qr.Replace("[ID_Employee],", "");
            qr = qr.Replace("[ID_Post],", "");
            //Произвожу запрос
            Table_Class table = new Table_Class(qr);
            document.Document_Create(Document_Class.Document_Type.List, Document_Class.Document_Format.Word, "", table.table);
        }

        

    }
}
