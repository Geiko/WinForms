using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms15
{
    public partial class Form1 : Form
    {
        Label temp;

        const int closely = 16;

        const int jump = 3;


        public Form1()
        {
            InitializeComponent();
            temp = catchMe;

            this.MouseMove += Form1_MouseMove;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.catchMe.Text = "Catch me";
            this.catchMe.BackColor = Color.Crimson;
            Random random = new Random();
            if (e.X > temp.Location.X - closely && e.X < temp.Location.X &&
                    e.Y > temp.Location.Y - closely && e.Y < temp.Location.Y + temp.Size.Height + closely)
                MoveRight(random);
            
            else if (e.X > temp.Location.X + temp.Size.Width && e.X < temp.Location.X + temp.Size.Width + closely &&
                    e.Y > temp.Location.Y - closely && e.Y < temp.Location.Y + temp.Size.Height + closely)
                MoveLeft(random);
            
            else if (e.X > temp.Location.X && e.X < temp.Location.X + temp.Size.Width &&
                    e.Y > temp.Location.Y - closely && e.Y < temp.Location.Y + temp.Size.Height)
                MoveDown(random);
            
            else if (e.X > temp.Location.X && e.X < temp.Location.X + temp.Size.Width &&
                    e.Y > temp.Location.Y + temp.Size.Height && e.Y < temp.Location.Y + temp.Size.Height + closely)
                MoveUp(random);      
        }

        private void MoveRight(Random random)
        {
            if (temp.Location.X + temp.Size.Width + 3*jump <= this.ClientSize.Width)
                temp.Location = new Point(temp.Location.X + jump, temp.Location.Y);
            else
            {
                int rnd = random.Next(0, 2);
                if (rnd == 0)
                    MoveUp(random);
                else
                    MoveDown(random);
            }
        }
        private void MoveLeft(Random random)
        {
            if (temp.Location.X - 3 * jump > 0)
                temp.Location = new Point(temp.Location.X - jump, temp.Location.Y);
            else
            {
                int rnd = random.Next(0, 2);
                if(rnd == 0)
                    MoveUp(random);
                else
                    MoveDown(random);
            }
        }
        private void MoveDown(Random random)
        {
            if (temp.Location.Y + temp.Size.Height + 3*jump <= this.ClientSize.Height)
                temp.Location = new Point(temp.Location.X, temp.Location.Y + jump);
            else
            {
                int rnd = random.Next(0, 2);
                if (rnd == 0)
                    MoveRight(random);
                else
                    MoveLeft(random);
            }
        }
        private void MoveUp(Random random)
        {
            if (temp.Location.Y - 3*jump > 0)
                temp.Location = new Point(temp.Location.X, temp.Location.Y - jump);
            else
            {
                int rnd = random.Next(0, 2);
                if (rnd == 0)
                    MoveRight(random);
                else
                    MoveLeft(random);
            }
        }

        private void catchMe_MouseMove(object sender, MouseEventArgs e)
        {
            this.catchMe.Text = "Good for you!";
            this.catchMe.BackColor = Color.GreenYellow;
        }
    }
}
