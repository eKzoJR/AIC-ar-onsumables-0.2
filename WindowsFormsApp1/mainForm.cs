using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
using static WindowsFormsApp1.Program;
using Excel = Microsoft.Office.Interop.Excel;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class mainForm : Form
    {
        #region Приватные переменные
       
        //Подключение БД
        private SQLiteConnection DB;

        public mainForm()
        {
            InitializeComponent();
            RoomInformation = new informationRoomsForm();
        }
        private informationRoomsForm RoomInformation;
        
        #endregion

        //Открытие подключения БД и отображение данных при запуске программы
        private async void mainForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.connection);
            await DB.OpenAsync();
            LoadingDB();
        }

        #region Работа с данными
        //Отображение данных
        private async void LoadingDB()
        {
            sellersInformation.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Sellers", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{sellersTable.Kod_Sellers}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{sellersTable.Surname}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{sellersTable.NameSallers}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{sellersTable.SecondSurname}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{sellersTable.CommisionProcent}"]}");
                    data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{sellersTable.CommisionPercentage}"]}");
                }

                foreach (string[] s in data)
                {
                    sellersInformation.Rows.Add(s);
                }
                sellersInformation.ClearSelection();

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

        // Добавление данных
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand("INSERT INTO Sellers (Surname, NameSalers, SecondSurname, CommisionProcent, CommisionPercentage) VALUES(@Surname, @NameSalers, @SecondSurname, @CommisionProcent, @CommisionPercentage)", DB);

                command.Parameters.AddWithValue("@Surname", this.textBox1.Text);
                command.Parameters.AddWithValue("@NameSalers", this.textBox2.Text);
                command.Parameters.AddWithValue("@SecondSurname", this.textBox3.Text);
                command.Parameters.AddWithValue("@CommisionProcent", this.textBox4.Text);
                command.Parameters.AddWithValue("@CommisionPercentage", this.textBox5.Text);

                command.ExecuteNonQuery();
                LoadingDB();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка! Не удалось добавить данные.");
                return;
            }
            
        }
        
        // Сохранение данных
        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand("UPDATE Sellers SET Surname = @Surname, NameSalers = @NameSalers, SecondSurname = @SecondSurname, CommisionProcent = @CommisionProcent, CommisionPercentage = @CommisionPercentage WHERE Kod_Sellers = @Kod_Sellers", DB);

                command.Parameters.AddWithValue("@Kod_Sellers", this.textBox7.Text);
                command.Parameters.AddWithValue("@Surname", this.textBox1.Text);
                command.Parameters.AddWithValue("@NameSalers", this.textBox2.Text);
                command.Parameters.AddWithValue("@SecondSurname", this.textBox3.Text);
                command.Parameters.AddWithValue("@CommisionProcent", this.textBox4.Text);
                command.Parameters.AddWithValue("@CommisionPercentage", this.textBox5.Text);

                command.ExecuteNonQuery();
                LoadingDB();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка! Не удалось сохранить данные.");
                return;
            }
           
        }
        
        // Удаление данных
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand("DELETE FROM Sellers where Kod_Sellers = @Kod_Sellers", DB);

                command.Parameters.AddWithValue("@Kod_Sellers", this.textBox7.Text);

                command.ExecuteNonQuery();
                LoadingDB();
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
            LoadingDB();
        }
        
        //Отображение данных в текстбоксах
        private void studentInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                sellersInformation.CurrentRow.Selected = true;
                textBox7.Text = sellersInformation.Rows[e.RowIndex].Cells["Kod_Sellers"].FormattedValue.ToString();
                textBox1.Text = sellersInformation.Rows[e.RowIndex].Cells["SurnameColumns"].FormattedValue.ToString();
                textBox2.Text = sellersInformation.Rows[e.RowIndex].Cells["NameColumns"].FormattedValue.ToString();
                textBox3.Text = sellersInformation.Rows[e.RowIndex].Cells["PatronymicColumns"].FormattedValue.ToString();
                textBox4.Text = sellersInformation.Rows[e.RowIndex].Cells["GroupColumns"].FormattedValue.ToString();
                textBox5.Text = sellersInformation.Rows[e.RowIndex].Cells["DebtColumns"].FormattedValue.ToString(); 
            }
        }
       
        //Поиск данных по слову
        private async void searchButton_Click(object sender, EventArgs e)
        {
            sellersInformation.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Sellers WHERE Surname LIKE @SearchWord OR NameSalers LIKE @SearchWord OR SecondSurname LIKE @SearchWord", DB);
            command.Parameters.AddWithValue("@SearchWord", $"%{searchTextBox.Text}");
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{sellersTable.Kod_Sellers}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{sellersTable.Surname}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{sellersTable.NameSallers}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{sellersTable.SecondSurname}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{sellersTable.CommisionProcent}"]}");
                    data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{sellersTable.CommisionPercentage}"]}");
                }

                foreach (string[] s in data)
                {
                    sellersInformation.Rows.Add(s);
                }
                sellersInformation.ClearSelection();

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

        //Экспорт данных в эксель
        private void exportButton_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            
            for (int i = 1; i < sellersInformation.Columns.Count + 1; i++)
            {
                wsh.Cells[1, i] = sellersInformation.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < sellersInformation.Rows.Count - 1; i++)
            {
                for (int j = 0; j < sellersInformation.Columns.Count; j++)
                {
                    wsh.Cells[i + 2, j + 1] = sellersInformation.Rows[i].Cells[j].Value.ToString();
                }
            }

            wsh.Range["A1"].Value = "Код";
            wsh.Range["B1"].Value = "Фамилия";
            wsh.Range["C1"].Value = "Имя";
            wsh.Range["D1"].Value = "Отчество";
            wsh.Range["E1"].Value = "Процент коммисионных";
            wsh.Range["F1"].Value = "Коммисионное вознаграждение";
            exApp.Visible = true;
        }
        #endregion

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
        
        //Перемещение формы
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
        
        //Открытие 2 формы
        private void switchingRoomButton_Click(object sender, EventArgs e)
        {
            if (RoomInformation.IsDisposed)
            {
                RoomInformation = new informationRoomsForm();
            }
            RoomInformation.Show();
            RoomInformation.Focus();
        }
        
        //Сворачивание формы
        private void collapsePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        //Выход из программы
        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //Очистка текстбоксов формы
        private void ClearBox_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
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
        private void switchingSalesButton_Click(object sender, EventArgs e)
        {
            salesInformationForm Sales = new salesInformationForm();
            Sales.ShowDialog();
        }

        #endregion

        #region Запросы в БД
        private async void button1_Click(object sender, EventArgs e)
        {
            sellersInformation.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Sellers WHERE SecondSurname LIKE 'И%' ", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{sellersTable.Kod_Sellers}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{sellersTable.Surname}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{sellersTable.NameSallers}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{sellersTable.SecondSurname}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{sellersTable.CommisionProcent}"]}");
                    data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{sellersTable.CommisionPercentage}"]}");
                }

                foreach (string[] s in data)
                {
                    sellersInformation.Rows.Add(s);
                }
                sellersInformation.ClearSelection();

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
            sellersInformation.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Sellers WHERE CommisionProcent > 10", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{sellersTable.Kod_Sellers}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{sellersTable.Surname}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{sellersTable.NameSallers}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{sellersTable.SecondSurname}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{sellersTable.CommisionProcent}"]}");
                    data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{sellersTable.CommisionPercentage}"]}");
                }

                foreach (string[] s in data)
                {
                    sellersInformation.Rows.Add(s);
                }
                sellersInformation.ClearSelection();

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
            sellersInformation.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand("UPDATE Sellers SET CommisionProcent = CommisionProcent + 10", DB);
            await command.ExecuteNonQueryAsync();
            SQLiteCommand command1 = new SQLiteCommand("SELECT * FROM Sellers", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command1.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{sellersTable.Kod_Sellers}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{sellersTable.Surname}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{sellersTable.NameSallers}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{sellersTable.SecondSurname}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{sellersTable.CommisionProcent}"]}");
                    data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{sellersTable.CommisionPercentage}"]}");
                }

                foreach (string[] s in data)
                {
                    sellersInformation.Rows.Add(s);
                }
                sellersInformation.ClearSelection();

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

        #endregion

    }
}