using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House
{
    public partial class Form1 : Form
    {
        List<House> houses;
        public Form1()
        {
            InitializeComponent();
            houses = new List<House>();
        }

        private void pboxBackColor_Click(object sender, EventArgs e)
        {
            colorBackDia.Color = pboxBackColor.BackColor;
            colorBackDia.ShowDialog();
            pboxBackColor.BackColor = colorBackDia.Color;
        }

        private void pboxForeColor_Click(object sender, EventArgs e)
        {
            colorBackDia.Color = pboxForeColor.BackColor;
            colorBackDia.ShowDialog();
            pboxForeColor.BackColor = colorBackDia.Color;
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            House house = new House(pboxForeColor.BackColor, pboxBackColor.BackColor, (int)numericVertical.Value, (int)numericHorizontal.Value, (int)numericHeight.Value);
            house.Location = new Point(random.Next(0, pictureBox1.Width), random.Next(0, pictureBox1.Height));
            houses.Add(house);
            pictureBox1.Refresh();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var house in houses)
            {
                house.Draw(e.Graphics);
            }
        }
    }
}
