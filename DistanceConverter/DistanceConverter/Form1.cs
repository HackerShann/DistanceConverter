using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceConverter
{
    public partial class DistanceConverter : Form
    {
        public DistanceConverter()
        {
            InitializeComponent();
        }

        private void From_Enter(object sender, EventArgs e)
        {
            // You can leave this empty if no specific action is required on entering the GroupBox
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // You can leave this empty if no specific action is required on clicking label2
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            double distance, convertedDistance = 0;

            // Validate that the distance is a number
            if (double.TryParse(convert_enter.Text, out distance))
            {
                // Validate that a 'From' item is selected
                if (ListBox_From.SelectedIndex != -1)
                {
                    // Validate that a 'To' item is selected
                    if (ListBox_To.SelectedIndex != -1)
                    {
                        // Check if the units are the same in both 'From' and 'To' lists
                        if (ListBox_From.SelectedIndex == ListBox_To.SelectedIndex)
                        {
                            MessageBox.Show("Must select different distance units");
                        }
                        else
                        {
                            // Conversion logic based on selected indices
                            switch (ListBox_From.SelectedIndex)
                            {
                                case 0: // Inches
                                    if (ListBox_To.SelectedIndex == 1) // Inches to Feet
                                        convertedDistance = distance / 12;
                                    else if (ListBox_To.SelectedIndex == 2) // Inches to Yards
                                        convertedDistance = distance / 36;
                                    break;

                                case 1: // Feet
                                    if (ListBox_To.SelectedIndex == 0) // Feet to Inches
                                        convertedDistance = distance * 12;
                                    else if (ListBox_To.SelectedIndex == 2) // Feet to Yards
                                        convertedDistance = distance / 3;
                                    break;

                                case 2: // Yards
                                    if (ListBox_To.SelectedIndex == 0) // Yards to Inches
                                        convertedDistance = distance * 36;
                                    else if (ListBox_To.SelectedIndex == 1) // Yards to Feet
                                        convertedDistance = distance * 3;
                                    break;
                            }

                            // Display the converted distance
                            convert_answer.Text = convertedDistance.ToString("F2");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Must select item: To");
                    }
                }
                else
                {
                    MessageBox.Show("Must select item: From");
                }
            }
            else
            {
                MessageBox.Show("Please enter a number for the distance");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // Closes the form
            this.Close();
        }

        private void ListBox_To_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}