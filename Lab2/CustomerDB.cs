using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /*
    * This "CustomerDB" class was referenced 
    * from SAIT Instructor, Jolanta Warpechowska-Gruca's "ProductDB" class,
    * which was modified by M.K. Kim
    * 
    */
    public static class CustomerDB
    {
        const string PATH = "customers.txt";

        public static List<Customer> GetCustomers()
        {
            List<Customer> customerList = new List<Customer>();
            Customer c;
            string line;
            string[] fields;
            using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        fields = line.Split(',');

                        c = new Customer();
                        c.AccountNo = Convert.ToInt32(fields[0]);
                        c.Name = fields[1];
                        c.Type = Convert.ToChar(fields[2]);
                        c.Amount = Convert.ToDecimal(fields[3]);
                        customerList.Add(c);
                    }
                    sr.Close();
                }
            }

            return customerList;
        }

        public static void SaveProducts(List<Customer> customerList)
        {
            using (FileStream fs = new FileStream(PATH, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Customer c in customerList)
                    {
                        sw.WriteLine(c.ToFileLine());
                    }
                    sw.Close();
                }
            }
        }
    }

    

}
