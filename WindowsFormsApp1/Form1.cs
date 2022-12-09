using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double OilLubeCharges()
        {
            double charges = 0;

            if(checkBoxOilChange.Checked)
            {
                charges += 26.00;
            }

            if(checkBoxLubeJob.Checked)
            {
                charges += 18.00;
            }

            return charges;
        }

        private double FlushCharges()
        {
            double charges = 0;

            if(checkBoxRadiatorFlush.Checked)
            {
                charges += 30.00;
            }

            if(checkBoxTransmissionFlush.Checked)
            {
                charges += 80.00;
            }

            return charges;
        } 
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double totalFees = OilLubeCharges() + FlushCharges();

            labelTotalFeesDisplay.Text = totalFees.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
