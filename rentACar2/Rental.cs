using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
    internal class Rental
    {
        public Vehicle vehicle;
        public String custFirstName;
        public String custLastName;
        public DateTime startDate;
        public DateTime endDate;
        private int rentalNum;
        private double averageRentalPeriod;
        private int totalDaysRented;
        private List<String> rentalDetailsList;

        public Rental()
        {
            vehicle = new Vehicle();
            this.custFirstName = string.Empty;
            this.custLastName = string.Empty;
            this.startDate = new DateTime();
            this.endDate = new DateTime();
            this.rentalNum = 0;
            this.averageRentalPeriod = 0.0;
        }

        public Rental(Vehicle v1, string firstName, string lastName, DateTime startDate, int daysRented)
        {
            vehicle = v1;
            rentalDetailsList = new List<String>();
            endDate = startDate.AddDays(daysRented);
            rentalDetailsList.Add("Active Rental\n");
            rentalDetailsList.Add("First Name: " + firstName);
            rentalDetailsList.Add("Last Name: " + lastName);
            rentalDetailsList.Add("\n");
            rentalDetailsList.Add("Start Date: " + startDate.Date.ToShortDateString());
            rentalDetailsList.Add("End Date: " + endDate.Date.ToShortDateString());
            this.rentalNum = 0;
            this.averageRentalPeriod = 0.0;
            this.totalDaysRented = 0;
        }

        public void setRentalRate(double newRate)
        {
            vehicle.setRate(newRate);
        }

        public void setCustomerName(String newFirstName, String newLastName)
        {
            custFirstName = newFirstName;
            custLastName = newLastName;
        }

        public void setStartPeriod(DateTime newStartDate)
        {
            this.startDate = newStartDate;
        }
        
        public void setEndDate(DateTime newEndDate)
        {
            this.endDate = newEndDate; 
        }

        public void updateRentalNum()
        {
            this.rentalNum++;
        }

        public void updateAverageRentalPeriod()
        {
            double totalRentedDays = (startDate - endDate).TotalDays;
            this.totalDaysRented += (int) Math.Round(totalRentedDays);
            this.averageRentalPeriod += (totalDaysRented / this.rentalNum);
        }

        public String getRentalDetails()
        {
            string returnStr = string.Empty;

            foreach (String str in this.rentalDetailsList)
            {        
                returnStr += str;
                returnStr += "\n";
            }

            return returnStr;
        }


    }
}
