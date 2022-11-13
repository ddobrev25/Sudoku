using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class SolverForm : Form
    {
        public SolverForm()
        {
            InitializeComponent();
        }
        private void buttonSolve_Click(object sender, EventArgs e)
        {
            Solve().Await();
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Interact(e);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu();
        }

        private void SolverForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Visualizer v = new Visualizer(panel1, e);
            v.CreateGrid();
        }
    }
}
