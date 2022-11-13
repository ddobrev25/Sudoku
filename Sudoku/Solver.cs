using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public class Solver
    {
        private Visualizer v;
        private readonly Random r = new Random();
        public static int[,] PlayingField { get; private set; } = new int[9, 9];
        private static List<string> lockedPositions = new List<string>();
        //Groups of big squares
        public Solver(Visualizer visualizer)
        {
            v = visualizer;
        }
        public Solver()
        {
        }
        public static void SetPlayingFieldNumber(int num, int y, int x)
        {
            PlayingField[y, x] = num;
        }
        public static void InvalidatePlayingFieldNumber(int y, int x)
        {
            PlayingField[y, x] = 0;
            UnlockPosition(y, x);
        }
        public static void Restart()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    PlayingField[i, j] = 0;
                }
            }
            lockedPositions.Clear();
        }
        public static void LockPosition(int y, int x)
        {
            lockedPositions.Add(y.ToString() + x.ToString());
        }
        public static void UnlockPosition(int y, int x)
        {
            foreach(string lockedPosition in lockedPositions.ToList())
            {
                if (lockedPosition == y.ToString() + x.ToString())
                    lockedPositions.Remove(lockedPosition);
            }
        }
        public void Solve(CancellationToken token)
        {
            string furthestPos = GetFurthestPos();
            if (furthestPos != "")
            {
                int y = int.Parse(furthestPos.Substring(0, 1));
                int x = int.Parse(furthestPos.Substring(1));
                while (PlayingField[y, x] == 0)
                {
                    if (token.IsCancellationRequested)
                    {
                        RefreshPlayingField();
                        return;
                    }
                    TrySolve();
                }
            }
        }
        public int[,] GetSolvedBoard()
        {
            string furthestPos = GetFurthestPos();
            if (furthestPos != "")
            {
                int y = int.Parse(furthestPos.Substring(0, 1));
                int x = int.Parse(furthestPos.Substring(1));
                while (PlayingField[y, x] == 0)
                {
                    TrySolve();
                }
                return PlayingField;
            }
            throw new Exception();
        }
        private void TrySolve()
        {
            RefreshPlayingField();
            //v.ClearPlayingField();
            string furthestPos = GetFurthestPos();
            List<int> numbers = new List<int>();
            //Goes through the whole array and tries to fill each square with a correct number
            for (int y = 0; y <= 8; y++)
            {
                for (int x = 0; x <= 8; x++)
                {
                    if (PlayingField[y, x] != 0)
                    {
                        continue;
                    }
                    numbers.Clear();
                    for (int i = 1; i <= 9; i++)
                        numbers.Add(i);
                    for (int i = 9; i >= 0; i--)
                    {
                        int randn = r.Next(0, i);
                        int num = numbers[randn];
                        if (Rules.IsNumberCorrect(num, y, x))
                        {
                            PlayingField[y, x] = num;
                            //v.DrawNumber(num, y, x);
                            int yfp = int.Parse(furthestPos.Substring(0, 1));
                            int xfp = int.Parse(furthestPos.Substring(1));
                            if (PlayingField[yfp, xfp] != 0)
                            {
                                
                                v?.DrawPlayingField(PlayingField);
                                LockAllPositions();
                                return;
                                //ShowNumbers(35);
                                //FileOperation.SaveField(PlayingField);
                            }
                            break;
                        }
                        else
                        {
                            numbers.Remove(num);
                            if (numbers.Count == 0)
                                return;
                        }
                    }
                }
            }
        }
        public void UnlockAllPositions()
        {
            lockedPositions.Clear();
        }
        public void RefreshPlayingField()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!IsLocked(i, j))
                        PlayingField[i, j] = 0;
                }
            }
        }
        private bool IsLocked(int y, int x)
        {
            string pos = y.ToString() + x.ToString();
            foreach(string lockedPosition in lockedPositions)
            {
                if (pos == lockedPosition)
                    return true;
            }
            return false;
        }
        private void LockAllPositions()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!IsLocked(i, j))
                        LockPosition(i, j);
                }
            }
        }
        private string GetFurthestPos()
        {
            for (int y = 8; y >= 0; y--)
            {
                for (int x = 8; x >= 0; x--)
                {
                    if (PlayingField[y, x] == 0)
                        return y.ToString() + x.ToString();
                }
            }
            return "";
        }
    }
}
