using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N01421653_Project
{
    public static class Validator
    {
        private static string title = "Entry Error";

        /// <summary>
        /// The title that will appear in dialog boxes.
        /// </summary>
        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        /// <summary>
        /// Checks whether the user entered data into a text box.
        /// </summary>
        /// <param name="textBox">The text box control to be validated.</param>
        /// <returns>True if the user has entered data.</returns>
        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    MessageBox.Show(textBox.Tag + " is a required field.", Title);
                    textBox.Focus();
                    return false;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(comboBox.Tag + " is a required field.", "Entry Error");
                    comboBox.Focus();
                    return false;
                }
            }
            return true;
        }

        public static bool IsInt32(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }

    }
}
