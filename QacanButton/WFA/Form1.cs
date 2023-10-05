using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form1 : Form
    {
        private readonly Random _random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            ChangeButtonPosition();
            ChangeBackgroundColor();
        }

        private void ChangeButtonPosition()
        {
            int x = _random.Next(0, 450);
            int y = _random.Next(0, 450);
            button1.Location = new Point(x, y);
        }

        private void ChangeBackgroundColor()
        {
            Color newColor = GenerateRandomColor();
            BackColor = newColor;
        }

        private Color GenerateRandomColor()
        {
            int r = _random.Next(0, 255);
            int g = _random.Next(0, 255);
            int b = _random.Next(0, 255);

            return Color.FromArgb(r, g, b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
