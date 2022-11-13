using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class SolverForm
    {
        private CancellationTokenSource solveTaskTokenSource = null;
        private bool interactWithPanel = true;
        private async Task Solve()
        {
            buttonRefresh.Enabled = false;
            buttonSolve.Enabled = false;
            interactWithPanel = false;
            solveTaskTokenSource = new CancellationTokenSource();
            CancellationToken token = solveTaskTokenSource.Token;
            Visualizer v = new Visualizer(panel1);
            Solver solver = new Solver(v);
            await Task.Run(() => solver.Solve(token), token);
            buttonRefresh.Enabled = true;
            buttonSolve.Enabled = true;
            interactWithPanel = true;
        }
        private void Interact(MouseEventArgs e)
        {
            if (interactWithPanel)
            {
                UserInteraction ui = new UserInteraction(e);
                string pos = ui.GetPos();
                if (pos != "")
                {
                    int y = int.Parse(pos.Substring(0, 1));
                    int x = int.Parse(pos.Substring(1));
                    if (!radioButtonDeleteNumber.Checked)
                    {
                        if (Solver.PlayingField[y, x] == 0)
                        {
                            int num = GetNum();
                            if (num == 0)
                                return;
                            if (Rules.IsNumberCorrect(num, y, x))
                            {
                                Solver.SetPlayingFieldNumber(num, y, x);
                                Solver.LockPosition(y, x);
                                Visualizer v = new Visualizer(panel1);
                                v.DrawNumber(num, y, x, Brushes.Black);
                            }
                            else
                            {
                                MessageBox.Show("Invalid position");
                            }
                        }
                        else
                        {
                            MessageBox.Show("square is taken already!");
                        }
                    }
                    else if (radioButtonDeleteNumber.Checked)
                    {
                        if (Solver.PlayingField[y, x] != 0)
                        {
                            Solver.InvalidatePlayingFieldNumber(y, x);
                            Solver.UnlockPosition(y, x);
                            Visualizer v = new Visualizer(panel1);
                            v.DeleteNumber(y, x);
                        }
                    }
                }
            }
        }
        private void Restart()
        {
            Solver.Restart();
            Visualizer v = new Visualizer(panel1);
            v.ClearPlayingField();
        }
        private void Cancel()
        {
            solveTaskTokenSource.Cancel();
            Solver s = new Solver();
            s.RefreshPlayingField();
        }
        private void MainMenu()
        {
            FormManager.HideSolverForm();
            FormManager.ShowMainForm();
            Solver.Restart();
        }

        private int GetNum()
        {
            if (radioButton1.Checked)
                return 1;
            else if (radioButton2.Checked)
                return 2;
            else if (radioButton3.Checked)
                return 3;
            else if (radioButton4.Checked)
                return 4;
            else if (radioButton5.Checked)
                return 5;
            else if (radioButton6.Checked)
                return 6;
            else if (radioButton7.Checked)
                return 7;
            else if (radioButton8.Checked)
                return 8;
            else if (radioButton9.Checked)
                return 9;
            return 0;
        }
    }
}
