﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
    internal class customer
    {
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNum;
        private List<string> customerDetails;
        private int age;
        private long idNum;
        private int rentalNums; // Keeps track of the number of rentals by a specific customer

        public customer()
        {
            this.firstName = string.Empty;
            this.lastName = string.Empty;
            this.email = string.Empty;
            this.phoneNum = string.Empty;
            this.age = 0;
            this.idNum = 0;
            customerDetails = new List<string>();
    }

    public customer(string firstName, string lastName, int age, long DOLNum, string email, string phoneNum)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNum = phoneNum;
            this.age = age;
            this.idNum = DOLNum;
            customerDetails = new List<string>();
            addDetails();
        }

        private void addDetails()
        {
            customerDetails.Add("First Name: " + this.getFirstName());
            customerDetails.Add("Last Name: " + this.getLastName());
            customerDetails.Add("Age: " + this.getAge().ToString());
            customerDetails.Add("Email: " + this.getEmail());
            customerDetails.Add("Phone Number: " + this.getPhone());
            customerDetails.Add("DOL ID Number: " + this.getIdNum().ToString());
        }

        public String getFirstName() => firstName;
        public String getLastName() => lastName;
        public String getEmail() => email;
        public String getPhone() => phoneNum;
        public int getAge() => age;

        public long getIdNum() => idNum;

        public void setFirstName(String newFirstName)
        {
            firstName = newFirstName;
        }

        public void setLastName(String newLastName)
        {
            lastName = newLastName;
        }
      
         public void setAge(int a)
         {
            age = a;
         }

        public void setEmail(String newEmail)
        {
            this.email = newEmail;
        }

        public void setPhoneNum(string newPhoneNum)
        {
            this.phoneNum = newPhoneNum;
        }

        public void setIdNum(int newIdNum)
        {
            this.idNum = newIdNum;
        }

        public string getCustomerDetails()
        {
            string returnStr = string.Empty;

            foreach (string str in customerDetails)
            {
                returnStr += str;
                returnStr += "\n";
            }

            return returnStr;
        }

        private void updateRentalNum()
        {
            this.rentalNums++;
        }

    }
}
