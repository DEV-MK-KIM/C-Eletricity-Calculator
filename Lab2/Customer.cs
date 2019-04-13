using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    public class Customer
    {
        //INSTANT VARIABLES//

        private const decimal FLAT_RES = 6.00m;  // Residential Flat Rate (0 kWh)
        private const decimal RATE_RES = 0.052m; // Residential Regular Rate (After 0 kWh)

        private const decimal FLAT_COM = 60.00m; // Commerical Flat Rate (Between 0 and 1000 kWh)
        private const decimal RATE_COM = 0.045m; // Commercial Regular Rate (After 1000 kWh)

        private const decimal FLAT_IND_PEAK = 76.00m; // Indusrial Peak Hours Flat Rate (Between 0 and 1000 kWh)
        private const decimal RATE_IND_PEAK = 0.065m; // Indusrial Peak Hours Regular Rate (After 1000 kWh)

        private const decimal FLAT_IND_NO_PEAK = 40.00m; // Indusrial Non-Peak Hours Flat Rate (Between 0 and 1000 kWh)
        private const decimal RATE_IND_NO_PEAK = 0.028m; // Indusrial Non-Peak Hours Regular Rate (After 1000 kWh)

      
        protected int accountNo;
        protected string name;
        protected char type;
        protected decimal amount;


        // constructor

        public Customer(int a = 0, string n = "none", char t='N')
        {
            AccountNo = a;
            Name = n;
            Type = t;
            Amount = 0;
        }

        // get, set value
        public int AccountNo
        {
            get { return accountNo; }
            set { accountNo = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public char Type
        {
            get { return type; }
            set { type = value; }
        }


        /// <summary>
        /// Allows to calculate bill amount depending on customer type and electricity usage
        /// </summary>
        /// <param name="type">customer type</param>
        /// <param name="usage">usage for Residential and Commercial </param>
        /// <param name="peakUsage">Industrial Peak Hours Usage</param>
        /// <param name="noPeakUsage">Industrial No Peak Hours Usage</param>
        /// <returns></returns>
        public decimal CalculateCharge(char type, int usage, int peakUsage, int noPeakUsage)
        {

            if (type.Equals('R'))
            {

                return Residential(usage);

            }

            else if(type.Equals('C'))
            {

                return Commercial(usage);
            }
            else

                return Industrial(peakUsage, noPeakUsage);
        }

        /// <summary>
        /// Residential Bill Amount Calculation 
        /// </summary>
        /// <param name="usage"></param>
        /// <returns></returns>
        public decimal Residential(int usage)
        {
            if (usage >= 0)
            {
                Amount = (decimal)usage * RATE_RES + FLAT_RES;
            }
            return Amount;
        }

        /// <summary>
        /// Commercial Bill Amount Calculation 
        /// </summary>
        /// <param name="usage"></param>
        /// <returns></returns>
        public decimal Commercial(int usage)
        {
            if (usage > 1000)
            {
                Amount = (decimal)(usage - 1000) * RATE_COM + FLAT_COM;
            }
            else
                Amount = FLAT_COM;

            return Amount;
        }


        /// <summary>
        /// Industrial Bill Amount Calculation 
        /// </summary>
        /// <param name="peak">peak hour usage</param>
        /// <param name="no_peak">none peak hour usage</param>
        /// <returns></returns>
        public decimal Industrial(int peak, int no_peak)
        {

            decimal bill_peak; // peak hours bill
            decimal bill_no_peak; // none peak hours bill

            /// calculating peak hours bill
            if (peak > 1000)
            {
                bill_peak = (decimal)(peak - 1000) * RATE_IND_PEAK + FLAT_IND_PEAK;

            }

            else
            {
                bill_peak = FLAT_IND_PEAK;
            }

            /// calculating non-peak hours bill
            if (no_peak > 1000)
            {
                bill_no_peak = (decimal)(no_peak - 1000) * RATE_IND_NO_PEAK + FLAT_IND_NO_PEAK;

            }
            else
            {
                bill_no_peak = FLAT_IND_NO_PEAK;
            }

            /// total combined bill (peak + non-peak hours)
            Amount = bill_peak + bill_no_peak;

            return Amount;
        }


       // Not Overridden since this array dose not overwrite string value
       // returned array will appear on ListView Control.
        public String[] ToString()
        {

            //return $"{accountNo.ToString()}, {Name}, {Type}, {Amount.ToString("c")}";
            //return { c.AccountNo.ToString(), c.Name, c.Type.ToString(), c.Amount.ToString("c") };
            String[] arr = { accountNo.ToString(),Name,Type.ToString(),Amount.ToString("c") };
            return arr;
        }

        public string ToFileLine()
        {
           
            return $"{accountNo.ToString()},{Name},{Type},{Amount.ToString()}";
        }






    }
}

