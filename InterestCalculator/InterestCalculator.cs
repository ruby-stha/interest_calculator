using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class InterestCalculator : Form
    {
        public InterestCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculateInterest_Click(object sender, EventArgs e)
        {
            SimpleInterest si=new SimpleInterest();
            si.Principle = double.Parse(txtPrinciple.Text);
            si.Rate = double.Parse(txtRate.Text);
            si.Time = double.Parse(txtTime.Text);

            lblInterest.Text=si.calculateInterest().ToString();
        }

         

    }
}
