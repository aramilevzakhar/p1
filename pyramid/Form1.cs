using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pyramid
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();
        bool isDragged = false;
        Point ptOffset;
        

        public Form1()
        {
            InitializeComponent();
            AllowDrop = true;

            Width = 700;
            Height = 500;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            //button1.Location = new Point(rnd.Next(0, 700 - button1.Width), rnd.Next(0, 300 - button1.Height));
            //button2.Location = new Point(rnd.Next(0, 700 - button2.Width), rnd.Next(0, 300 - button2.Height));
            //button3.Location = new Point(rnd.Next(0, 700 - button3.Width), rnd.Next(0, 300 - button3.Height));
            //var a = SystemInformation.DragSize;

        }



        public void success()
        {
            MessageBox.Show("Верно");
        }


        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

            
            if (e.Button == MouseButtons.Left)
            {
                isDragged = true;
                Point ptStartPosition = button1.PointToScreen(new Point(e.X, e.Y));

                ptOffset = new Point();
                ptOffset.X = button1.Location.X - ptStartPosition.X;
                ptOffset.Y = button1.Location.Y - ptStartPosition.Y;
            }
            else
            {
                isDragged = false;
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragged)
            {
                Point newPoint = button1.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ptOffset);
                button1.Location = newPoint;
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragged = false;
        }

    }
}
