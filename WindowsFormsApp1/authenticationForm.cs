using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class authenticationForm : Form
    {
        public authenticationForm()
        {
            InitializeComponent();
            textBox1.UseSystemPasswordChar = true;
        }


        #region Работа с формой

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
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        #endregion


        private void addStudentButton_Click(object sender, EventArgs e)
        {
            string login;
            string password;
            string inputLogin;
            string inputPassword;

            login = "admin";
            password = "admin";

            inputLogin = textBox2.Text;
            inputPassword = textBox1.Text;

            if (login == inputLogin && password == inputPassword) 
            {
                authenticationForm authentication = new authenticationForm();
                mainForm Sellers = new mainForm();
                this.Hide();
                Sellers.Show();
            }

            else
            {
                MessageBox.Show("Неправильный логин или пароль.");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox4.Visible = true;

            if (pictureBox7.Visible == false ) 
            {
                textBox1.UseSystemPasswordChar = false;
            }
            if (pictureBox7.Visible == true)
            {
                textBox1 .UseSystemPasswordChar = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            pictureBox4.Visible = false;

            if (pictureBox7.Visible == false)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            if (pictureBox7.Visible == true)
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }
    }
}
