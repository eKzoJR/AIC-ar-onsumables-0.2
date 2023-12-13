using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
using static WindowsFormsApp1.Program;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class salesInformationForm : Form
    {
        private SQLiteConnection DB;

        public salesInformationForm()
        {
            InitializeComponent();
        }

        private async void salesInformationForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.connection);
            await DB.OpenAsync();
            LoadingDB();
        }

        //Отображение данных
        private async void LoadingDB()
        {
            salesInformation.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Sales JOIN Sellers ON Sellers.Kod_Sellers = Sales.Kod_SellersNM JOIN Goods ON Goods.Kod_Goods = Sales.Kod_GoodsNM ", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{salesTable.Kod_Sales}"]}");
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["Surname"]);
                    data[data.Count - 1][2] = Convert.ToString(sqlReader["nameProduct"]);
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{salesTable.dateOfSale}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{salesTable.numberOfSales}"]}");
                }

                foreach (string[] s in data)
                {
                    salesInformation.Rows.Add(s);
                }
                salesInformation.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
        }

        #region Взаимодействие с формой

        System.Drawing.Point WindowsPosition; // Работа с формой программы

        //Проверки для перемещения
        public new void Move(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                WindowsPosition = MousePosition;
        }
        public void Move2(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int PosX = MousePosition.X - WindowsPosition.X;
                int PosY = MousePosition.Y - WindowsPosition.Y;
                System.Drawing.Point Loc = new System.Drawing.Point(Location.X + PosX, Location.Y + PosY);
                Location = Loc;
                WindowsPosition = MousePosition;
            }
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
           Hide();
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            Move2(e);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            Move(e);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            Move(e);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Move2(e);
        }
        private void exportButton_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

            for (int i = 1; i < salesInformation.Columns.Count + 1; i++)
            {
                wsh.Cells[1, i] = salesInformation.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < salesInformation.Rows.Count - 1; i++)
            {
                for (int j = 0; j < salesInformation.Columns.Count; j++)
                {
                    wsh.Cells[i + 2, j + 1] = salesInformation.Rows[i].Cells[j].Value.ToString();
                }
            }

            wsh.Range["A1"].Value = "Код продажи";
            wsh.Range["B1"].Value = "Продавец";
            wsh.Range["C1"].Value = "Товар";
            wsh.Range["D1"].Value = "Дата продажи";
            wsh.Range["E1"].Value = "Количество продаж";
            exApp.Visible = true;
        }

        #endregion

        private async void button1_Click(object sender, EventArgs e)
        {
            salesInformation.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand("SELECT Kod_GoodsNM, nameProduct, min(numberOfSales) AS Minimal_quantity, max(numberOfSales) AS Maximum_quantity FROM Sales JOIN Goods on Kod_Goods = Sales.Kod_GoodsNM GROUP BY Kod_GoodsNM", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                salesInformation.Columns[2].HeaderText = "Минимальная цена закупки";
                salesInformation.Columns[3].HeaderText = "Максимальная цена закупки";
                salesInformation.Columns[1].HeaderText = "Название товара";
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = Convert.ToString(sqlReader["Kod_GoodsNM"]);
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["nameProduct"]);
                    data[data.Count - 1][2] = Convert.ToString(sqlReader["Minimal_quantity"]);
                    data[data.Count - 1][3] = Convert.ToString(sqlReader["Maximum_quantity"]);
                }

                foreach (string[] s in data)
                {
                    salesInformation.Rows.Add(s);
                }
                salesInformation.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
        }
    }
}
