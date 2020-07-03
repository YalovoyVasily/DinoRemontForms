using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinoRemont
{
    public static class Program
    {
        public static string intID = "";
        //Первичный ключ для работы с сессией пользователя

        public static bool Welcome = false;
        public static bool GoodBye = false;
        public static Int32 WindowX = 0;
        public static Int32 WindowY = 0;
        public static Int32 RedColor = 255, GreenColor = 255, BlueColor = 128;
        public static bool connect = false;
        //Определяет есть подключение к БД или нет
        private static Mutex _instanse;
        //Класс создания виртуального процесса приложения
        private const string _app_Name = "DinoRemont";
        //Название приложения
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Переменная переключатель для определения запуска приложения
            bool Create_app;
            //Объявление экземпляра класса нового виртуцального процесса
            _instanse = new Mutex(true, _app_Name, out Create_app);
            if (Create_app)
            {
                

                try
                {
                    //В случае если процесс не найден в системе
                    //создаётся экземпляр класса конфигурации подключения
                    //к источнику данных

                    Configuration_class configuration
                        = new Configuration_class();
              
                    //Вызывается метод получения информации из реестра
                    configuration.SQL_Server_Configuration_Get();
                    //Попытка открыть поддключение к источнику данных
                  
                    Configuration_class.connection.Open();
                    //В случае если подключение открыто 
                    //в переменую присваевается значение истины
                    
                    connect = true;
                }
                catch
                {
                  
                    //Стилистика элементов уаправления ОС
                    Application.EnableVisualStyles();
                    //Обязательная дрянь, хер поймиёшь зачем она нужна
                    Application.SetCompatibleTextRenderingDefault(false);
                    //Объявление экземпляра класса
                    //конфигурации полдключения к источнику данных
                    Connection_Form connection = new Connection_Form();
                    //Вывод окна подключения к источнику данных
                    //В режиме диалогового окна
                    connection.ShowDialog();
                }
                finally
                {
                    //Закрытие подключения к источнику данных
                    Configuration_class.connection.Close();
                 
                    //Проверка состояния подключения к источнику данных
                    switch (connect)
                    {
                        //Если пользователь НЕ настроил подключение то 
                        //вывод сообщения об ошибке 
                        case false:
                         
                            MessageBox.Show("Ошибка подключения " +
                                "к источнику данных!",
                                "DinoRemont",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            //Закрытие приложения
                            Environment.Exit(0);
                            break;
                        //В случе если подключение установлено
                        case true:
                            try
                            {
                              
                                Application.EnableVisualStyles();
                                Application.SetCompatibleTextRenderingDefault(false);
                                
                                Application.Run(new Authorization());
                            }
                            catch
                            {

                            }
                            break;
                    }
                }
            }
        }
    }
}
