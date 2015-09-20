using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geiko.WinForms12
{

    /// <summary>
    /// This class represents a game "Guesswork".
    /// </summary>
    public partial class Guesswork : Form
    {
        Button button;
        Label lable;

        /// <summary>
        /// This is a constructor of Guesswork instances.
        /// </summary>
        public Guesswork()
        {
            Text = "Just a game!";
            BackColor = Color.DarkSeaGreen;
            ForeColor = Color.Red;
            Opacity = .9;
            Size = new Size(250, 450);

            button = new Button();
            button.Text = "Play!";
            Controls.Add(button);
            button.BackColor = Color.DodgerBlue;
            button.Location = new System.Drawing.Point(80, 100);
            button.Size = new System.Drawing.Size(70, 50);
            AcceptButton = button;

            lable = new Label();
            lable.Text = "Please, think out the number between \n1 and 2000. \n\nI will be guessing it.";
            lable.Location = new System.Drawing.Point(30, 10);
            lable.Size = new System.Drawing.Size(200, 60);
            Controls.Add(lable);

            Label label_img = new Label();
            Image image = Image.FromFile(@".\pic.jpg");
            label_img.Location = new Point(40, 190);
            label_img.Size = new Size(image.Width, image.Height);
            label_img.Image = image;
            Controls.Add(label_img);

            button.Click += new EventHandler(buttonClick);
        }
        /// <summary>
        /// This guesses a user number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClick(object sender, EventArgs e)
        {
            int min = 1;
            int max = 2000;
            int quantity = 0;

            string caption = "Guesswork";

            while (true)
            {
                quantity++;
                int middle = (int)((max + min) / 2);
                string Message = "Is your number more than " + middle as string;
                DialogResult result = MessageBox.Show(Message, caption, MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                    min = middle + 1;
                else
                    max = middle;

                if (min == max)
                    break;
            }
            string tmp = "YOUR NUMBER IS   " + min + "\nQuantity of attempts is " + quantity;
            MessageBox.Show(tmp, caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
