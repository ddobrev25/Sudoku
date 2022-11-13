using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public class GameMechanism
    {
        private int[,] solvedBoard;
        public static int[,] TakenSquares { get; private set; }
        private Panel panel;
        public GameMechanism(Panel aPanel)
        {
            panel = aPanel;
        }
        public void ShowNumbers(int count)
        {
            Solver s = new Solver();
            solvedBoard = new int[9, 9];
            TakenSquares = new int[9, 9];
            for(int i = 0; i <= 8; i++)
            {
                for(int j = 0; j <= 8; j++)
                {
                    solvedBoard[i, j] = 0;
                    TakenSquares[i, j] = 0;
                }
            }
            solvedBoard = s.GetSolvedBoard();
            Visualizer v = new Visualizer(panel);
            Random r = new Random();
            //v.ClearPlayingField();
            int y2 = 0;
            int x2 = 0;
            int rand;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    TakenSquares[i, j] = 0;
                }
            }
            for (int i = 1; i <= count; i++)
            {
                rand = r.Next(1, 5);
                if (rand % 4 == 0)
                {
                    if (TakenSquares[y2, x2] == 0)
                    {
                        v.DrawNumber(solvedBoard[y2, x2], y2, x2, Brushes.Gray);
                        TakenSquares[y2, x2] = solvedBoard[y2, x2];
                        x2++;
                    }
                    else
                    {
                        i--;
                        x2++;
                    }
                }
                else
                {
                    i--;
                    x2++;
                }
                if (x2 > 8)
                {
                    y2++;
                    x2 = 0;
                }
                if (y2 > 8)
                {
                    x2 = 0;
                    y2 = 0;
                }
            }
        }
    }
}
