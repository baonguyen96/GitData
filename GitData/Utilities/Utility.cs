using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitData.Utilities
{
    public class Utility
    {
        public static void ShowErrorMessage()
        {
            ShowErrorMessage("An error has occured. Check your inputs and retry.");
        }
        
        
        public static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error");
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
