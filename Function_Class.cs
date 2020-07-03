using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DinoRemont
{
    public class Function_Class
    {
        public DataTable Restable = new DataTable();
        /// <summary>
        /// Вызов функции авторизации пользователя в системе для открытия сессии 
        /// работы в программе
        /// </summary>
        /// <param name="Login">Значение логина пользователя</param>
        /// <param name="Password">Значение пароля пользователя</param>
        public void Authorization(string Login, string Password)
        {
            //Обращение к табличной функции
            Table_Class table = new Table_Class(
                string.Format(" select COUNT(*) from [dbo].[Account] where [Login_Account] = '{0}' and [Password_Account] = '{1}'", Login,Password));
            try
            {
                //Присвоение в статическую строковую переменную значения первичного ключа
                Program.intID = table.table.Rows[0][0].ToString();
                //Проверка на пустоту первичного ключ
                
                
            }
            catch
            {

            }
        }

        /// <summary>
        /// Проверка на существование записи в таблице
        /// </summary>
        /// <param name="ID"> ID записи</param>
        /// <param name="TableName">Название таблицы</param>
        public void Record_Checking(Int32 ID, string TableName)
        {
            Table_Class table = new Table_Class(
                string.Format("select COUNT(*) from [dbo].[{1}] where [ID_{1}] = {0}", ID, TableName));
            if (Convert.ToInt32(table.table.Rows[0][0].ToString()) > 0)
                System.Windows.Forms.MessageBox.Show("Невозможно произвести удаление записи, так как она связана с другими!", "DinoRemont");
        }

         /// <summary>
         /// Класс работы с функциями базы данных
         /// </summary>
        public Function_Class()
        {

        }
        /// <summary>
        /// Вызов перегрузки метода собращения к функциям Microsoft SQQL
        /// без формальных параметров
        /// </summary>
        /// <param name="Function_name">Название функции</param>
        /// <param name="type_function">Возвращаемый тип: 
        /// table или scalar</param>
        public Function_Class(string Function_name, string type_function)
        {
            //Переменная нового завпроса
            string query = "";
            //Сценарий заполнения query
            switch (type_function)
            {
                case "scalar":
                    //Формирование запроса на вывод данных из скалярной.агрегатной
                    //функции
                    query = string.Format(@"select [dbo].[{0}]()",
                        Function_name);
                    break;
                case "table":
                    //Формирование запроса на вывод всех столбцов 
                    //из табличной функции
                    query = string.Format(@"select * from [dbo].[{0}]()",
                        Function_name);
                    break;
            }
            try
            {
                //Вызов класса Table_Data со сформированным запросом
                Table_Class table = new Table_Class(query);
                //Присвоение результата в табличную переменную
                Restable = table.table;
            }
            catch
            {

            }
        }
        /// <summary>
        /// Вызов перегрузки класса с функциями Microsoft SQL Server
        /// для функций которые имеют в себе формальные параметры
        /// </summary>
        /// <param name="Function_name">Название функции</param>
        /// <param name="type_function">Тип функции:
        /// table или scalar</param>
        /// <param name="parametrs">Не типизированный список 
        /// передаваемых параметров</param>
        public Function_Class(string Function_name, string type_function,
            ArrayList parametrs)
        {
            //Объявление строковой переменной для формирования запроса
            string query = "";
            try
            {
                //Проверка на тип функции
                switch (type_function)
                {
                    case "scalar":
                        //Формирование первой части скалярного запроса
                        query = string.Format(@"select [dbo].[{0}](",
                        Function_name);
                        break;
                    case "table":
                        //Формирование первой части табличного запроса
                        query = string.Format(@"select * from [dbo].[{0}](",
                        Function_name);
                        break;
                }
                //Строковая переменная колекции параметров
                //Вторая часть любого запроса
                string list_param = "";
                //Условие на проверку количества параметров
                switch (parametrs.Count)
                {
                    case 1:
                        //В случае если параметр один запрос завершается
                        list_param += parametrs[0].ToString() + ")";
                        break;
                    default:
                        //Перебор всех параметров из коллекции ArrayList
                        foreach (object param in parametrs)
                        {
                            //Присвоение в строковую переменную 
                            //полученный список параметров из перегрузки
                            list_param += param + ",";
                        }
                        //Удаление из получееной строки поледней запятой
                        list_param = 
                            list_param.Remove(list_param.Length - 1, 1);
                        //Закрывающая скобка запрпоса обращения 
                        //к функции
                        list_param += ")";
                        break;
                }
                //Конкатенирование первой и второй части запроса
                query += list_param;
                //Занесение запроса в класс Table_Data
                Table_Class table = new Table_Class(query);
                //Присвоение результирующей таблицы в выходную таблицу
                Restable = table.table;
            }
            catch
            {

            }
        }
    }
}
