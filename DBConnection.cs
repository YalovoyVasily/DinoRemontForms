using System;
using System.Data.SqlClient;
using System.Data;

namespace DinoRemont
{
    public class DBConnection
    {
        public static SqlConnection connection = new SqlConnection(Configuration_class.connection.ConnectionString);

        public DataTable dtBank = new DataTable("Bank");
        public DataTable dtEmployee = new DataTable("Employee");
        public DataTable dtOrder = new DataTable("Order");
        public DataTable dtSupplier = new DataTable("Supplier");
        public DataTable dtPosition = new DataTable("Position");
        public DataTable dtAccount = new DataTable("Account");

        public static string
            qrBank = "SELECT [ID_Bank], [Name_Bank] as \"Банк\", [BIK_Bank] as \"БИК\", [KOR_Bank] as \"КОР счёт\" FROM [Dino_Remont_DB].[dbo].[Bank]",
            qrAccount = "SELECT [ID_Account], [Login_Account] as \"Логин\", [Password_Account] as \"Пароль\" FROM [Dino_Remont_DB].[dbo].[Account]",
            qrSupplier = "SELECT [ID_Supplier], [Name_Supplier] as \"Поставщик\", [INN_Supplier] as \"ИНН\", [KPP_Supplier] as \"КПП\"," +
            " [Bank_Account_Supplier] as \"Банковский счёт\", [Bank_ID]," +
            " [ID_Bank], [Name_Bank] as \"Банк\", [BIK_Bank] as \"БИК\", [KOR_Bank] as \"КОР счёт\"" +
            " FROM [Dino_Remont_DB].[dbo].[Supplier]" +
            " INNER JOIN [dbo].[Bank] ON [dbo].[Supplier].[Bank_ID] = [dbo].[Bank].[ID_Bank]",
            qrPosition = "SELECT [ID_Position], [Name_Position] as \"Должность\" ,[Salary] as \"Оклад\" FROM [Dino_Remont_DB].[dbo].[Position]",
            qrEmployee = "SELECT [ID_Employee], [Last_Name_Employee] as \"Фамилия\", [Name_Employee] as \"Имя\", [Middle_Name_Employee] as \"Отчество\"," +
            "  [Invalidety_Employee] as \"Инвалидность\"," +
            " [Position_ID], [Account_ID], " +
            "[ID_Position], [Name_Position] as \"Должность\" ,[Salary] as \"Оклад\"," +
            "[ID_Account], [Login_Account] as \"Логин\"" +
            " FROM [Dino_Remont_DB].[dbo].[Employee]" +
            "INNER JOIN [dbo].[Position] ON [dbo].[Employee].[Position_ID] = [dbo].[Position].[ID_Position]" +
            "INNER JOIN [dbo].[Account] ON [dbo].[Employee].[Account_ID] = [dbo].[Account].[ID_Account]",
            qrOrder = "SELECT [ID_Order], [Price_Order] as \"Цена\", [Material_Order] as \"Материал\", [Amount_Order] as \"Количество\"," +
            " [Status_Order] as \"Состояние\"," +
            " [Supplier_ID], [Employee_ID], " +
            "[ID_Supplier], [Name_Supplier] as \"Поставщик\", " +
            "[ID_Employee], [Last_Name_Employee] as \"Фамилия\", [Name_Employee] as \"Имя\", [Middle_Name_Employee] as \"Отчество\"" +
            " FROM [Dino_Remont_DB].[dbo].[Order]" +
            "INNER JOIN [dbo].[Supplier] ON [dbo].[Order].[Supplier_ID] = [dbo].[Supplier].[ID_Supplier]" +
            "INNER JOIN [dbo].[Employee] ON [dbo].[Order].[Employee_ID] = [dbo].[Employee].[ID_Employee]";

        private SqlCommand command = new SqlCommand("", connection);
        private void dtFill(DataTable table, string query)
        {
            command.CommandText = query;
            connection.Open();
            table.Load(command.ExecuteReader());
            connection.Close();
        }

        public static Int32 IDrecord, IDuser;
        public void dbEnter(string login, string password)
        {
            command.CommandText = "SELECT count(*) FROM [dbo].[Account] " +
                "where [Login_Account] = '" + login + "' and [Password_Account] = '" +
                password + "'";
            connection.Open();
            IDuser = Convert.ToInt32(command.ExecuteScalar().ToString());
            connection.Close();
        }

        public void BankFill()
        {
            dtFill(dtBank, qrBank);
        }

        public void AccountFill()
        {
            dtFill(dtAccount, qrAccount);
        }
        public void SupplierFill()
        {
            dtFill(dtSupplier, qrSupplier);
        }
        public void PositionFill()
        {
            dtFill(dtPosition, qrPosition);
        }
        public void EmployeeFill()
        {
            dtFill(dtEmployee, qrEmployee);
        }
        public void OrderFill()
        {
            dtFill(dtOrder, qrOrder);
        }

    }
}