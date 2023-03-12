using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaystationLogo
{
    public partial class Form1 : Form
    {

        Graphics graphics = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            //
            Draw();
        }

        private void DesenharTriangulo()
        {
            Point[] points = { new Point(0, 200), new Point(100, 0), new Point(200, 200) };
            //
            int squareSize = 232;
            float scaleX = (float)squareSize / (float)points[2].X;
            float scaleY = (float)squareSize / (float)points[0].Y;
            //
            Point[] scaledPoints = new Point[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                scaledPoints[i] = new Point((int)(points[i].X * scaleX), (int)(points[i].Y * scaleY));
            }
            //
            int deltaX = 392;
            int deltaY = 410;
            //
            Point[] translatedPoints = new Point[scaledPoints.Length];
            for (int i = 0; i < scaledPoints.Length; i++)
            {
                translatedPoints[i] = new Point(scaledPoints[i].X + deltaX, scaledPoints[i].Y + deltaY);
            }
            //
            graphics.DrawPolygon(new Pen(new SolidBrush(Color.Green), 30), translatedPoints);
        }

        private void DesenharCirculo()
        {
            int size = 250;
            int xCenter = 809;
            int y = (this.Height / 2) - ((size / 2) + 8);
            Rectangle rectangle = new Rectangle((xCenter - (size / 2)), y, size, size);
            graphics.DrawEllipse(new Pen(new SolidBrush(Color.Red), 30), rectangle);
        }

        private void DrawCross()
        {
            int x = 983;
            int y = 391;
            int size = 252;
            graphics.DrawLine(new Pen(new SolidBrush(Color.Blue), 30), x, y, (x + size), (y + size));
            graphics.DrawLine(new Pen(new SolidBrush(Color.Blue), 30), x, y + size, x + size, y);
        }

        private void DesenharQuadrado()
        {
            int size = 245;
            int xCenter = 1413;
            int y = (this.Height / 2) - ((size / 2) + 8);
            Rectangle rectangle = new Rectangle((xCenter - (size / 2)), y, size, size);
            graphics.DrawRectangle(new Pen(new SolidBrush(Color.DeepPink), 30), rectangle);
        }

        private void Draw()
        {
            DesenharTriangulo();
            DesenharCirculo();
            DrawCross();
            DesenharQuadrado();
            //
            //int x = 960;
            //int y = 517;
            //y -= 139;
            ////graphics.DrawLine(new Pen(new SolidBrush(Color.Red), 2), x, this.Height, x, 0);
            ////graphics.DrawLine(new Pen(new SolidBrush(Color.Red), 2), 0, y, this.Width, y);
            //for (int i = 0; i < 3; i++)
            //{
            //    //graphics.DrawLine(new Pen(new SolidBrush(Color.Red), 2), x, this.Height, x, 0);//V
            //    graphics.DrawLine(new Pen(new SolidBrush(Color.Red), 2), 0, y, this.Width, y);//H
            //    y += 139;
            //}
            //
            //int x = 960;
            //int y = 517;
            //x -= 600;
            //for (int i = 0; i < 5; i++)
            //{
            //    graphics.DrawLine(new Pen(new SolidBrush(Color.Red), 2), x, this.Height, x, 0);//V
            //    x += 300;
            //}
        }
    }
}
