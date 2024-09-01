using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
    internal class contract
    {

        public DateTime startDate;
        public DateTime endDate;
        private int daysRented;
        private Dictionary<String, String> rentalDetails;
        private customer customer;
        private Boolean additionalCharge;
        public double total;
        private Dictionary<String, double> charges;

        public contract(customer c, DateTime s, DateTime e, int d, Boolean ac) {

            this.customer = c;
            this.startDate = s;
            this.endDate = e;
            this.additionalCharge = ac;
            addRentalDetails();
            charges = new Dictionary<String, double>();

        }

        private void addRentalDetails()
        {
            rentalDetails = new Dictionary<String, String>();
            endDate = startDate.AddDays(daysRented);
            rentalDetails.Add("First Name", customer.getFirstName());
            rentalDetails.Add("Last Name", customer.getLastName());
            rentalDetails.Add("Age", customer.getAge().ToString());
            rentalDetails.Add("Email", customer.getEmail());
            rentalDetails.Add("Phone Number", customer.getPhone());
            rentalDetails.Add("DOL ID Number", customer.getIdNum().ToString());
            rentalDetails.Add("Rental Start Date", this.startDate.ToShortTimeString());
            rentalDetails.Add("Rental End Date", this.endDate.ToShortTimeString());
            rentalDetails.Add("Days Rented", this.daysRented.ToString());
            rentalDetails.Add("Additional Charges?", additionalCharge.ToString());

            if (!additionalCharge)
            {
                rentalDetails["Additional Charges?"] = "No";
            }
            
            else
            
            {
                rentalDetails["Additional Charges?"] = "Yes";

                foreach (KeyValuePair<string, double> entry in charges)
                {
                    rentalDetails.Add(entry.Key, entry.Value.ToString());
                }

            }

        }

        public void setStartPeriod(DateTime newStartDate)
        {
            this.startDate = newStartDate;
        }

        public void setEndDate(DateTime newEndDate)
        {
            this.endDate = newEndDate;
        }

        public void addCharge(String charge, double chargePrice)
        {
            charges.Add(charge, chargePrice);
        }

        public String getRentalDetails()
        {
            string returnStr = string.Empty;

            //foreach (String str in this.rentalDetailsList)
            //{
            //    returnStr += str;
            //    returnStr += "\n";
            //}

            foreach (KeyValuePair<string, string> entry in rentalDetails)
            {
                returnStr += entry.Key + ": " + entry.Value;
                returnStr += "\n";
            }

            return returnStr;
        }


    }
}
