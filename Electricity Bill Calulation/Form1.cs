namespace Electricity_Bill_Calulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Commercial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double OffPeakHour, peakhour, extra, total = 0, total1 = 0;
            if (Residential.Checked)
            {
                if (peakHour.Text == "")
                {
                    peakhour = 0;
                }
                else
                {
                    peakhour = Convert.ToDouble(peakHour.Text);
                }
                totalbill.Text = Convert.ToString(peakhour * 10.053);

            }
            else if (Commercial.Checked)
            {
                if (peakHour.Text == "")
                {
                    peakhour = 0;
                }
                else
                {
                    peakhour = Convert.ToDouble(peakHour.Text);
                    if (peakhour > 800)
                    {
                        extra = peakhour - 800;
                        total = (800 * 50) + (extra * 50.042);

                    }
                    else
                    {
                        total = peakhour * 50;
                    }
                }
                totalbill.Text = total.ToString();

            }
            else if (Industrial.Checked)
            {
                if (peakHour.Text == "")
                {
                    peakhour = 0;
                }
                else
                {
                    peakhour = Convert.ToDouble(peakHour.Text);

                    if (peakhour > 800)
                    {
                        extra = peakhour - 800;
                        total = (800 * 70) + (extra * 70.062);

                    }
                    else
                    {
                        total = peakhour * 70;
                    }
                }
                totalbill.Text = total.ToString();

                if (offPeakHour.Text == "")
                {
                    OffPeakHour = 0;
                }
                else
                {
                    OffPeakHour = Convert.ToDouble(offPeakHour.Text);
                    if (OffPeakHour > 800)
                    {
                        extra = OffPeakHour - 800;
                        total1 = (800 * 35) + (extra * 35.025);

                    }
                    else
                    {
                        total1 = OffPeakHour * 35;
                    }
                    double allTotal = total + total1;
                    totalbill.Text = allTotal.ToString();

                }
            }
        }
    }
}