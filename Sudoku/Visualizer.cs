using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Http.Headers;

namespace Sudoku
{
    public class Visualizer
    {
        private static Panel panel;
        private static Graphics g;
        private static readonly Pen pen = new Pen(Color.Black, 1);
        private static readonly Font font = new Font("Arial", 25);
        //Offsets to centralize numbers in squares
        private const float xOffset = 16.5f;
        private const float yOffset = 12.5f;
        public Visualizer(Panel aPanel)
        {
            panel = aPanel;
            g = panel.CreateGraphics();
        }
        public Visualizer(Panel aPanel, PaintEventArgs args)
        {
            panel = aPanel;
            g = args.Graphics;
        }
        public void CreateGrid()
        {
            float x = 3.2f;
            float y = 3.2f;
            float xSpace = panel.Width / 9;
            float ySpace = panel.Height / 9;
            //Draw horizontal lines
            for (int i = 0; i <= 9; i++)
            {
                if (i % 3 == 0)
                    pen.Width = 3;
                g.DrawLine(pen, x, y, x, panel.Height);
                x += xSpace;
                pen.Width = 1;
            }
            x = 3.2f;
            //Draw vertical lines
            for (int i = 0; i <= 9; i++)
            {
                if (i % 3 == 0)
                    pen.Width = 3;
                g.DrawLine(pen, x, y, panel.Width, y);
                y += ySpace;
                pen.Width = 1;
            }
        }
        public void DrawNumber(int n, int yPos, int xPos, Brush b)
        {
            //Divide lines equally
            float xSpace = panel.Width / 9;
            float ySpace = panel.Height / 9;
            g.DrawString(n.ToString(), font, b, xOffset + xPos * xSpace, yOffset + yPos * ySpace);
        }

        public void DeleteNumber(int yPos, int xPos)
        {
            //Divide lines equally
            float xSpace = panel.Width / 9;
            float ySpace = panel.Height / 9;
            Brush delBrush = new SolidBrush(Color.FromKnownColor(KnownColor.Control));
            //Fills a rectangle so it covers the number with a color same as background color
            g.FillRectangle(delBrush, xOffset + xPos * xSpace, yOffset + yPos * ySpace, 30f, 40f);
        }

        public void DrawPlayingField(int[,] board)
        {
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    if (board[i, j] != 0)
                        DrawNumber(board[i, j], i, j, Brushes.Black);
                }
            }
        }
        public void ClearPlayingField()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    DeleteNumber(i, j);
                }
            }
        }
    }
}
