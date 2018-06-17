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

        public static String FormatKeyValuePair(string key, string value)
        {
            return String.Format($"{key}{":".PadRight(50, ' ')}{value}\r\n");
        }

        public static String ConvertStringArrayToString(string[] strings)
        {
            string s = "";

            foreach(string str in strings)
            {
                s += str;
                s += (str == strings[strings.Length - 1] ? "" : ", ");
            }

            return s;
        }
        
    }
}
