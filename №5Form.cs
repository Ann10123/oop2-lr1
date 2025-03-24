using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMegaApp
{
    public partial class Form1 : Form
    {
        delegate void ActionDelegate();

        private Random _random = new Random();

        private bool isTransparencyActive = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeTransparency()
        {
            if (chkTransparency.Checked)
            {
                if (isTransparencyActive)
                {
                    this.Opacity = 1;
                    isTransparencyActive = false;
                }
                else
                {
                    this.Opacity = 0.5;
                    isTransparencyActive = true;
                }
            }
        }

        private Color GetRandomColor()
        {
            int red = _random.Next(0, 256);
            int green = _random.Next(0, 256);
            int blue = _random.Next(0, 256);
            return Color.FromArgb(red, green, blue);
        }

        private void ChangeBackgroundColor()
        {
            if (chkBackgroundColor.Checked)
            {
                this.BackColor = GetRandomColor();
            }
        }

        private void ShowHelloWorldMessage()
        {
            if (chkHelloWorld.Checked)
            {
                MessageBox.Show("Hello World!");
            }
        }

        private void btnSetOfActions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка!");
            if (chkTransparency.Checked)
                ChangeTransparency();
            if (chkBackgroundColor.Checked)
                ChangeBackgroundColor();
            if (chkHelloWorld.Checked)
                ShowHelloWorldMessage();
        }

        private void btnTransparency_Click(object sender, EventArgs e)
        {
            ChangeTransparency();
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            ChangeBackgroundColor();
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            ShowHelloWorldMessage();
        }
    }
}
