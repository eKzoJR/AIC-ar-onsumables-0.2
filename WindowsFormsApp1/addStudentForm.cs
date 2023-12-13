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
    public partial class addStudentForm : Form
    {
        public addStudentForm()
        {
            InitializeComponent();
        }

        Point WindowsPosition;
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
                Point Loc = new Point(Location.X + PosX, Location.Y + PosY);
                Location = Loc;
                WindowsPosition = MousePosition;
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Move2(e);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Move(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Move(e);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Move2(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ()
        }
    }
}
