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

        private double MiscCharges()
        {
            double charges = 0;

            if (checkBoxInspection.Checked)
            {
                charges += 15.00;
            }

            if (checkBoxReplaceMuffler.Checked)
            {
                charges += 100.00;
            }

            if (checkBoxTireRotation.Checked)
            {
                charges += 20.00;
            }

            return charges;
        }

        private double TaxCharges()
        {
            double charges = 0;

            if (textBoxParts.Text != "")
            {
               
            }

            return charges;
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double partsCost;
            double laborCost;

            if (double.TryParse(textBoxParts.Text, out partsCost) && double.TryParse(textBoxLabor.Text, out laborCost) )
            {
                double totalFees = OilLubeCharges() + FlushCharges() + MiscCharges();

                labelTotalFeesDisplay.Text = totalFees.ToString();
            }
            else
            {
                
            }
        }

        private void ClearOilLube()
        {
            checkBoxOilChange.Checked = false;
            checkBoxLubeJob.Checked = false;
        }

        private void ClearFlushes()
        {
            checkBoxRadiatorFlush.Checked = false;
            checkBoxTransmissionFlush.Checked = false;
        }

        private void ClearMisc()
        {
            checkBoxInspection.Checked = false;
            checkBoxReplaceMuffler.Checked = false;
            checkBoxTireRotation.Checked = false;
        }

        private void ClearOther()
        {
            textBoxParts.Text = "";
            textBoxLabor.Text = "";
        }

        private void ClearFees()
        {
            labelServiceAndLaborDisplay.Text = "";
            labelPartsDisplay.Text = "";
            labelTaxDisplay.Text = "";
            labelTotalFeesDisplay.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
