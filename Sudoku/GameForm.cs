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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Visualizer v = new Visualizer(panel1, e);
            v.CreateGrid();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            FormManager.HideGameForm();
            FormManager.ShowMainForm();
            Solver.Restart();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Interact(e);
        }

        private void Interact(MouseEventArgs e)
        {
            UserInteraction ui = new UserInteraction(e);
            string pos = ui.GetPos();
            if (pos != "")
            {
                int y = int.Parse(pos.Substring(0, 1));
                int x = int.Parse(pos.Substring(1));
                if (!radioButtonDeleteNumber.Checked)
                {
                    int num = GetNum();
                    if (num == Solver.PlayingField[y, x])
                    {
                        if (num == 0)
                            return;
                        Visualizer v = new Visualizer(panel1);
                        v.DrawNumber(num, y, x, Brushes.Black);
                    }
                    else
                    {
                        MessageBox.Show("Wrong position");
                    }
                }
                else if (radioButtonDeleteNumber.Checked)
                {
                    if (GameMechanism.TakenSquares[y, x] == 0)
                    {
                        Visualizer v = new Visualizer(panel1);
                        v.DeleteNumber(y, x);
                    }
                }
            }
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

        private void GameForm_Shown(object sender, EventArgs e)
        {
        }

        public void DisplayNumbers()
        {
            GameMechanism gm = new GameMechanism(panel1);
            gm.ShowNumbers(30);
        }
    }
}
