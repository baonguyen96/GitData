using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitData.Utilities
{
    public static class Utilities
    {
        public static void ShowErrorMessage()
        {
            MessageBox.Show("An error has occured. Check your inputs and retry.", "Error");
        }

        public static void ShowErrorMessage(Exception e)
        {
            MessageBox.Show($"An error has occured. Check your inputs and retry.\r\n{e.ToString()}", "Error");
        }
    }
}
