using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //declare variables for user input/output
            string fromMeasurement, toMeasurement;
            double distanceConverted;

            try //user has to input a numeric value into input
            {
                //declare the input to distance converted
                distanceConverted = double.Parse(distanceConvertInput.Text);
            
            

                //validation for the from box
                if (fromListBox.SelectedIndex != -1)
                {
                    //validates user click
                    fromMeasurement = fromListBox.SelectedItem.ToString();

                    //validation for the to box
                    if (toListBox.SelectedIndex != -1)
                    {
                        //validates user click
                        toMeasurement = toListBox.SelectedItem.ToString();

                        //Calculate the conversion from inches, or feet, or yards
                        switch (fromMeasurement)
                        {
                            case "Inches":
                                switch (toMeasurement)
                                {
                                    case "Inches":
                                        //declare variable local to inside switch
                                        double convertedTotal = distanceConverted;
                                        convertedDistanceOutput.Text = convertedTotal.ToString();
                                        break;
                                    case "Feet":
                                        //declare second variable local to switch
                                        double convertTotal = distanceConverted / 12;
                                        convertedDistanceOutput.Text = convertTotal.ToString();
                                        break;
                                    case "Yards":
                                        //declare third variable local to switch
                                        double convertsTotal = distanceConverted / 36;
                                        convertedDistanceOutput.Text = convertsTotal.ToString();
                                        break;
                                }
                                break;
                            case "Feet":
                                switch (toMeasurement)
                                {
                                    case "Inches":
                                        //1st variable
                                        double convertedTotal = distanceConverted * 12;
                                        convertedDistanceOutput.Text = convertedTotal.ToString();
                                        break;
                                    case "Feet":
                                        //2nd variable
                                        double convertTotal = distanceConverted;
                                        convertedDistanceOutput.Text = convertTotal.ToString();
                                        break;
                                    case "Yards":
                                        //3rd variable
                                        double convertsTotal = distanceConverted / 3;
                                        convertedDistanceOutput.Text = convertsTotal.ToString();
                                        break;
                                }
                                break;
                            case "Yards":
                                switch (toMeasurement)
                                {
                                    case "Inches":
                                        //1st variable
                                        double convertedTotal = distanceConverted * 36;
                                        convertedDistanceOutput.Text = convertedTotal.ToString();
                                        break;
                                    case "Feet":
                                        //2nd variable
                                        double convertTotal = distanceConverted * 3;
                                        convertedDistanceOutput.Text = convertTotal.ToString();
                                        break;
                                    case "Yards":
                                        //3rd variable
                                        double convertsTotal = distanceConverted;
                                        convertedDistanceOutput.Text = convertsTotal.ToString();
                                        break;
                                }
                                break;

                        }
                    }
                    else
                    {
                        //if there isn't any selection for to
                        MessageBox.Show("Please select a conversion 'to' distance.");
                    }
                }
                else
                {
                    //if there isn't any selction for from
                    MessageBox.Show("Please select a conversion 'from' distance.");
                }
            }
            catch //no input or invalid input such as letters
            {
                MessageBox.Show("Invalid input. Enter a numeric number please.");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }
    }

}


