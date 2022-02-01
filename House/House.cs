using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace House
{
    class House
    {
        public Color ForeColor { get; set; }
        public Color BackColor { get; set; }
        public int VerticalWindowsCount { get; set; }
        public int HorizontalWindowsCount { get; set; }
        public int Height { get; set; }
        public Point Location { get; set; }

        //Prázdny konstruktor, kdyby nikdo nenastavil hodnoty;
        public House()
        {
            ForeColor = Color.Black;
            BackColor = Color.Yellow;
            VerticalWindowsCount = 3;
            Height = 150;
            Location = new Point();
        }

        public House(Color foreColor, Color backColor, int verticalWindowsCount, int horizontalWindowsCount, int height)
        {
            ForeColor = foreColor;
            BackColor = backColor;
            VerticalWindowsCount = verticalWindowsCount;
            HorizontalWindowsCount = horizontalWindowsCount;
            Height = height;
        }
        public void Draw(Graphics graphics)
        {
            float window = Height / (VerticalWindowsCount * 2f + 3f);
            float width = HorizontalWindowsCount * 2f + 1; 
            Brush brushBack = new SolidBrush(BackColor);
            Brush brushFore = new SolidBrush(ForeColor);
            graphics.FillRectangle(brushBack, Location.X, Location.Y, width, Height);
            graphics.FillRectangle(brushFore, Location.X + (width - window) / 2, Location.Y, window, window * 2);
        }
    }
}
