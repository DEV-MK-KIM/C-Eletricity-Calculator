using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerData
{
    /*
     * This "Validator" Class made by Jolanta Warpechowska-Gruca 
     * It was modified and refereneced by M.K. Kim
     * 
     */
    class Validator
    {
        public static bool IsPresent(TextBox textbox)
        {
            if (textbox.Text.Equals(""))
            {
                MessageBox.Show(textbox.Tag + " has to be provided",
                    "Input Error");
                textbox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsInteger(TextBox textbox)
        {
            
            int parsedValue;
            if (!Int32.TryParse(textbox.Text, out parsedValue))
            {
                MessageBox.Show(textbox.Tag + " has to be a whole number",
                    "Input Error");
                textbox.SelectAll();
                textbox.Focus();
                return false;

            }
            return true;
        }

      
        public static bool IsNonNegativeInteger(TextBox textbox)
        {
            int parsedValue = Int32.Parse(textbox.Text);
            if (parsedValue < 0)
            {
                MessageBox.Show(textbox.Tag + " has to be positive or zero",
                    "Input Error");
                textbox.SelectAll();
                textbox.Focus();
                return false;
            }
            return true;
        }
    }
}
