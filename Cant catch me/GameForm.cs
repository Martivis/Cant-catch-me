using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cant_catch_me
{
    public partial class GameForm : Form
    {
        private readonly byte _titleBarSize;
        private Random _random;
        private Difficulty _difficulty;

        public GameForm(Difficulty difficulty)
        {
            _difficulty = difficulty;
            _random = new Random();

            InitializeComponent();
            InitializeDifficulty();

            _titleBarSize = (byte)(RectangleToScreen(ClientRectangle).Top - Top);
        }
        private void InitializeDifficulty()
        {
            if (_difficulty == Difficulty.Easy)
            {
                _runningButton.Click += new System.EventHandler(this.RunningButton_ClickEasy);
                _runningButton.MouseMove += new System.Windows.Forms.MouseEventHandler(RunningButton_MouseMove);
            }
            else
            {
                _runningButton.Click += new System.EventHandler(this.RunningButton_ClickNormal);
                _runningButton.MouseEnter += new System.EventHandler(RunningButton_MouseEnter);
                WindowState = FormWindowState.Maximized;
            }
        }
        private async void DoCountdown()
        {
            for (int i = 5; i >= 0; i--)
            {
                CountdownLabel.Text = Convert.ToString(i);
                await Task.Delay(1000);
            }
        }
        private void MoveButton()
        {
            _runningButton.Left = _random.Next(Width - _runningButton.Right);
            _runningButton.Top = _random.Next(Height - _runningButton.Bottom - _titleBarSize);
        }
        private void RunningButton_ClickEasy(object sender, EventArgs e)
        {
            Close();
        }
        private void RunningButton_ClickNormal(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/s /t 5");
            _runningButton.Visible = false;
            DoCountdown();
        }
        private void RunningButton_MouseMove(object sender, MouseEventArgs e)
        {
            MoveButton();
        }

        private void RunningButton_MouseEnter(object sender, EventArgs e)
        {
            MoveButton();
        }
    }
}
