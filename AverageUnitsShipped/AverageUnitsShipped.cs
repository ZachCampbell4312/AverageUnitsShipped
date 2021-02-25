// Author: Zach Campbell
// Date: 01/21/2021
// Description: This application will allow user inputs and save them in a textbox for up to 7 entries, then will calculate the average of the numbers and  
// display them in an output textbox.




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageUnitsShipped
{
    public partial class AverageUnitsShipped : Form
    {   
        // Class-level variable declarations
        int currentDay = 1;
        int currentTotal = 0;


        public AverageUnitsShipped()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AverageUnitsShipped_Load(object sender, EventArgs e)
        {

        }

        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Declare constants and variables.
            const int MinimumUnits = 0;
            const int MaximumUnits = 5000;
            const int MaximumDays = 7;
            int lastEntry;



            // Validate that the number entered is a whole number.
            if (int.TryParse(textboxEntryNumber.Text, out lastEntry))
            {
                // Validate that the number entered is  between 0 and 5000.
                if (lastEntry >= MinimumUnits && lastEntry <= MaximumUnits)
                {
                    // If the entry is valid.
                    // Add the newest entry to the list of past entries.
                    textBoxPastEntries.Text += lastEntry + "\r\n";
                    // Increment currentTotal by the entry.
                    currentTotal += lastEntry;

                    // Increment the day by 1.
                    currentDay++;

                    // Clear the entry textbox.
                    textboxEntryNumber.Clear();

                    // If the day is > 7.
                    if (currentDay > MaximumDays)
                    {
                        // Determine the average.
                        double averageUnits;
                        averageUnits = (double)currentTotal / (double)MaximumDays;
                        // Output the results.
                        labelAverageOutput.Text = "Average per day: " + Math.Round(averageUnits, 2);
                        // Disable controls.
                        textboxEntryNumber.Enabled = false;
                        buttonEnter.Enabled = false;
                        // Set focus to the reset button.
                        buttonReset.Focus();


                    }
                    // If the day is <= 7.
                    else
                    {

                        // Display the current day.
                        labelDay.Text = "Day " + currentDay;
                        //Set focus to the new entry textbox.
                        textboxEntryNumber.Focus();
                    }

                }
                else
                {
                    // The value enteres is less than 0 or greater than 5000.
                    MessageBox.Show("Enter a value between " + MinimumUnits + " and " + MaximumUnits + ".", "Invalid Entry!");
                    textboxEntryNumber.SelectAll();
                    textboxEntryNumber.Focus();
                }
            }

            else
            {
                // The value entered is not an integer.
                MessageBox.Show("Entry must be a numeric value. ", "Invalid Entry!");
                textboxEntryNumber.SelectAll();
                textboxEntryNumber.Focus();

            }
        }           
        
       
        /// Resets the form for new data entry, including resetting the class variables and re-enabling controls.
        
        private void ButtonResetClick(object sender, EventArgs e)
        {
            // Clear the input and output fields.
            textboxEntryNumber.Clear();
            textBoxPastEntries.Clear();
            labelAverageOutput.Text = "";


            // Reset the global variables.
            currentDay = 1;
            currentTotal = 0;
            labelDay.Text = "Day " + currentDay;

            // Re-enable any controls that may be disabled.
            textboxEntryNumber.Enabled = true;
            buttonEnter.Enabled = true;

            // Set focus for easy data entry.
            textboxEntryNumber.Focus();
        }
        //This will close the application once the user clicks the "Exit" button.
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();                               

        }
    }
}
