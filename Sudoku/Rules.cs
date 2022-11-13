using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public static class Rules
    {
        private static string[,] bigSquares =
            {
                {"00", "01", "02", "10", "11", "12", "20", "21", "22" },
                {"03", "04", "05", "13", "14", "15", "23", "24", "25" },
                {"06", "07", "08", "16", "17", "18", "26", "27", "28" },
                {"30", "31", "32", "40", "41", "42", "50", "51", "52" },
                {"33", "34", "35", "43", "44", "45", "53", "54", "55" },
                {"36", "37", "38", "46", "47", "48", "56", "57", "58" },
                {"60", "61", "62", "70", "71", "72", "80", "81", "82" },
                {"63", "64", "65", "73", "74", "75", "83", "84", "85" },
                {"66", "67", "68", "76", "77", "78", "86", "87", "88" },
            };
        public static bool IsNumberCorrect(int num, int y, int x)
        {
            if ((num > 9 || num < 1) && (y > 8 || y < 0) && (x > 8 || x < 0))
                throw new Exception();
            //Check rows
            for (int i = 0; i < 9; i++)
            {
                if (Solver.PlayingField[y, i] == num)
                    return false;
            }
            //Check columns
            for (int i = 0; i < 9; i++)
            {
                if (Solver.PlayingField[i, x] == num)
                    return false;
            }
            if (!CheckBigSquare(num, y, x))
                return false;
            return true;
        }
        //Converts the playing field location to the bigSquare location
        private static string FindPos(int y, int x)
        {
            for (int indexBigSquare = 0; indexBigSquare < 9; indexBigSquare++)
            {
                for (int indexPos = 0; indexPos < 9; indexPos++)
                {
                    if ($"{y.ToString() + x.ToString()}" == bigSquares[indexBigSquare, indexPos])
                    {
                        return $"{indexBigSquare.ToString() + indexPos.ToString()}";
                    }
                }
            }
            throw new Exception();
        }
        //Check big square
        private static bool CheckBigSquare(int num, int y, int x)
        {
            string pos = FindPos(y, x);
            int indexBigSquare = Convert.ToInt32(pos.Substring(0, 1));
            int indexPos = Convert.ToInt32(pos.Substring(1));
            for (int i = 0; i < 9; i++)
            {
                if (y == Convert.ToInt32(bigSquares[indexBigSquare, i].Substring(0, 1)) && x == Convert.ToInt32(bigSquares[indexBigSquare, i].Substring(1)))
                    continue;
                if (num == Solver.PlayingField[Convert.ToInt32(bigSquares[indexBigSquare, i].Substring(0, 1)), Convert.ToInt32(bigSquares[indexBigSquare, i].Substring(1))])
                    return false;
            }
            return true;
        }
    }
}
