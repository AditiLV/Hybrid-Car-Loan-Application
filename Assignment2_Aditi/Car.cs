using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Aditi
{
    class Car
    {
        private static double cityMilesDriven;
        private static double highwayMilesDriven;
        private static double[] avgGas = new double[10];
        public string model { get; set; }
        public string make { get; set; }
        private double intialPrice;
        private double cityGallon;
        private double highwayGallon;
        private double downPaymentAmt;
        public double downPaymentAmt1;

        private double annualinterestrate;
        private double loanPeriod;
        private double monthlyRate;
        private double monthyPayment;

        public Car(string make,string model,double intialPrice,double cityGallon,double highwayGallon)
        {
            this.make = make;
            this.model = model;
            this.intialPrice = intialPrice;
            this.cityGallon = cityGallon;
            this.highwayGallon = highwayGallon;
        }
        public Car(double downPaymentAmt, double annualinterestrate,double loanPeriod)
        {
            this.downPaymentAmt = downPaymentAmt;
            this.annualinterestrate = annualinterestrate;
            this.loanPeriod = loanPeriod;
        }
        public static double CityMileDriven
        {
            get
            {
                return cityMilesDriven;
            }
            set
            {
                cityMilesDriven = value;
            }
        }
        public static double HighwayMileDriven
        {
            get
            {
                return highwayMilesDriven;
            }
            set
            {
                highwayMilesDriven = value;
            }
        }
        public static double[] AvgGas
        {
            get
            {
                return avgGas;
            }
            set
            {
                avgGas = value;
            }
        }
        public double IntialPrice
        {
            get
            {
                return intialPrice;


            }
            set
            {
                intialPrice = value;
            }
        }
        public double CityGallon
        {
            get
            {
                return cityGallon;


            }
            set
            {
                cityGallon = value;
            }
        }
        public double HighwayGallon
        {
            get
            {
                return highwayGallon;


            }
            set
            {
                highwayGallon = value;
            }
        }

        public override string ToString()
        {
            return (String.Format("Make:{0} \nModel:{1} \nIntial Price:{2} \nCity Miles per Gallon:{3} \nHighway Miles per Gallon:{4} \n", make, model, IntialPrice, CityGallon, HighwayGallon));

        }
        public double DownPaymentAmt
        {
            get
            {
                return downPaymentAmt;


            }
            set
            {
                downPaymentAmt = value;
                
            }
        }
        public double Annualinterestrate
        {
            get
            {
                return annualinterestrate;


            }
            set
            {
                annualinterestrate = value;
            }
        }
        public double LoanPeriod
        {
            get
            {
                return loanPeriod;


            }
            set
            {
                loanPeriod = value;
            }
        }
        public double amortizedLoan()
        {
            double result;
            double d = 1 + Annualinterestrate/ 12;
            double power = Math.Pow(d, -LoanPeriod);
            result = (DownPaymentAmt * (Annualinterestrate / 12)) / (1 - power);
            result = Math.Round(result, 2);
            return result;

        }
        public double MonthlyRate
        {
            get
            {
                return monthlyRate = Annualinterestrate / 12;


            }
            set
            {
                monthlyRate = value;
            }
        }
        public double MonthyPayment
        {

            get
            {
                return monthyPayment = (monthlyRate / (1 - (Math.Pow((1 + monthlyRate), -(loanPeriod))))) * DownPaymentAmt; ;


            }
            set
            {
                monthyPayment = value;
            }

        }
       
        public string aLoan1()
        {
            double interestForMonth = DownPaymentAmt * MonthlyRate;
                double principalForMonth = MonthyPayment - interestForMonth;
            double payment = (DownPayment - DownPaymentAmt) * (Math.Pow((1 + (Annualinterestrate/100) / 12), LoanPeriod) * (Annualinterestrate / 100)) / (12 * (Math.Pow((1 + (Annualinterestrate / 100) / 12), (Annualinterestrate / 100)) - 1));

            DownPaymentAmt = DownPaymentAmt - MonthyPayment; // probably should be -= principalForMonth see comments below
                                           // output as necessary.
                string final;
            final = "Principal:" + principalForMonth + "\tInterest:" + interestForMonth + "\tBalance:" + DownPaymentAmt;
            return final;
        }

        //private const int MonthsPerYear = 12;

  
        //public double PurchasePrice { get; set; }

        public static double  DownPayment { get; set; }

 
        //public double LoanAmount
        //{
        //    get { return (PurchasePrice - DownPayment); }
        //}

     
        //public double InterestRate { get; set; }

     
        //public double LoanTermMonths { get; set; }

        //public double LoanTermYears
        //{
        //    get { return LoanTermMonths / MonthsPerYear; }
        //    set { LoanTermMonths = (value * MonthsPerYear); }
        //}

        //public double CalculatePayment()
        //{
        //    double payment = 0;

        //    if (LoanTermMonths > 0)
        //    {
        //        if (InterestRate != 0)
        //        {
        //            double rate = ((InterestRate / 12) / 100);
        //            double factor = (rate + (rate / (Math.Pow(rate + 1, LoanTermMonths) - 1)));
        //            payment = (LoanAmount * factor);
        //        }
        //        else payment = (LoanAmount / (double)LoanTermMonths);
        //    }
        //    return Math.Round(payment, 2);
        //}
    }
}
