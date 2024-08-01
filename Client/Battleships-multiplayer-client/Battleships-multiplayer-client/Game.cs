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
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra;



namespace Battleships_multiplayer_client
{
    public partial class Game : Form
    {
        [DllImport("user32.dll")]
        static extern bool GetAsyncKeyState(int vKey);

        const string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string[] ships = { "Minesweep", "Frigate", "Cruiser", "Battleship" };
        public PictureBox currentActiveShip = null;
        public List<PictureBox> fleet = new List<PictureBox>();
        public List<PictureBox> placedFleet = new List<PictureBox>();
        public List<int> shipsAvailable = new List<int> { 4, 3, 2, 1 };
        const int GRID_LENGTH = 50;
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        int count = 0;

        public Game()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.DoubleBuffered = true;

            myTimer.Interval = 100;
            myTimer.Tick += timeTick;

        }

        private void timeTick(object? sender, EventArgs e)
        {
            if (currentActiveShip != null)
            {

                if (!placedFleet.Contains(currentActiveShip))
                {
                    if (GetAsyncKeyState(87))
                    {
                        //up
                        if (currentActiveShip.Location.Y - GRID_LENGTH >= 100) currentActiveShip.Location = new Point { X = currentActiveShip.Location.X, Y = currentActiveShip.Location.Y - GRID_LENGTH };
                    }
                    if (GetAsyncKeyState(83))
                    {
                        //down
                        if (currentActiveShip.Location.Y + (currentActiveShip.Height) < 100 + (10 * GRID_LENGTH)) currentActiveShip.Location = new Point { X = currentActiveShip.Location.X, Y = currentActiveShip.Location.Y + GRID_LENGTH };
                    }
                    if (GetAsyncKeyState(68))
                    {
                        //right
                        if (currentActiveShip.Location.X + GRID_LENGTH <= (100 - currentActiveShip.Width) + (10 * GRID_LENGTH)) currentActiveShip.Location = new Point { X = currentActiveShip.Location.X + GRID_LENGTH, Y = currentActiveShip.Location.Y };
                    }
                    if (GetAsyncKeyState(65))
                    {
                        //left
                        if (currentActiveShip.Location.X - GRID_LENGTH >= 100) currentActiveShip.Location = new Point { X = currentActiveShip.Location.X - GRID_LENGTH, Y = currentActiveShip.Location.Y };
                    }
                    if (GetAsyncKeyState(82))
                    {
                        if (count == 0)
                        {
                            if (currentActiveShip.Location.Y <= GRID_LENGTH * (10 + 2 - currentActiveShip.Width / GRID_LENGTH))
                            {
                                count++;
                                currentActiveShip.Width = GRID_LENGTH;
                                currentActiveShip.Height = (listBox1.SelectedIndex + 2) * GRID_LENGTH;
                            }
                        }
                        else if (count == 1)
                        {
                            if (currentActiveShip.Location.X <= GRID_LENGTH * (10 + 2 - currentActiveShip.Height / GRID_LENGTH))
                            {
                                count--;
                                currentActiveShip.Width = (listBox1.SelectedIndex + 2) * GRID_LENGTH;
                                currentActiveShip.Height = GRID_LENGTH;
                            }
                        }


                    }
                    if (GetAsyncKeyState(13))
                    {
                        bool intersects = false;
                        foreach(PictureBox ship in placedFleet)
                        {
                            if (currentActiveShip.Bounds.IntersectsWith(ship.Bounds))
                            {
                                intersects = true;
                            }
                        }
                        if (!intersects)
                        {
                            placedFleet.Add(currentActiveShip);
                            bool x = false;
                            foreach (int i in shipsAvailable)
                            {
                                if (i == 0)
                                {
                                    x = true;
                                }
                                else
                                {
                                    x = false;
                                }
                            }
                            if (x)
                            {
                                button1.Visible = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cannot place a ship over the bounds off another ship");
                        }
                    }
                }
            }
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
            myTimer.Start();
            populateListBox();
            button1.Visible = false;
        }





        

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            Pen pen = new Pen(Color.Black, 2);
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    e.Graphics.DrawRectangle(pen, (x * GRID_LENGTH) + 100, (y * GRID_LENGTH) + 100, GRID_LENGTH, GRID_LENGTH);
                }
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shipsAvailable[listBox1.SelectedIndex] > 0)
            {
                PictureBox ship = new PictureBox { Location = new Point { X = 100, Y = 100 }, Size = new Size { Width = GRID_LENGTH * (listBox1.SelectedIndex + 2), Height = GRID_LENGTH }, BackColor = Color.Black };
                this.Controls.Add(ship);
                ship.BringToFront();
                fleet.Add(ship);
                currentActiveShip = ship;

                shipsAvailable[listBox1.SelectedIndex]--;
                populateListBox();
            }
        }
        private void populateListBox()
        {
            richTextBox2.Clear();
            string[] items = new string[4];

            for (int i = 0; i < 4; i++)
            {
                items[i] = (ships[i] + " (" + (i + 2).ToString() + " squares) x" + shipsAvailable[i]).ToString();
                richTextBox2.AppendText(items[i] + "\n");
            }


        }
        private string exportGameDataJson()
        {
            List<Ship> shipList = new List<Ship>();
            foreach(PictureBox ship in placedFleet)
            {
                Point start = ship.Location;
                Point end = ship.Location;
                if (ship.Height == GRID_LENGTH)
                {
                    end = new Point { X = ship.Location.X + ship.Width, Y = ship.Location.Y };

                }
                else if (ship.Width == GRID_LENGTH)
                {
                    end = new Point { X = ship.Location.X, Y = ship.Location.Y+ship.Location.Y };
                }
                Ship s = new Ship { start = start, end = end };
            }
        }
       
        

        
    }
    public class Map
    {
        public List<Ship> fleet { get; set; }
    }

    public class Ship
    {
        public Point start { get; set; }
        public Point end { get; set; }
    }
}
