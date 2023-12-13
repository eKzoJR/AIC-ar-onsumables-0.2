using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
using static WindowsFormsApp1.Program;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class informationRoomsForm : Form
    {
        #region Приватные переменные
        //Подключение БД
        private SQLiteConnection DB;

        public informationRoomsForm()
        {
            InitializeComponent();
        }
        #endregion
        
        private async void informationRoomsForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.connection);
            await DB.OpenAsync();
            LoadingRoom();
        }

        #region Работа с данными
        
        // Отображение данных
        private async void LoadingRoom()
        {
            roomInformation.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Goods", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{goodsTable.Kod_Goods}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{goodsTable.nameProduct}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{goodsTable.Unit}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{goodsTable.priceBuy}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{goodsTable.priceSale}"]}");
                }

                foreach (string[] s in data)
                {
                    roomInformation.Rows.Add(s);
                }
                roomInformation.ClearSelection();

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

        //Добавление данных
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand("INSERT INTO Goods (nameProduct, Unit, priceBuy, priceSale) VALUES (@nameProduct, @Unit, @priceBuy, @priceSale)", DB);

                command.Parameters.AddWithValue("@nameProduct", this.textBox1.Text);
                command.Parameters.AddWithValue("@Unit", this.comboBoxUnit.Text);
                command.Parameters.AddWithValue("@priceBuy", this.textBox3.Text);
                command.Parameters.AddWithValue("@priceSale", this.textBox5.Text);

                command.ExecuteNonQuery();
                LoadingRoom();

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка! Не удалось добавить данные.");
                return;
            }
        }
        
        //Сохранение данных
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand("UPDATE Goods SET nameProduct = @nameProduct, Unit = @Unit, priceBuy = @priceBuy, priceSale = @priceSale WHERE Kod_Goods = @Kod_Goods", DB);

                command.Parameters.AddWithValue("@Kod_Goods", this.textBoxID.Text);
                command.Parameters.AddWithValue("@nameProduct", this.textBox1.Text);
                command.Parameters.AddWithValue("@Unit", this.comboBoxUnit.Text);
                command.Parameters.AddWithValue("@priceBuy", this.textBox3.Text);
                command.Parameters.AddWithValue("@priceSale", this.textBox5.Text);

                command.ExecuteNonQuery();
                LoadingRoom();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка! Не удалось сохранить данные.");
                return;
            }
        }

        //Удаление данных
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand("DELETE FROM Goods where Kod_Goods = @Kod_Goods", DB);

                command.Parameters.AddWithValue("@Kod_Goods", this.textBoxID.Text);

                command.ExecuteNonQuery();
                LoadingRoom();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка! Не удалось удалить данные.");
                return;
            }
        }

        //Обновление данных
        private void updateButton_Click(object sender, EventArgs e)
        {
            roomInformation.Columns[3].HeaderText = "Цена закупки";
            LoadingRoom();
        }
        
        //Отображение данных в текстбоксах
        private void roomInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                roomInformation.CurrentRow.Selected = true;
                textBoxID.Text = roomInformation.Rows[e.RowIndex].Cells["Kod_Goods"].FormattedValue.ToString();
                textBox1.Text = roomInformation.Rows[e.RowIndex].Cells["nameProductColumn"].FormattedValue.ToString();
                comboBoxUnit.Text = roomInformation.Rows[e.RowIndex].Cells["UnitColumn"].FormattedValue.ToString();
                textBox3.Text = roomInformation.Rows[e.RowIndex].Cells["PriceBuyColumn"].FormattedValue.ToString();
                textBox5.Text = roomInformation.Rows[e.RowIndex].Cells["PriceSaleColumn"].FormattedValue.ToString();
            }
        }
        
        //Экспорт данных в эксель
        private void exportButton_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;


            for (int i = 1; i < roomInformation.Columns.Count + 1; i++)
            {
                wsh.Cells[1, i] = roomInformation.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < roomInformation.Rows.Count - 1; i++)
            {
                for (int j = 0; j < roomInformation.Columns.Count; j++)
                {
                    wsh.Cells[i + 2, j + 1] = roomInformation.Rows[i].Cells[j].Value.ToString();
                }
            }

            wsh.Range["A1"].Value = "Код";
            wsh.Range["B1"].Value = "Название продукта";
            wsh.Range["C1"].Value = "Единица измерения";
            wsh.Range["D1"].Value = "Цена закупки";
            wsh.Range["E1"].Value = "Цена продажи";
            exApp.Visible = true;
        }
        #endregion
        #region Взаимодействие с формой

        // Работа с формой программы
        System.Drawing.Point WindowsPosition; 
        
        //Проверка для перемещения
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

        //Закрытие формы
        private void backPictureBox_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //Перемещение
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            Move(e);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Move2(e);
        }
        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            Move(e);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            Move2(e);
        }
        
        //Очистка текстбоксов и комбобоксов
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBoxUnit.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        
        //Подсказки
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для добавления данных: \n1) Введите данные в поля выше. \n2) Нажмите кнопку 'Добавить'.");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для сохранения данных: \n1) Выберите нужную строчку в таблице. \n2) Измените данные в необходимых полях выше. \n3) Нажмите кнопку 'Сохранить'.");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для удаления данных: \n1) Выберите нужную строчку в таблице. \n2) Нажмите кнопку 'Удалить'.");
        }
        #endregion

        private async void button1_Click(object sender, EventArgs e)
        {
            roomInformation.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Goods WHERE priceBuy BETWEEN 100 and 500", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{goodsTable.Kod_Goods}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{goodsTable.nameProduct}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{goodsTable.Unit}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{goodsTable.priceBuy}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{goodsTable.priceSale}"]}");
                }

                foreach (string[] s in data)
                {
                    roomInformation.Rows.Add(s);
                }
                roomInformation.ClearSelection();

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

        private async void button2_Click(object sender, EventArgs e)
        {
            roomInformation.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand("SELECT nameProduct, AVG(priceBuy) AS AVG_priceBuy FROM Goods GROUP BY nameProduct", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                roomInformation.Columns[3].HeaderText = "Средняя цена закупки";
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{goodsTable.nameProduct}"]}");
                    data[data.Count - 1][3] = Convert.ToString(sqlReader["AVG_priceBuy"]);
                }

                foreach (string[] s in data)
                {
                    roomInformation.Rows.Add(s);
                }
                roomInformation.ClearSelection();

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

        private async void button3_Click(object sender, EventArgs e)
        {
            roomInformation.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand("CREATE TABLE ExpensiveGoods AS SELECT * FROM Goods WHERE priceBuy > 1000", DB);
            await command.ExecuteNonQueryAsync();
            SQLiteCommand command1 = new SQLiteCommand("SELECT * FROM ExpensiveGoods", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command1.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = Convert.ToString(sqlReader["Kod_Goods"]);
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["nameProduct"]);
                    data[data.Count - 1][2] = Convert.ToString(sqlReader["Unit"]);
                    data[data.Count - 1][3] = Convert.ToString(sqlReader["priceBuy"]);
                    data[data.Count - 1][4] = Convert.ToString(sqlReader["priceSale"]);
                }

                foreach (string[] s in data)
                {
                    roomInformation.Rows.Add(s);
                }
                roomInformation.ClearSelection();

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

            SQLiteCommand command2 = new SQLiteCommand("DROP TABLE ExpensiveGoods", DB);
            await command2.ExecuteNonQueryAsync();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            roomInformation.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand("CREATE TABLE CopyGoods AS SELECT * FROM Goods", DB);
            await command.ExecuteNonQueryAsync();
            SQLiteCommand command1 = new SQLiteCommand("SELECT * FROM CopyGoods", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command1.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = Convert.ToString(sqlReader["Kod_Goods"]);
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["nameProduct"]);
                    data[data.Count - 1][2] = Convert.ToString(sqlReader["Unit"]);
                    data[data.Count - 1][3] = Convert.ToString(sqlReader["priceBuy"]);
                    data[data.Count - 1][4] = Convert.ToString(sqlReader["priceSale"]);
                }

                foreach (string[] s in data)
                {
                    roomInformation.Rows.Add(s);
                }
                roomInformation.ClearSelection();

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

        private async void button6_Click(object sender, EventArgs e)
        {
            roomInformation.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Goods WHERE nameProduct LIKE @SearchWord", DB);
            command.Parameters.AddWithValue("@SearchWord", $"%{searchTextBox.Text}");
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = Convert.ToString(sqlReader["Kod_Goods"]);
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["nameProduct"]);
                    data[data.Count - 1][2] = Convert.ToString(sqlReader["Unit"]);
                    data[data.Count - 1][3] = Convert.ToString(sqlReader["priceBuy"]);
                    data[data.Count - 1][4] = Convert.ToString(sqlReader["priceSale"]);
                }

                foreach (string[] s in data)
                {
                    roomInformation.Rows.Add(s);
                }
                roomInformation.ClearSelection();

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

        private async void button5_Click(object sender, EventArgs e)
        {
            roomInformation.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand("DELETE FROM CopyGoods WHERE priceBuy > 1000", DB);
            await command.ExecuteNonQueryAsync();
            SQLiteCommand command1 = new SQLiteCommand("SELECT * FROM CopyGoods", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command1.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = Convert.ToString(sqlReader["Kod_Goods"]);
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["nameProduct"]);
                    data[data.Count - 1][2] = Convert.ToString(sqlReader["Unit"]);
                    data[data.Count - 1][3] = Convert.ToString(sqlReader["priceBuy"]);
                    data[data.Count - 1][4] = Convert.ToString(sqlReader["priceSale"]);
                }

                foreach (string[] s in data)
                {
                    roomInformation.Rows.Add(s);
                }
                roomInformation.ClearSelection();

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
