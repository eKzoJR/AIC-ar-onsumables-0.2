using System;
using System.Windows.Forms; 

namespace WindowsFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }

        #region База данных
        //Подключение базы данных
        public static class DataBase
        {
            public static string connection = @"Data source = Shop.db; Integrated security = False;
                                          MultipleActiveResultSets = True";        
        }
        
        //Создание публичных пемеренных для БД 
        public static class sellersTable
        {
            public static string Main = "Sellers";
            public static string Kod_Sellers = "Kod_Sellers";
            public static string Surname = "Surname";
            public static string NameSallers = "NameSalers";
            public static string SecondSurname = "SecondSurname";
            public static string CommisionProcent = "CommisionProcent";
            public static string CommisionPercentage = "CommisionPercentage";
        }

        //Создание публичных пемеренных для БД 
        public static class goodsTable
        {
            public static string Main = "Goods";
            public static string Kod_Goods = "Kod_Goods";
            public static string nameProduct = "nameProduct";
            public static string Unit = "Unit";
            public static string priceBuy = "priceBuy";
            public static string priceSale = "priceSale";
        }

        //Создание публичных пемеренных для БД 
        public static class salesTable
        {
            public static string Main = "Sales";
            public static string Kod_Sales = "Kod_Sales";
            public static string Kod_SellersNM = "Kod_SellersNM";
            public static string Kod_GoodsNM = "Kod_GoodsNM";
            public static string dateOfSale = "dateOfSale";
            public static string numberOfSales = "numberOfSales";
        }

        public static string SelectedItem { get; set; }
        #endregion
    }
}
