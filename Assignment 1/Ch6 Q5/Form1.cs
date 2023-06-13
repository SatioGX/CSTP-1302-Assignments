using System.Windows.Forms;

namespace Ch6_Q5
{
    public partial class Form1 : Form
    {
            const decimal oilChangePrice = 26.00m;
            const decimal lubeJobPrice = 18.00m;
            const decimal radiatorFlushPrice = 30.00m;
            const decimal transmissionFlushPrice = 80.00m;
            const decimal inspectionPrice = 15.00m;
            const decimal replaceMufflerPrice = 100.00m;
            const decimal tireRotationPrice = 20.00m;
            const decimal TAXRATE = 0.06m;           
        public Form1()
        {
            InitializeComponent();
            serviceAndLaborTextBox.Enabled = false;
            partsSummaryTextBox.Enabled = false;
            taxTextBox.Enabled = false;
            totalFeesTextBox.Enabled = false;

        }

        private decimal oilLubeCharges()
        {
            decimal subTotal = 0.00m;
            if (oilChange.Checked)
            {
                subTotal += oilChangePrice;
            }
            if (lubeJob.Checked)
            {
                subTotal += lubeJobPrice;
            }
            return subTotal;
        }

        private decimal flushCharges()
        {
            decimal subTotal = 0.00m;
            if (radiatorFlush.Checked)
            {
                subTotal += radiatorFlushPrice;
            }
            if (transmissionFlush.Checked)
            {
                subTotal += transmissionFlushPrice;
            }
            return subTotal;
        }

        private decimal miscCharges()
        {
            decimal subTotal = 0.00m;
            if (inspection.Checked)
            {
                subTotal += inspectionPrice;
            }
            if (replaceMuffler.Checked)
            {
                subTotal += replaceMufflerPrice;
            }
            if (tireRotation.Checked)
            {
                subTotal -= tireRotationPrice;
            }
            return subTotal;
        }

        private decimal otherCharges()
        {
            decimal subTotal = 0.00m;

            if (partsTextBox.Text == "")
            {
                partsTextBox.Text = "0";
                subTotal += 0.0m;
            }
            else
            {
                try
                {
                    subTotal += decimal.Parse(partsTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Input a valid number in 'parts'");
                }
            }

            if (laborTextBox.Text == "")
            {
                laborTextBox.Text = "0";
                subTotal += 0.0m;
            }
            else
            {
                try
                {
                    subTotal += decimal.Parse(laborTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Input a valid number in 'labor'");
                }
            }

            return subTotal;
        }
        private decimal taxCharges()
        {
            decimal taxTotal = 0.00m;
            taxTotal += decimal.Parse(partsTextBox.Text) * TAXRATE;

            return taxTotal;
        }

        private decimal totalCharges()
        {
            decimal total = 0.0m;
            total += oilLubeCharges();
            total += flushCharges();
            total += miscCharges();
            total += otherCharges();
            total += taxCharges();
            return total;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal serviceAndLaborFee = 0.00m;

            totalFeesTextBox.Text = $"${totalCharges()}";   
            
            serviceAndLaborFee = oilLubeCharges() + flushCharges() + miscCharges() + decimal.Parse(laborTextBox.Text);
            serviceAndLaborTextBox.Text = $"${serviceAndLaborFee}";

            partsSummaryTextBox.Text = $"${partsTextBox.Text}";

            taxTextBox.Text = $"${taxCharges()}";
        }

        private void clearOilLube()
        {
            oilChange.Checked = false;
            lubeJob.Checked = false;
        }

        private void clearFlushes()
        {
            radiatorFlush.Checked = false;
            transmissionFlush.Checked = false;
        }

        private void clearMisc()
        {
            inspection.Checked = false;
            replaceMuffler.Checked = false;
            tireRotation.Checked = false;
        }

        private void clearOther()
        {
            partsTextBox.Text = "";
            laborTextBox.Text = "";
        }

        private void clearFee()
        {
            serviceAndLaborTextBox.Text = "";
            partsSummaryTextBox.Text = "";
            taxTextBox.Text = "";
            totalFeesTextBox.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearOilLube();
            clearFlushes();
            clearMisc();
            clearOther();
            clearFee();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}