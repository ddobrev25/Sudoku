using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public static class FormManager
    {
        public static MainForm MainForm { get; } = new MainForm();
        public static SolverForm SolverForm { get; } = new SolverForm();
        public static GameForm GameForm { get; private set; } = new GameForm();

        public static void ShowMainForm()
        {
            MainForm.Show();
        }
        public static void HideMainForm()
        {
            MainForm.Hide();
        }
        public static void ShowSolverForm()
        {
            SolverForm.Show();
        }
        public static void HideSolverForm()
        {
            SolverForm.Hide();
        }
        public static void ShowGameForm()
        {
            GameForm.Show();
            GameForm.DisplayNumbers();
        }
        public static void HideGameForm()
        {
            GameForm.Hide();
        }
    }
}
