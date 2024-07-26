using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships_multiplayer_client
{
    public partial class Game : Form
    {
        const string alphabet = "abcdefghijklmnopqrstuvwxyz";
        public Game()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.DoubleBuffered = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {
            this.Invalidate();
            pictureBox1.Size = Screen.FromControl(this).WorkingArea.Size;
            pictureBox1.Location = new Point { X = 0, Y = 0 };
            pictureBox1.SendToBack();

        }





        private void Game_Resize(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            const int GRID_LENGTH = 50;
            Pen pen = new Pen(Color.Black, 2);
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    e.Graphics.DrawRectangle(pen, (x * GRID_LENGTH) + 100, (y * GRID_LENGTH) + 100, GRID_LENGTH, GRID_LENGTH);
                }
            }
        }
    }
}
