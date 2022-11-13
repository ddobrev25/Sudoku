using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSolver_Click(object sender, EventArgs e)
        {
            FormManager.HideMainForm();
            FormManager.ShowSolverForm();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            FormManager.HideMainForm();
            FormManager.ShowGameForm();
        }
    }
}
