using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePayroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //define variables 
            double hours, rate;
            double grossPay, Tax, securityFee, netPay;

            // get the inputs
            hours = Convert.ToDouble(txtHours.Text);
            rate = Convert.ToDouble(txtRate.Text);

            // do some calculations
            grossPay = hours * rate;
            Tax = grossPay * 5 / 100;
            securityFee = grossPay * 0.5/100;
            netPay = grossPay - (Tax + securityFee);

            //display output
            txtGross.Text = grossPay.ToString("c");
            txtTax.Text = Tax.ToString("c");
            txtSecurity.Text = securityFee.ToString("c");
            txtNet.Text = netPay.ToString("c");
               
        }
    }
}
