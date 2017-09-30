using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_Aditi
{
    public partial class Form2 : Form
    {
        List<Car> car = new List<Car>();
        Form1 form11 = new Form1();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Car car1 = new Car(Double.Parse(txtLoanAmount.Text), Double.Parse(txtAnnualIntrate.Text), Double.Parse(txtloanPeriod.Text));
            car1.DownPaymentAmt = Double.Parse(txtLoanAmount.Text);
            car1.Annualinterestrate = Double.Parse(txtAnnualIntrate.Text);
            car1.LoanPeriod = Double.Parse(txtloanPeriod.Text);
            //string ansloan;
            //lblLoanDetails.Text += "The car is\t" + Form1.recentcar;
            //lblLoanDetails.Text += "\n";


            //ansloan = car1.amortizedLoan().ToString();
            //lblLoanDetails.Text += "The Monthly Loan is :" + ansloan;
            int months = int.Parse(txtloanPeriod.Text) * 12;
            string ans;
            for (int i = 1; i <= months; i++)
            {
                ans = i + "\t" + Form1.ip + "\t";
                ans += car1.aLoan1();
                ans += "\n";
                txtReportLoan.Text += ans;

            }
            //int months = int.Parse(txtloanPeriod.Text) * 12;
            //for(int i=1;i<= months;i++)
            //{

            //    string ans;
            //    ans = car1.CalculatePayment().ToString();
            //    txtReportLoan.Text += i;
            //    txtReportLoan.Text += "\tAmount";
            //    txtReportLoan.Text += Form1.ip.ToString();
            //    txtReportLoan.Text += "\tPrincipal ";
            //    txtReportLoan.Text += car1.LoanAmount;
            //    txtReportLoan.Text += "\tInterest";
            //    txtReportLoan.Text += car1.InterestRate;
            //    txtReportLoan.Text += "Balance";
            //    txtReportLoan.Text += Car.DownPayment;
            //    txtReportLoan.Text += "\n";

            //}




        }
    }
}
