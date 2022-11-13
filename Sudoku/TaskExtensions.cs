using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public static class TaskExtensions
    {
        public static async void Await(this Task task)
        {
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
