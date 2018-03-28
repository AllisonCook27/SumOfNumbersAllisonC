/*
 * Created by: Allison Cook
 * Created on: 28 March, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Sum of Numbers
 * This program calculates the sum of all the numbers up to a given number
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumOfNumbersAllisonC
{
    public partial class frmSumOfNumbers : Form
    {
        public frmSumOfNumbers()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program when clicked
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //variables 
            int sumCounter, sumNumber, sumAnswer;

            //set number to user input
            sumNumber = Convert.ToInt32(numNumber.Value);

            //clear list
            lstnumbers.Items.Clear();

            //set answer
            sumAnswer = 1;

            //looping through to calculate the answer and adding to list
            for (sumCounter = 1; sumCounter <= sumNumber; sumCounter++)
            {
                //addd to list
                lstnumbers.Items.Add(sumCounter);

                //get next answer
                sumAnswer = sumAnswer + sumCounter;

            }

            //convert to text
            lblAnswer.Text = "Sum of all numbers below " + Convert.ToString(sumNumber) + " = " + Convert.ToString(sumAnswer);
        }
    }
}
