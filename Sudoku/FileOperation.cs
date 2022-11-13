using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Sudoku
{
    class FileOperation
    {
        public static void SaveField(int[,] field)
        {
            string f = "";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    f += $"{i}{j}:{field[i, j]},";
                }
            }
            using (StreamWriter sw = File.AppendText("sudoku.txt"))
            {
                sw.WriteLine(f.Substring(0, f.Length - 1));
            }
        }
    }
}
