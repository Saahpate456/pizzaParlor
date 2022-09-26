using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaParlor
{
    public partial class Form1 : Form
    {
        double sliceCost = 3.14;
        double sliceAmount;
        double subtotal;
        double total;
        double tax = 0.13;
        double taxAmount;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sliceOuput_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //slices = Convert.ToDouble(hoursInput.Text);

            subtotal = sliceAmount * sliceCost;
            taxAmount = sliceCost * tax;
            total = taxAmount + sliceCost;

            subOutput.Text = $"";
        }
    }
}
