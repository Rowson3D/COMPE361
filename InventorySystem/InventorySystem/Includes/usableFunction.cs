using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    class usableFunction
    {
        public void clearTxt(Control container)
        {
            try
            {
                //'for each txt as control in this(object).control
                foreach (Control txt in container.Controls)
                {
                    //conditioning the txt as control by getting it's type.
                    //the type of txt as control must be textbox.
                    if (txt is TextBox)
                    {
                        //if the object(textbox) is present. The result is, the textbox will be cleared.
                        txt.Text = "";
                    }
                    if (txt is RichTextBox)
                    {
                        txt.Text = "";
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //initialize the validating method
        static Regex Valid_Name = StringOnly();
        static Regex Valid_Contact = NumbersOnly();
        static Regex Valid_Password = ValidPassword();
        static Regex Valid_Email = Email_Address();

        // Get the year from the selected date in comboBox and remove the first two characters
        // name the method GetYear
        public string getYear(ComboBox cb)
        {
            string year = cb.SelectedItem.ToString();
            year = year.Remove(0, 2);
            return year;
        }

        // Get the last four digits of a number in a textbox
        public string getLastFourDigits(string text)
        {
            string lastFourDigits = "";
            if (text.Length >= 4)
            {
                lastFourDigits = text.Substring(text.Length - 4);
            }
            return lastFourDigits;
        }

        // Method to format a 10 digit number into a phone number format
        public string FormatPhoneNumber(string phoneNumber)
        {
            try
            {
                // Remove any characters that are not digits
                string number = new String(phoneNumber.Where(Char.IsDigit).ToArray());

                // If number is less than 10 digits assume it is a bad number
                if (number.Length != 10) return null;

                // If number is 10 digits assume it is good
                return "(" + number.Substring(0, 3) + ") " + number.Substring(3, 3) + "-" + number.Substring(6);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // Create a function that selects a random shipping company between UPS, FedEx, and USPS
        public string GetShipper()
        {
            try
            {
                // Create a list of strings to hold the shipping companies
                List<string> shippers = new List<string>();

                // Add the shipping companies to the list
                shippers.Add("UPS");
                shippers.Add("FedEx");
                shippers.Add("USPS");

                // Select a random company from the list
                Random rnd = new Random();
                int index = rnd.Next(shippers.Count);
                string shipper = shippers[index];

                // Return the selected company
                return shipper;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // Create a function that gets the current date called GetDate
        public string GetDate()
        {
            try
            {
                // Create a DateTime object and get the current date
                DateTime now = DateTime.Now;

                // Return the current date in the format of mm/dd/yyyy
                return now.ToString("MM/dd/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // Create a function that randomly generates a number on the following criteria:
        // The order number starts with an A
        // The order number is 10 numbers long
        // The order number is unique
        // The order number is not already in the database
        public string GenerateOrderNumber()
        {
            try
            {
                // Create a string array of characters that can be used in the order number
                string[] characters = { "A" };

                // Create a string array of numbers that can be used in the order number
                string[] numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

                // Create a random object
                Random random = new Random();

                // Create a string to store the order number
                string orderNumber = "";

                // Create a loop to generate the order number
                for (int i = 0; i < 10; i++)
                {
                    // If the first character is an A
                    if (i == 0)
                    {
                        // Select a random character from the characters array
                        orderNumber += characters[random.Next(0, characters.Length)];
                    }
                    // If the first character is not an A
                    else
                    {
                        // Select a random character or number from the numbers array
                        orderNumber += numbers[random.Next(0, numbers.Length)];
                    }
                }

                // Return the order number
                return orderNumber;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // Method that if 0 then name is "Customer"
        public string GetName(string name)
        {
            try
            {
                if (name == "0")
                {
                    return "Customer";
                }
                else
                {
                    return name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //Method for validating email address
        private static Regex Email_Address()
        {
            string Email_Pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(Email_Pattern, RegexOptions.IgnoreCase);
        }
        //Method for string validation only
        private static Regex StringOnly()
        {
            string StringAndNumber_Pattern = "^[a-zA-Z]";

            return new Regex(StringAndNumber_Pattern, RegexOptions.IgnoreCase);
        }
        //Method for numbers validation only
        private static Regex NumbersOnly()
        {
            string StringAndNumber_Pattern = "^[0-9]*$";

            return new Regex(StringAndNumber_Pattern, RegexOptions.IgnoreCase);
        }
        //Method for password validation only
        private static Regex ValidPassword()
        {
            string Password_Pattern = "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$";

            return new Regex(Password_Pattern, RegexOptions.IgnoreCase);
        }

        public void ResponsiveDtg(DataGridView dtg)
        {
            dtg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        // Create a function called ClearTextBoxes()
        // that loops through all controls on form
        // and if it finds a TextBox, it clears the text in the control.
        public void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }
            }
            // foreach dropdownlist in control set text to String.Empty
            foreach (Control c in control.Controls)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = "";
                }
            }
        }
    }
}
