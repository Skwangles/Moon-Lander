using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moon_Lander
{
    public partial class Game : Form
    {
        bool LeftB;
        bool RightB;
        bool Won = false;
        int Gravity = 3;
        string CapsName;
        Random Rand = new Random();
        Form1 fuelnum;
        int TotalFuel;
        public void Setmainform(Form1 Fuel)
        {
            fuelnum = Fuel;
        }

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            PB.Left = 0;
            PB.Top = 0;
            Butt.Left = (PB.Width / 2) - (Butt.Width / 2);
            Butt.Top = PB.Height / 4;
            Start("S");
            SuccessFaillbl.Hide();
            SuccessFaillbl.Left = 0;
            SuccessFaillbl.Top = (Moonscape.Height / 2) - (SuccessFaillbl.Height / 2);
            CapsName = fuelnum.Cap;
            TotalFuel = fuelnum.TotalF;
            FuelBar.Maximum = TotalFuel;
            Pad.Top = Moonscape.Height - Pad.Height;
            Lander.Top = 0;
        }

        void Start(string H)
        {
            switch (H)
            {
                case "H":
                    Butt.Hide();
                    PB.Hide();
                    break;
                case "S":
                    Butt.Show();
                    PB.Show();
                    break;
                default:
                    break;
            }

        }

        void Run()
        {
            Pad.Left = GetRand(0, (Moonscape.Width - Pad.Width));
            Lander.Left = GetRand(0, (Moonscape.Width - Lander.Width));
        }

        int GetRand(int min, int max)
        {
            Random Rand = new Random();
            return Rand.Next(min, max);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (char)Keys.Left:
                    LeftB = true;
                    break;
                case (char)Keys.Right:
                    RightB = true;
                    break;
                default:
                    break;

            }

        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (char)Keys.Left:
                    LeftB = false;
                    break;
                case (char)Keys.Right:
                    RightB = false;
                    break;
                default:
                    break;

            }
        }

        private void Movetmr_Tick(object sender, EventArgs e)
        {
            if (Lander.Top + Lander.Height >= 335) Checkcol();
            else
            {
                LeftRight();
                Thrust();
            }
            if (LeftB) Lander.Left -= 2;

        }

        void Checkcol()
        {
            if (Lander.Left >= Pad.Width && Lander.Width <= Pad.Left + Pad.Width)
            {
                //Add Speed Value Check to see if too fast
                Won = true;
            }
            else
            { Won = false; }
            if (Won)
            {
                SuccessFaillbl.Text = "Congrats Captain " + CapsName + ", Mission Complete.";
            }
            else
            {
                SuccessFaillbl.Text = "Sorry Captain " + CapsName + ", Mission Failed.";
            }
            Movetmr.Stop();
            SuccessFaillbl.Show();
        }
        void LeftRight()
        {
            Lander.Left += (LeftB == true ? -2 : (RightB == true ? 2 : 0));
        }
        void Thrust()
        {
            if (TotalFuel - (TrackBar.Value * 10) <= 0)
            {
                Lander.Top += Gravity;
                TotalFuel = 0;
                FuelBar.Value = 0;
            }
            else
            {
                Lander.Top += Gravity - TrackBar.Value;
                TotalFuel -= (TrackBar.Value * 10);
                FuelBar.Value = TotalFuel;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Start("H");
            System.Threading.Thread.Sleep(500);
            Movetmr.Start();
            Run();
        }
    }
}
